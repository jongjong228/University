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
    public partial class NewAppl : Form
    {
        private Appls previous;
        private Applicat applicat;
        private int idClient;
        private string fullName;
        
        public NewAppl(Appls previous, Applicat applicat, int idClient, string fullName)
        {
            InitializeComponent();
            this.previous = previous;
            this.applicat = applicat;
            this.idClient = idClient;
            this.fullName = fullName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void loadCB()
        {
                string sqlEmplUpdate = $"SELECT name from District";
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                    SqlDataReader dis = takeDist.ExecuteReader();
                    if (dis.HasRows) // если есть данные
                    {
                        while (dis.Read())
                        {
                            area.Items.Add(dis.GetString(0));
                        }
                        dis.Close();
                    }

                }
            
        }

        private string getArea()
        {
            string indexx = "";
            string sqlEmplUpdate = $"SELECT name from District WHERE id={applicat.getIdDistrict()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetString(0);
                    dis.Close();
                }
                return indexx;
            }
        }

        private void NewAppl_Load(object sender, EventArgs e)
        {
            loadCB();
            if (applicat == null)
            {
                create.Enabled = true;
            }
            else
            {
                change.Enabled = true;
                work.Text = applicat.getPosition();
                money.Text = applicat.getPay().ToString();
                area.SelectedItem = getArea();
            }
        }

        private int getDistrictId()
        {
            int indexx = 0;
            string sqlEmplUpdate = $"SELECT id from District WHERE name='{area.SelectedItem}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0);
                    dis.Close();
                }
                return indexx;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            string sqlEmplUpdate = $"INSERT Application Values ('{work.Text}',{money.Text},{getDistrictId()},{idClient})";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                takeDist.ExecuteNonQuery();
            }
            ClientMenu clientMenu = new ClientMenu(fullName);
            this.Close();
            clientMenu.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string sqlEmplUpdate = $"UPDATE Application Set position='{work.Text}',pay={money.Text},idDistrict={getDistrictId()} WHERE id={applicat.getId()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                takeDist.ExecuteNonQuery();
            }
            this.Close();
            previous.Show();
        }
    }
}
