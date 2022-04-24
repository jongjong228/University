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
    public partial class CurAppls : Form
    {
        private List<int> idEduc = new List<int>();
        private List<Applicat> applicats = new List<Applicat>();
        private Company company;
        private Sentence sentence;
        private Client client = new Client();
        public CurAppls(Company company, Sentence sentence)
        {
            InitializeComponent();
            this.company = company;
            this.sentence = sentence;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            company.Show();
        }

        private void getEducList()
        {
            string sqlGetClient = $"SELECT idEducation from Client";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        idEduc.Add(reader.GetInt32(0));
                    }
                }
                reader.Close();

            }
        }

        private void CurAppls_Load(object sender, EventArgs e)
        {
            getEducList();
            string sqlGetClient = $"SELECT * from Application";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        Applicat applicat = new Applicat();
                        applicat.setFields(reader);
                        applicats.Add(applicat);
                        listBox.Items.Add(applicat.getPosition());
                    }
                }
                reader.Close();

            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                select.Enabled = true;
            }
            else select.Enabled = false;
        }

        private void loadClient()
        {
            string sqlGetClient = $"SELECT * from Client WHERE regNum={applicats[listBox.SelectedIndex].getIdClient()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    client.setFields(reader);
                }
                reader.Close();

            }
        }
        private void select_Click(object sender, EventArgs e)
        {
            loadClient();
            telep.Text = client.getTelephone();
            address.Text = client.getAddress();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private string getRequest()
        {
            string request = $"Select * from Application";
            if (area.Checked || money.Checked || educ.Checked || sex.Checked)
            {
                request += " WHERE ";
                if (area.Checked)
                    request += $"idDistrict={sentence.getIdDistrict()} AND ";
                if (sex.Checked)
                    request += $"(Select sex from Client WHERE regNum=Application.idClient)='{sentence.getSex()}' AND ";
                if (money.Checked)
                    request += $"pay<={sentence.getPay()} AND ";
                if (educ.Checked)
                    request += $"(Select idEducation from Client WHERE regNum=Application.idClient)={sentence.getIdEducation()} AND ";
                request = request.Remove(request.Length - 5);
            }
            return request;
        }

        private void updateAppls()
        {
            applicats.Clear();
            listBox.Items.Clear();
            string sqlGetClient = getRequest();
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        Applicat applicat = new Applicat();
                        applicat.setFields(reader);
                        applicats.Add(applicat);
                        listBox.Items.Add(applicat.getPosition());
                    }
                }
                reader.Close();

            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            sex.Checked = true;
            area.Checked = true;
            money.Checked = true;
            educ.Checked = true;
            updateAppls();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            sex.Checked = false;
            area.Checked = false;
            money.Checked = false;
            educ.Checked = false;
            updateAppls();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateAppls();
        }

        private void educ_CheckedChanged_1(object sender, EventArgs e)
        {
            updateAppls();
        }

        private void sex_CheckedChanged(object sender, EventArgs e)
        {
            updateAppls();
        }

        private void money_CheckedChanged(object sender, EventArgs e)
        {
            updateAppls();
        }
    }
}
