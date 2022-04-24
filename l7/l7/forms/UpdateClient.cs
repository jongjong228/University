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
    public partial class UpdateClient : Form
    {
        private ClientMenu previous;
        private Client client;
        private Account account = new Account();
        private string fullName;
        public UpdateClient(ClientMenu clientMenu, Client client, string fullName)
        {
            InitializeComponent();
            this.previous = clientMenu;
            this.client = client;
            this.fullName = fullName;
        }

        private void loadAccount()
        {
            string sqlGetId = $"SELECT * from Account WHERE fullName='{fullName}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetId, connection);
                SqlDataReader reader = createClient.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    account.setFields(reader);
                }
                reader.Close();

            }
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            loadAccount();
            login.Text = account.getLogin();
            address.Text = client.getAddress();
            telep.Text = client.getTelephone();
        }

        private void updateAccount()
        {
            string sqlGetId = $"UPDATE Account Set login='{login.Text}',password='{newPas.Text}' WHERE fullName='{fullName}'";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetId, connection);
                createClient.ExecuteNonQuery();
            }
        }

        private void updateClient()
        {
            string sqlGetId = $"UPDATE Client Set address='{address.Text}',telephone='{telep.Text}' WHERE regNum={client.getId()}";
            using (SqlConnection connection = new SqlConnection(Client.connectionString))
            {
                connection.Open();
                SqlCommand createClient = new SqlCommand(sqlGetId, connection);
                createClient.ExecuteNonQuery();
            }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (!login.Text.Equals("") && !oldPas.Text.Equals("") && !newPas.Text.Equals("") && !telep.Text.Equals("") && !address.Text.Equals(""))
            {
                if (oldPas.Text.Equals(account.getPassword()))
                {
                    updateAccount();
                    updateClient();
                    ClientMenu clientMenu = new ClientMenu(fullName);
                    this.Close();
                    clientMenu.Show();


                } else MessageBox.Show("Неверный пароль", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else MessageBox.Show("ЗАПОЛНЕНЫ НЕ ВСЕ ПОЛЯ", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }
    }
}
