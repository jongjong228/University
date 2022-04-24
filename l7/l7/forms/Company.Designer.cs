
namespace l7.forms
{
    partial class Company
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.telep = new System.Windows.Forms.TextBox();
            this.insp = new System.Windows.Forms.TextBox();
            this.form = new System.Windows.Forms.TextBox();
            this.formP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(150, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 23);
            this.name.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(150, 87);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(154, 23);
            this.address.TabIndex = 1;
            // 
            // telep
            // 
            this.telep.Location = new System.Drawing.Point(150, 125);
            this.telep.Name = "telep";
            this.telep.Size = new System.Drawing.Size(154, 23);
            this.telep.TabIndex = 2;
            // 
            // insp
            // 
            this.insp.Location = new System.Drawing.Point(150, 167);
            this.insp.Name = "insp";
            this.insp.Size = new System.Drawing.Size(154, 23);
            this.insp.TabIndex = 3;
            // 
            // form
            // 
            this.form.Location = new System.Drawing.Point(150, 205);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(154, 23);
            this.form.TabIndex = 4;
            // 
            // formP
            // 
            this.formP.Location = new System.Drawing.Point(150, 245);
            this.formP.Name = "formP";
            this.formP.Size = new System.Drawing.Size(154, 23);
            this.formP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Инспектор по кадрам:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Форма собственности:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Правовая форма:";
            // 
            // list
            // 
            this.list.Enabled = false;
            this.list.Location = new System.Drawing.Point(41, 295);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(154, 23);
            this.list.TabIndex = 12;
            this.list.Text = "Список совпадений";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(462, 295);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(367, 46);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(188, 23);
            this.comboBox.TabIndex = 14;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Список вакансий:";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 330);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formP);
            this.Controls.Add(this.form);
            this.Controls.Add(this.insp);
            this.Controls.Add(this.telep);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о компании";
            this.Load += new System.EventHandler(this.Company_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox telep;
        private System.Windows.Forms.TextBox insp;
        private System.Windows.Forms.TextBox form;
        private System.Windows.Forms.TextBox formP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button list;
    }
}