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
    public partial class ClientMenu : Form
    {
        private List<Applicat> applicats = new List<Applicat>();
        private List<Sentence> sentences = new List<Sentence>();
        private Client client = new Client();
        private string fullName;
        private Firm firm = new Firm();
        public ClientMenu(string fullName)
        {
            InitializeComponent();
            this.fullName = fullName;
        }

        private void loadClient()
        {
            string sqlGetClient = $"SELECT * from Client WHERE (secondName + ' ' + firstName + ' ' + thirdName)='{fullName}'";
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

        private void loadAppls()
        {
            string sqlGetClient = $"SELECT * from Application WHERE idClient={client.getId()}";
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
                    }
                }
                reader.Close();

            }
        }

        private void loadCurrentVacans()
        {
            foreach (Applicat applicat in applicats)
            {
                string sqlGetClient = $"SELECT * from Sentence";
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                    SqlDataReader reader = createClient.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            Sentence sentence = new Sentence();
                            sentence.setFields(reader);
                            sentences.Add(sentence);
                            listBox.Items.Add(sentence.getPosition());
                        }
                    }
                    reader.Close();

                }
            }
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            loadClient();
            loadAppls();
            loadCurrentVacans();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void appls_Click(object sender, EventArgs e)
        {
            Appls appls = new Appls(applicats,client.getId(),fullName);
            this.Hide();
            appls.Show();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                about.Enabled = true;
                select.Enabled = true;
            }
            else
            {
                about.Enabled = false;
                select.Enabled = false;
            }
        }

        private void loadFirm()
        {
            string sqlGetClient = $"SELECT * from Firm WHERE idEmployer={sentences[listBox.SelectedIndex].getIdEmployer()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    firm.setFields(reader);
                }
                reader.Close();

            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            money.Text = sentences[listBox.SelectedIndex].getPay().ToString();
            work.Text = sentences[listBox.SelectedIndex].getPosition();
            loadFirm();
            address.Text = firm.getAddress();
            telep.Text = firm.getTelephone();
        }

        private void about_Click(object sender, EventArgs e)
        {
            loadFirm();
            Company company = new Company(this,firm);
            this.Hide();
            company.Show();
        }

        private void reduc_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient(this, client,fullName);
            this.Hide();
            updateClient.Show();
        }

        private string getRequest(Applicat application)
        {
            string request = $"Select * from Sentence";
            if (areaF.Checked || moneyF.Checked || educF.Checked || sexF.Checked)
            {
                request += " WHERE ";
                if (areaF.Checked)
                    request += $"idDistrict={application.getIdDistrict()} AND ";
                if (sexF.Checked)
                    request += $"sex='{client.getSex()}' AND ";
                if (moneyF.Checked)
                    request += $"pay>={application.getPay()} AND ";
                if (educF.Checked)
                    request += $"idEducation={client.getIdEducation()} AND ";
                request = request.Remove(request.Length - 5);
            }
            return request;
        }

        private void updateSentences()
        {
            sentences.Clear();
            listBox.Items.Clear();
            foreach (Applicat applicat1 in applicats)
            {
                string sqlGetClient = getRequest(applicat1);
                using (SqlConnection connection = new SqlConnection(Client.connectionString))
                {
                    connection.Open();
                    SqlCommand createClient = new SqlCommand(sqlGetClient, connection);
                    SqlDataReader reader = createClient.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            Sentence sentence = new Sentence();
                            sentence.setFields(reader);
                            sentences.Add(sentence);
                            listBox.Items.Add(sentence.getPosition());
                        }
                    }
                    reader.Close();

                }
            }
        }

        private void sexF_CheckedChanged(object sender, EventArgs e)
        {
            updateSentences();
        }

        private void moneyF_CheckedChanged(object sender, EventArgs e)
        {
            updateSentences();
        }

        private void areaF_CheckedChanged(object sender, EventArgs e)
        {
            updateSentences();
        }

        private void educF_CheckedChanged(object sender, EventArgs e)
        {
            updateSentences();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            sexF.Checked = false;
            moneyF.Checked = false;
            areaF.Checked = false;
            educF.Checked = false;
            updateSentences();
        }

        private void change_Click(object sender, EventArgs e)
        {
            sexF.Checked = true;
            moneyF.Checked = true;
            areaF.Checked = true;
            educF.Checked = true;
            updateSentences();
        }
    }
}
