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
    public partial class AdminMenu : Form
    {
        private List<Employer> employers = new List<Employer>();
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
                string sqlDistrict = "SELECT * FROM Account WHERE type=2";
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand takeDist = new SqlCommand(sqlDistrict, connection);
                    SqlDataReader dis = takeDist.ExecuteReader();
                    if (dis.HasRows) // если есть данные
                    {
                        while (dis.Read())
                        {
                            Employer employer = new Employer();
                            employer.setFields(dis);
                            employers.Add(employer);
                            listEmp.Items.Add(dis.GetString(4));
                        }
                        dis.Close();
                    }

                }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void deleteFromSQL(int index)
        {
            int indexx = 2;
            string sqlSelectId = $"SELECT id FROM Account WHERE fullName='{listEmp.SelectedItem.ToString()}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlSelectId, connection);
                SqlDataReader dis = createApplication.ExecuteReader();
                
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0);
                    dis.Close();
                }
                string sqlAccountDelete = $"DELETE FROM Account WHERE type=2 AND id={indexx}";
                createApplication = new SqlCommand(sqlAccountDelete, connection);
                createApplication.ExecuteNonQuery();
                employers.RemoveAt(listEmp.SelectedIndex);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteFromSQL(listEmp.SelectedIndex);
            listEmp.Items.RemoveAt(listEmp.SelectedIndex);
        }

        private void listEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmp.SelectedItem == null)
                delete.Enabled = false;
            else delete.Enabled = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewEmpl newEmpl;
            if (listEmp.SelectedItem != null)
            {
                newEmpl = new NewEmpl(this, employers[listEmp.SelectedIndex]);
            }
            else
            {
                newEmpl = new NewEmpl(this, new Employer());
            }
            this.Hide();
            newEmpl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
