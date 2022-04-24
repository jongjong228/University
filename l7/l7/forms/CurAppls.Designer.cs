
namespace l7.forms
{
    partial class CurAppls
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
            this.telep = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.CheckBox();
            this.area = new System.Windows.Forms.CheckBox();
            this.educ = new System.Windows.Forms.CheckBox();
            this.money = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // telep
            // 
            this.telep.Location = new System.Drawing.Point(68, 264);
            this.telep.Name = "telep";
            this.telep.Size = new System.Drawing.Size(235, 23);
            this.telep.TabIndex = 0;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(68, 312);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(235, 23);
            this.address.TabIndex = 1;
            // 
            // select
            // 
            this.select.Enabled = false;
            this.select.Location = new System.Drawing.Point(133, 219);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 2;
            this.select.Text = "Выбрать";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(133, 370);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(61, 119);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(242, 94);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заявки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фильтры";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(227, 37);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Сбросить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(227, 78);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(98, 23);
            this.change.TabIndex = 14;
            this.change.Text = "Выбрать все";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(12, 40);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(49, 19);
            this.sex.TabIndex = 19;
            this.sex.Text = "Пол";
            this.sex.UseVisualStyleBackColor = true;
            this.sex.CheckedChanged += new System.EventHandler(this.sex_CheckedChanged);
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(114, 40);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(101, 19);
            this.area.TabIndex = 20;
            this.area.Text = "Район города";
            this.area.UseVisualStyleBackColor = true;
            this.area.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // educ
            // 
            this.educ.AutoSize = true;
            this.educ.Location = new System.Drawing.Point(114, 78);
            this.educ.Name = "educ";
            this.educ.Size = new System.Drawing.Size(99, 19);
            this.educ.TabIndex = 21;
            this.educ.Text = "Образование";
            this.educ.UseVisualStyleBackColor = true;
            this.educ.CheckedChanged += new System.EventHandler(this.educ_CheckedChanged_1);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(12, 78);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(42, 19);
            this.money.TabIndex = 22;
            this.money.Text = "ЗП";
            this.money.UseVisualStyleBackColor = true;
            this.money.CheckedChanged += new System.EventHandler(this.money_CheckedChanged);
            // 
            // CurAppls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 404);
            this.Controls.Add(this.money);
            this.Controls.Add(this.educ);
            this.Controls.Add(this.area);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.change);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.select);
            this.Controls.Add(this.address);
            this.Controls.Add(this.telep);
            this.Name = "CurAppls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подходящие заявки";
            this.Load += new System.EventHandler(this.CurAppls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telep;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.CheckBox sex;
        private System.Windows.Forms.CheckBox area;
        private System.Windows.Forms.CheckBox educ;
        private System.Windows.Forms.CheckBox money;
    }
}