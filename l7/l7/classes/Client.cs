using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Client
    {
        private int id;
        private string receipt;
        private string fName;
        private string sName;
        private string tName;
        private string telephone;
        private string address;
        private string sex;
        private int idEducation;
        public static string connectionString = "Server=DESKTOP-3H64NG5;Database=Office;Trusted_Connection=True;Encrypt=False";
        public int getId()
        {
            return id;
        }

        public int getIdEducation()
        {
            return idEducation;
        }

        public string getReceipt()
        {
            return receipt;
        }

        public string getFName()
        {
            return fName;
        }

        public string getSName()
        {
            return sName;
        }

        public string getTName()
        {
            return tName;
        }

        public string getTelephone()
        {
            return telephone;
        }

        public string getAddress()
        {
            return address;
        }

        public string getSex()
        {
            return sex;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setIdEducation(int id)
        {
            this.idEducation = id;
        }

        public void setReceipt(string name)
        {
            this.receipt = name;
        }

        public void setFName(string name)
        {
            this.fName = name;
        }

        public void setSName(string name)
        {
            this.sName = name;
        }

        public void setTName(string name)
        {
            this.tName = name;
        }

        public void setTelephone(string name)
        {
            this.telephone = name;
        }

        public void getAddress(string name)
        {
            this.address = name;
        }

        public void getSex(string name)
        {
            this.sex = name;
        }

        public void setFields(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            receipt = reader.GetString(1);
            fName = reader.GetString(2);
            sName = reader.GetString(3);
            tName = reader.GetString(4);
            telephone = reader.GetString(5);
            address = reader.GetString(6);
            sex = reader.GetString(7);
            idEducation = reader.GetInt32(8);
        }
    }
}
