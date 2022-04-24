using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using l7.classes;
using Microsoft.Data.SqlClient;

namespace l7.forms
{
    public partial class EmployerMenu : Form
    {
        private List<Firm> firms = new List<Firm>();
        public EmployerMenu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void EmployerMenu_Load(object sender, EventArgs e)
        {
            string sqlFirm = "SELECT * FROM Firm";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlFirm, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    while (dis.Read())
                    {
                        Firm firm = new Firm();
                        firm.setFields(dis);
                        firms.Add(firm);
                        listBox.Items.Add(dis.GetString(1));
                    }
                    dis.Close();
                }
            }
        }

        private void deleteSqlFirm()
        {
            int indexx = 0, indexEmp = 0;
            string sqlSelectId = $"SELECT id,idEmployer FROM Firm WHERE name='{listBox.SelectedItem.ToString()}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlSelectId, connection);
                SqlDataReader dis = createApplication.ExecuteReader();

                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0);
                    indexEmp = dis.GetInt32(1);
                    dis.Close();
                }
                string sqlAccountDelete = $"DELETE FROM Firm WHERE id={indexx}";
                createApplication = new SqlCommand(sqlAccountDelete, connection);
                createApplication.ExecuteNonQuery();
                string sqlEmplDelete = $"DELETE FROM Employer WHERE id={indexEmp}";
                createApplication = new SqlCommand(sqlEmplDelete, connection);
                createApplication.ExecuteNonQuery();
                firms.RemoveAt(listBox.SelectedIndex);
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            deleteSqlFirm();
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                delete.Enabled = true;
                info.Enabled = true;
                update.Enabled = true;
            }
            else
            {
                delete.Enabled = false;
                info.Enabled = false;
                update.Enabled = false;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            AddCompany addCompany = new AddCompany(this, firms[listBox.SelectedIndex]);
            this.Hide();
            addCompany.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Company company = new Company(this, firms[listBox.SelectedIndex]);
            this.Hide();
            company.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddCompany addCompany = new AddCompany(this,null);
            this.Hide();
            addCompany.Show();
        }
    }
}
