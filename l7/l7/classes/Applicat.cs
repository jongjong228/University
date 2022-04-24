using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Applicat
    {
        private int id, idDistrict, idClient, pay;
        private string position = "";

        public int getId()
        {
            return id;
        }

        public int getIdDistrict()
        {
            return idDistrict;
        }

        public int getIdClient()
        {
            return idClient;
        }

        public string getPosition()
        {
            return position;
        }

        public int getPay()
        {
            return pay;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setIdClient(int id)
        {
            this.idClient = id;
        }

        public void setIdDistrict(int id)
        {
            this.idDistrict = id;
        }

        public void setPosition(string name)
        {
            this.position = name;
        }

        public void setPay(int pay)
        {
            this.pay = pay;
        }

        public void setFields(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            position = reader.GetString(1);
            pay = reader.GetInt32(2);
            idDistrict = reader.GetInt32(3);
            idClient = reader.GetInt32(4);
        }
    }
}
