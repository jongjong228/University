using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace l7.classes
{
    public class Sentence
    {
        private int id;
        private int idEmployer;
        private int idDistrict;
        private int idEducation;
        private int numOfPlaces;
        private int age;
        private int pay;
        private string sex;
        private string position;

        public int getId()
        {
            return id;
        }

        public int getIdEmployer()
        {
            return idEmployer;
        }

        public int getIdDistrict()
        {
            return idDistrict;
        }

        public int getIdEducation()
        {
            return idEducation;
        }

        public int getNumOfPlaces()
        {
            return numOfPlaces;
        }

        public int getAge()
        {
            return age;
        }

        public int getPay()
        {
            return pay;
        }

        public string getSex()
        {
            return sex;
        }

        public string getPosition()
        {
            return position;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setIdEmployer(int id)
        {
            this.idEmployer = id;
        }

        public void setIdDistrict(int id)
        {
            this.idDistrict = id;
        }

        public void setIdEducation(int id)
        {
            this.idEducation = id;
        }

        public void setNumOfPlaces(int id)
        {
            this.numOfPlaces = id;
        }

        public void setAge(int id)
        {
            this.age = id;
        }

        public void setPay(int value)
        {
            this.pay = value;
        }

        public void setSex(string value)
        {
            this.sex = value;
        }

        public void setPosition(string value)
        {
            this.position = value;
        }

        public void setFields(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            numOfPlaces = reader.GetInt32(1);
            pay = reader.GetInt32(2);
            sex = reader.GetString(3);
            age = reader.GetInt32(4);
            position = reader.GetString(5);
            idEmployer = reader.GetInt32(6);
            idDistrict = reader.GetInt32(7);
            idEducation = reader.GetInt32(8);
        }
    }
}
