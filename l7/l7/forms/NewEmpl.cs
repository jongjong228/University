using l7.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace l7.forms
{
    public partial class NewEmpl : Form
    {
        private AdminMenu previous;
        private Employer employer;
        public NewEmpl(AdminMenu previous,Employer employer)
        {
            InitializeComponent();
            this.previous = previous;
            this.employer = employer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();

        }

        private void NewEmpl_Load(object sender, EventArgs e)
        {
            name.Text = employer.getName();
            login.Text = employer.getLogin();
            if (!employer.getPassword().Equals(""))
            {
                password.Enabled = true;
            }
        }

        private void updateEmployer()
        {
            string sqlEmployerUpdate = $"UPDATE Account SET login='{employer.getLogin()}',password='{employer.getPassword()}',fullName='{employer.getName()}' WHERE id={employer.getId()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlEmployerUpdate, connection);
                createApplication.ExecuteNonQuery();
            }
        }

        private void createEmployer()
        {
            string sqlEmployerCreate = $"INSERT Account(type,login,password,fullName) VALUES (2,'{employer.getLogin()}','{employer.getPassword()}','{employer.getName()}')";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createApplication = new SqlCommand(sqlEmployerCreate, connection);
                createApplication.ExecuteNonQuery();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!password.Enabled && !newPass.Text.Equals(""))
            {
                employer.setLogin(login.Text);
                employer.setPassword(newPass.Text);
                employer.setName(name.Text);
                createEmployer();
                this.Close();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            } else
            if (password.Text.Equals(employer.getPassword()) && !newPass.Text.Equals(""))
            {
                employer.setLogin(login.Text);
                employer.setPassword(newPass.Text);
                employer.setName(name.Text);
                updateEmployer();
                this.Close();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                MessageBox.Show("Неверные пароли!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
