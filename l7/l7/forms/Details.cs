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
    public partial class Details : Form
    {
        private List<string> fields = new List<string>();
        private Dictionary<string,int> education = new Dictionary<string, int>();
        private Dictionary<string,int> district = new Dictionary<string, int>();
        private Form previous;
        private int idClient = 0;
        public Details(List<string> fields, Form previous)
        {
            InitializeComponent();
            this.fields = fields;
            this.previous = previous;
        }

        private void loadCBs()
        {
            string sqlDistrict = "SELECT * FROM District";
            string sqlEducation = "SELECT * FROM Education";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlDistrict, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    while (dis.Read())
                    {
                        district.Add(dis.GetString(1), dis.GetInt32(0));
                        area.Items.Add(dis.GetString(1));
                    }

                    dis.Close();
                }

                SqlCommand takeEduc = new SqlCommand(sqlEducation, connection);
                SqlDataReader educa = takeEduc.ExecuteReader();

                if (educa.HasRows) // если есть данные
                {
                    while (educa.Read())
                    {
                        education.Add(educa.GetString(1), educa.GetInt32(0));
                        educ.Items.Add(educa.GetString(1));
                    }

                    educa.Close();
                }
            }
        }

        private void Details_Load(object sender, EventArgs e)
        {
            loadCBs();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void sendNewClient()
        {
            int idEduc = education[educ.Text];
            string sqlClientInsert = $"INSERT INTO Client(receipt,firstName,secondName,thirdName,telephone,address,sex,idEducation) VALUES ('{number.Text}','{fields[0]}','{fields[1]}','{fields[2]}','{fields[4]}','{fields[3]}','{fields[7]}',{idEduc})";
            string sqlGetId = $"SELECT TOP 1 regNum from Client ORDER BY regNum DESC";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlClientInsert, connection);
                createClient.ExecuteNonQuery();
                createClient = new SqlCommand(sqlGetId, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    idClient = reader.GetInt32(0);
                }
                reader.Close();

            }
        }

        private void sendNewApplication()
        {
            int idArea = district[area.SelectedItem.ToString()];
            string sqlClientInsert = $"INSERT INTO Application(position,pay,idDistrict,idClient) VALUES ('{fields[5]}','{fields[6]}',{idArea},{idClient})";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlClientInsert, connection);
                createApplication.ExecuteNonQuery();
            }
        }

        private void sendNewAccount()
        {
            string sqlClientInsert = $"INSERT INTO Account VALUES (3,'{fields[0]}','{fields[1]}','{fields[1] + " " + fields[0] + " " + fields[2]}')";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlClientInsert, connection);
                createApplication.ExecuteNonQuery();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (number.Text != "" && area.SelectedItem != null && educ.SelectedItem != null)
            {
                sendNewAccount();
                sendNewClient();
                sendNewApplication();
                MessageBox.Show("Регистрация рошла успешна! Пожалуйста, поменяйте данные в окне меню", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Authorization authorization = new Authorization();
                this.Close();
                authorization.Show();
            }
            else MessageBox.Show("Незаполненные данные", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
