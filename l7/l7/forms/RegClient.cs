using l7.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace l7
{
    public partial class RegClient : Form
    {
        public RegClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.Show();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (fName.Text != "" && sName.Text != "" && tName.Text != "" && address.Text != "" && teleph.Text != "" && vacan.Text != "" && money.Text != "" && (sexF.Checked || sexM.Checked))
            {
                var fnameT = fName.Text;
                var snameT = sName.Text;
                var tnameT = tName.Text;
                var addressT = address.Text;
                var telepT = teleph.Text;
                var workT = vacan.Text;
                var moneyT = money.Text;
                string sexT;
                if (sexM.Checked)
                    sexT = "m";
                else sexT = "f";
                List<string> fields = new List<string>();
                fields.Add(fnameT);
                fields.Add(snameT);
                fields.Add(tnameT);
                fields.Add(addressT);
                fields.Add(telepT);
                fields.Add(workT);
                fields.Add(moneyT);
                fields.Add(sexT);
                Details details = new Details(fields,this);
                this.Hide();
                details.Show();
            }
            else MessageBox.Show("Нужно ввести все данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void teleph_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void vacan_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void money_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sexF_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
