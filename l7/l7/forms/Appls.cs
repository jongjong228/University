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
    public partial class Appls : Form
    {
        private string fullName;
        private List<Applicat> applicats = new List<Applicat>();
        private int idClient;
        public Appls(List<Applicat> applicats,int id, string fullName)
        {
            InitializeComponent();
            this.applicats = applicats;
            this.idClient = id;
            this.fullName = fullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Appls_Load(object sender, EventArgs e)
        {
            foreach(Applicat applicat in applicats)
            {
                listBox.Items.Add(applicat.getPosition());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
                delete.Enabled = true;
            else delete.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            ClientMenu clientMenu = new ClientMenu(fullName);
            this.Close();
            clientMenu.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            NewAppl newAppl;
            if (listBox.SelectedItem != null)
            {
                newAppl = new NewAppl(this, applicats[listBox.SelectedIndex],idClient, fullName);
            }
            else
            { 
                newAppl = new NewAppl(this, null,idClient, fullName); 
            }
            this.Hide();
            newAppl.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string sqlDistrict = $"DELETE from Application WHERE id={applicats[listBox.SelectedIndex].getId()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand takeDist = new SqlCommand(sqlDistrict, connection);
                takeDist.ExecuteNonQuery();
            }
            applicats.RemoveAt(listBox.SelectedIndex);
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }
    }
}
