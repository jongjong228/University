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
    public partial class AddSent : Form
    {
        private AddCompany previous;
        private EmployerMenu employerMenu;
        private Firm firm;
        private List<Sentence> sentences = new List<Sentence>();
        private int idEmpl;
        public AddSent(AddCompany previous, List<Sentence> sentences, EmployerMenu employerMenu, Firm firm,int idEmpl)
        {
            InitializeComponent();
            this.previous = previous;
            this.sentences = sentences;
            this.employerMenu = employerMenu;
            this.firm = firm;
            this.idEmpl = idEmpl;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private string getArea()
        {
            string indexx = "";
            string sqlEmplUpdate = $"SELECT name from District WHERE id={sentences[listBox.SelectedIndex].getIdDistrict()}";
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

        private string getEduc()
        {
            string indexx = "";
            string sqlEmplUpdate = $"SELECT name from Education WHERE id={sentences[listBox.SelectedIndex].getIdEducation()}";
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
    
        private void setArea()
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
                        areaC.Items.Add(dis.GetString(0));
                    }
                    dis.Close();
                }

            }
        }

        private void setEduc()
        {
            string sqlEmplUpdate = $"SELECT name from Education";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    while (dis.Read())
                    {
                        educC.Items.Add(dis.GetString(0));
                    }
                    dis.Close();
                }
                
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                change.Enabled = true;
                add.Enabled = false;
                money.Text = sentences[listBox.SelectedIndex].getPay().ToString();
                workPlaces.Text = sentences[listBox.SelectedIndex].getNumOfPlaces().ToString();
                age.Text = sentences[listBox.SelectedIndex].getAge().ToString();
                sex.Text = sentences[listBox.SelectedIndex].getSex();
                work.Text = sentences[listBox.SelectedIndex].getPosition();
                areaC.SelectedItem = getArea();
                educC.SelectedItem = getEduc();
            } else
            {
                change.Enabled = false;
                add.Enabled = true;
                money.Text = "";
                workPlaces.Text = "";
                age.Text = "";
                sex.Text = "";
                work.Text = "";
            }
        }

        private void AddSent_Load(object sender, EventArgs e)
        {
            foreach(Sentence sentence in sentences)
            {
                listBox.Items.Add(sentence.getPosition());
            }
            if (educC.Items.Count == 0) setEduc();
            if (areaC.Items.Count == 0) setArea();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (!money.Text.Equals("") && !workPlaces.Text.Equals("") && !age.Text.Equals("") && !sex.Text.Equals("") && !work.Text.Equals("") && areaC.SelectedItem != null && educC.SelectedItem != null)
            {
                string sqlEmplUpdate = $"UPDATE Sentence Set numOfPlace={workPlaces.Text},pay='{money.Text}',sex='{sex.Text}',age={age.Text},position='{work.Text}',idDistrict={(areaC.SelectedIndex + 1).ToString()},idEducation={(educC.SelectedIndex + 1).ToString()} WHERE id={sentences[listBox.SelectedIndex].getId().ToString()}";
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                    takeDist.ExecuteNonQuery();
                    AddCompany addCompany = new AddCompany(employerMenu, firm);
                    this.Close();
                    addCompany.Show();
                }

            } else MessageBox.Show("Поля не заполнены!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string getDistrictId()
        {
            string indexx = "";
            string sqlEmplUpdate = $"SELECT id from District WHERE name='{areaC.SelectedItem}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0).ToString();
                    dis.Close();
                }
                return indexx;
            }
        }

        private string getEducationId()
        {
            string indexx = "";
            string sqlEmplUpdate = $"SELECT id from Education WHERE name='{educC.SelectedItem}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                SqlDataReader dis = takeDist.ExecuteReader();
                if (dis.HasRows) // если есть данные
                {
                    dis.Read();
                    indexx = dis.GetInt32(0).ToString();
                    dis.Close();
                }
                return indexx;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!money.Text.Equals("") && !workPlaces.Text.Equals("") && !age.Text.Equals("") && !sex.Text.Equals("") && !work.Text.Equals("") && areaC.SelectedItem != null && educC.SelectedItem != null)
            {
                string sqlEmplUpdate = $"INSERT Sentence VALUES ({workPlaces.Text},'{money.Text}','{sex.Text}',{age.Text},'{work.Text}',{idEmpl.ToString()},{getDistrictId()},{getEducationId()})";
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand takeDist = new SqlCommand(sqlEmplUpdate, connection);
                    takeDist.ExecuteNonQuery();
                    AddCompany addCompany = new AddCompany(employerMenu, firm);
                    this.Close();
                    addCompany.Show();

                }
            }
            else MessageBox.Show("Поля не заполнены!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
