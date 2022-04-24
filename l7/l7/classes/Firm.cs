using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Firm
    {
        private int id;
        private string name;
        private string telephone;
        private string address;
        private string ownership;
        private string legalForm;
        private string inspector;
        private int IdEmployer;
        public int MyProperty { get; set; }

        public int getId()
        {
            return id;
        }

        public int getIdEmployer()
        {
            return IdEmployer;
        }

        public string getName()
        {
            return name;
        }

        public string getTelephone()
        {
            return telephone;
        }

        public string getAddress()
        {
            return address;
        }

        public string getOwnership()
        {
            return ownership;
        }

        public string getLegalForm()
        {
            return legalForm;
        }

        public string getInspector()
        {
            return inspector;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setIdEmployer(int id)
        {
            this.IdEmployer = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setTelephone(string name)
        {
            this.telephone = name;
        }

        public void setAddress(string name)
        {
            this.address = name;
        }

        public void setOwnership(string name)
        {
            this.ownership = name;
        }

        public void setLegalForm(string name)
        {
            this.legalForm = name;
        }

        public void setInspector(string name)
        {
            this.inspector = name;
        }

        public void setFields(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            name = reader.GetString(1);
            telephone = reader.GetString(2);
            address = reader.GetString(3);
            ownership = reader.GetString(4);
            legalForm = reader.GetString(5);
            inspector = reader.GetString(6);
            IdEmployer = reader.GetInt32(7);
        }
    }
}
