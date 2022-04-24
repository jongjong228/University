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
    public partial class AddCompany : Form
    {
        private List<Sentence> sentences = new List<Sentence>();
        private Firm firm;
        private EmployerMenu previous;
        public AddCompany(EmployerMenu previous,Firm firm)
        {
            InitializeComponent();
            this.previous = previous;
            this.firm = firm;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private string getServices()
        {
            string sqlSelectId = $"SELECT treaty FROM Employer WHERE id={firm.getIdEmployer()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlSelectId, connection);
                SqlDataReader dis = createApplication.ExecuteReader();

                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    string treaty = dis.GetString(0);
                    dis.Close();
                    return treaty;
                }
                return "";
            }
        }

        private void setListBox()
        {
            string sqlDistrict = $"SELECT * FROM Sentence WHERE idEmployer={firm.getIdEmployer()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlDistrict, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    while (dis.Read())
                    {
                        Sentence sentence = new Sentence();
                        sentence.setFields(dis);
                        sentences.Add(sentence);
                        listBox.Items.Add(dis.GetString(5));
                    }
                    dis.Close();
                }

            }
        }
        private void AddCompany_Load(object sender, EventArgs e)
        {
            if (firm != null)
            {
                name.Text = firm.getName();
                address.Text = firm.getAddress();
                formP.Text = firm.getLegalForm();
                telep.Text = firm.getTelephone();
                form.Text = firm.getOwnership();
                insp.Text = firm.getInspector();
                services.Text = getServices();
                setListBox();
            } 
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void updateFirm()
        {
            string sqlDistrict = $"UPDATE Firm Set name='{name.Text}',address='{address.Text}',telephone='{telep.Text}',ownership='{form.Text}',legalForm='{formP.Text}',inspector='{insp.Text}' WHERE id={firm.getId()}";
            string sqlEmplUpdate = $"UPDATE Employer SET treaty='{services.Text}' WHERE id={firm.getIdEmployer()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlDistrict, connection);
                takeDist.ExecuteNonQuery();
                takeDist = new SqlCommand(sqlEmplUpdate, connection);
                takeDist.ExecuteNonQuery();
            }
        }

        private void insertFirm()
        {
            int indexx = 0;
            string sqlEmplUpdate = $"INSERT Employer VALUES ({services.Text})";
            string sqlIdEmploer = $"SELECT id from Employer WHERE treaty='{services.Text}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                takeDist.ExecuteNonQuery();
                takeDist = new SqlCommand(sqlIdEmploer, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0);
                    dis.Close();
                }
                string sqlDistrict = $"INSERT Firm VALUES ('{name.Text}','{telep.Text}','{address.Text}','{form.Text}','{formP.Text}','{insp.Text}',{indexx})";
                takeDist = new SqlCommand(sqlDistrict, connection);
                takeDist.ExecuteNonQuery();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!name.Text.Equals("") && !address.Text.Equals("") && !formP.Text.Equals("") && !form.Text.Equals("") && !telep.Text.Equals("") && !insp.Text.Equals("") && !services.Text.Equals(""))
            {
                if (firm != null)
                    updateFirm();
                else
                    insertFirm();
                EmployerMenu employerMenu = new EmployerMenu();
                this.Close();
                employerMenu.Show();
                
            }
            else MessageBox.Show("Поля не заполнены!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void vacans_Click(object sender, EventArgs e)
        {
            AddSent addSent = new AddSent(this,sentences,previous,firm,firm.getIdEmployer());
            this.Hide();
            addSent.Show();
        }
    }
}
