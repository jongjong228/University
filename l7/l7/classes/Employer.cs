using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Employer
    {
        private int id;
        private string login = "";
        private string password = "";
        private string fullName = "";

        public int getId()
        {
            return this.id;
        }

        public string getLogin()
        {
            return this.login;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getName()
        {
            return this.fullName;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setName(string name)
        {
            this.fullName = name;
        }

        public void setFields(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.login = reader.GetString(2);
            this.password = reader.GetString(3);
            this.fullName = reader.GetString(4);
        }

    }
}
