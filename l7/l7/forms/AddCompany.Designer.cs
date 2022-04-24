
namespace l7.forms
{
    partial class AddCompany
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
            this.form = new System.Windows.Forms.TextBox();
            this.insp = new System.Windows.Forms.TextBox();
            this.formP = new System.Windows.Forms.TextBox();
            this.services = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.vacans = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(195, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 23);
            this.name.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(195, 78);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(173, 23);
            this.address.TabIndex = 1;
            // 
            // telep
            // 
            this.telep.Location = new System.Drawing.Point(195, 116);
            this.telep.Name = "telep";
            this.telep.Size = new System.Drawing.Size(173, 23);
            this.telep.TabIndex = 2;
            // 
            // form
            // 
            this.form.Location = new System.Drawing.Point(195, 163);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(173, 23);
            this.form.TabIndex = 3;
            // 
            // insp
            // 
            this.insp.Location = new System.Drawing.Point(195, 204);
            this.insp.Name = "insp";
            this.insp.Size = new System.Drawing.Size(173, 23);
            this.insp.TabIndex = 4;
            // 
            // formP
            // 
            this.formP.Location = new System.Drawing.Point(195, 245);
            this.formP.Name = "formP";
            this.formP.Size = new System.Drawing.Size(173, 23);
            this.formP.TabIndex = 5;
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(195, 288);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(173, 23);
            this.services.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Форма собственности:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Инспектор по кадрам:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Правовая форма:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Договор об оказании услуг:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Список вакансий:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(73, 348);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(324, 94);
            this.listBox.TabIndex = 15;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(313, 484);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 23);
            this.add.TabIndex = 16;
            this.add.Text = "Изменить/Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // vacans
            // 
            this.vacans.Location = new System.Drawing.Point(202, 534);
            this.vacans.Name = "vacans";
            this.vacans.Size = new System.Drawing.Size(75, 23);
            this.vacans.TabIndex = 17;
            this.vacans.Text = "Вакансии";
            this.vacans.UseVisualStyleBackColor = true;
            this.vacans.Click += new System.EventHandler(this.vacans_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(69, 484);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 18;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 589);
            this.Controls.Add(this.back);
            this.Controls.Add(this.vacans);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.services);
            this.Controls.Add(this.formP);
            this.Controls.Add(this.insp);
            this.Controls.Add(this.form);
            this.Controls.Add(this.telep);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Name = "AddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить компанию";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox telep;
        private System.Windows.Forms.TextBox form;
        private System.Windows.Forms.TextBox insp;
        private System.Windows.Forms.TextBox formP;
        private System.Windows.Forms.TextBox services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button vacans;
        private System.Windows.Forms.Button back;
    }
}