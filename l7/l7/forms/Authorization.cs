using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using l7.classes;
using l7.forms;
using Microsoft.Data.SqlClient;

namespace l7
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            RegClient regClient = new RegClient();
            this.Hide();
            regClient.ShowDialog();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            var loginText = login.Text;
            var passwordText = password.Text;
            string fullName;
            string sqlExpression = $"SELECT type,fullName FROM Account WHERE login='{loginText}' AND password='{passwordText}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    int type = reader.GetInt32(0);
                    if (type == 1)
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        this.Hide();
                        adminMenu.ShowDialog();
                    }
                    else if (type == 2)
                    {
                        EmployerMenu employerMenu = new EmployerMenu();
                        this.Hide();
                        employerMenu.ShowDialog();
                    }
                    else
                    {
                        fullName = reader.GetString(1);
                        ClientMenu clientMenu = new ClientMenu(fullName);
                        this.Hide();
                        clientMenu.ShowDialog();
                    }

                    reader.Close();
                }
                else MessageBox.Show("Неверные данные!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
