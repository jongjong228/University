using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Account
    {
        private int id, type;
        private string login, password, fullName;

        public int getId()
        {
            return id;
        }

        public int gettype()
        {
            return type;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

        public string getFullName()
        {
            return fullName;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setType(int id)
        {
            this.type = id;
        }

        public void setLogin(string name)
        {
            this.login = name;
        }

        public void setPassword(string name)
        {
            this.password = name;
        }

        public void setName(string name)
        {
            this.fullName = name;
        }

        public void setFields(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            type = reader.GetInt32(1);
            login = reader.GetString(2);
            password = reader.GetString(3);
            fullName = reader.GetString(4);
        }
    }
}
