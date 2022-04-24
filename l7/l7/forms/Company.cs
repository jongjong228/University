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
    public partial class Company : Form
    {
        private List<Sentence> sentences = new List<Sentence>();
        private Firm firm;
        private Form previous;

        public Company(Form previous, Firm firm)
        {
            InitializeComponent();
            this.firm = firm;
            this.previous = previous;
        }

        private void setComboBox()
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
                        comboBox.Items.Add(dis.GetString(5));
                    }
                    dis.Close();
                }

            }

        }
        private void Company_Load(object sender, EventArgs e)
        {
            name.Text = firm.getName();
            address.Text = firm.getAddress();
            telep.Text = firm.getTelephone();
            insp.Text = firm.getInspector();
            form.Text = firm.getOwnership();
            formP.Text = firm.getLegalForm();
            setComboBox();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurAppls curAppls = new CurAppls(this, sentences[comboBox.SelectedIndex]);
            this.Hide();
            curAppls.Show();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedItem != null)
            {
                list.Enabled = true;
            } else
            {
                list.Enabled = false;
            }
        }
    }
}
