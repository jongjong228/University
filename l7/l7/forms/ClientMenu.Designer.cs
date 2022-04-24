
namespace l7.forms
{
    partial class ClientMenu
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
            this.appls = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.telep = new System.Windows.Forms.TextBox();
            this.work = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reduc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sexF = new System.Windows.Forms.CheckBox();
            this.moneyF = new System.Windows.Forms.CheckBox();
            this.areaF = new System.Windows.Forms.CheckBox();
            this.educF = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appls
            // 
            this.appls.Location = new System.Drawing.Point(386, 296);
            this.appls.Name = "appls";
            this.appls.Size = new System.Drawing.Size(75, 23);
            this.appls.TabIndex = 0;
            this.appls.Text = "Заявки";
            this.appls.UseVisualStyleBackColor = true;
            this.appls.Click += new System.EventHandler(this.appls_Click);
            // 
            // about
            // 
            this.about.Enabled = false;
            this.about.Location = new System.Drawing.Point(71, 296);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(98, 23);
            this.about.TabIndex = 1;
            this.about.Text = "О компании";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(71, 342);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // select
            // 
            this.select.Enabled = false;
            this.select.Location = new System.Drawing.Point(225, 169);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 3;
            this.select.Text = "Выбрать";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(332, 217);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(161, 23);
            this.address.TabIndex = 4;
            // 
            // telep
            // 
            this.telep.Location = new System.Drawing.Point(332, 246);
            this.telep.Name = "telep";
            this.telep.Size = new System.Drawing.Size(161, 23);
            this.telep.TabIndex = 5;
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(98, 217);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(144, 23);
            this.work.TabIndex = 6;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(98, 246);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 23);
            this.money.TabIndex = 7;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(88, 53);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(202, 94);
            this.listBox.TabIndex = 8;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вакансии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ЗП:";
            // 
            // reduc
            // 
            this.reduc.Location = new System.Drawing.Point(377, 342);
            this.reduc.Name = "reduc";
            this.reduc.Size = new System.Drawing.Size(116, 23);
            this.reduc.TabIndex = 14;
            this.reduc.Text = "Изменить данные";
            this.reduc.UseVisualStyleBackColor = true;
            this.reduc.Click += new System.EventHandler(this.reduc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Фильтры";
            // 
            // sexF
            // 
            this.sexF.AutoSize = true;
            this.sexF.Location = new System.Drawing.Point(315, 63);
            this.sexF.Name = "sexF";
            this.sexF.Size = new System.Drawing.Size(49, 19);
            this.sexF.TabIndex = 16;
            this.sexF.Text = "Пол";
            this.sexF.UseVisualStyleBackColor = true;
            this.sexF.CheckedChanged += new System.EventHandler(this.sexF_CheckedChanged);
            // 
            // moneyF
            // 
            this.moneyF.AutoSize = true;
            this.moneyF.Location = new System.Drawing.Point(426, 63);
            this.moneyF.Name = "moneyF";
            this.moneyF.Size = new System.Drawing.Size(42, 19);
            this.moneyF.TabIndex = 17;
            this.moneyF.Text = "ЗП";
            this.moneyF.UseVisualStyleBackColor = true;
            this.moneyF.CheckedChanged += new System.EventHandler(this.moneyF_CheckedChanged);
            // 
            // areaF
            // 
            this.areaF.AutoSize = true;
            this.areaF.Location = new System.Drawing.Point(315, 97);
            this.areaF.Name = "areaF";
            this.areaF.Size = new System.Drawing.Size(101, 19);
            this.areaF.TabIndex = 18;
            this.areaF.Text = "Район города";
            this.areaF.UseVisualStyleBackColor = true;
            this.areaF.CheckedChanged += new System.EventHandler(this.areaF_CheckedChanged);
            // 
            // educF
            // 
            this.educF.AutoSize = true;
            this.educF.Location = new System.Drawing.Point(426, 97);
            this.educF.Name = "educF";
            this.educF.Size = new System.Drawing.Size(99, 19);
            this.educF.TabIndex = 19;
            this.educF.Text = "Образование";
            this.educF.UseVisualStyleBackColor = true;
            this.educF.CheckedChanged += new System.EventHandler(this.educF_CheckedChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(315, 124);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 20;
            this.clear.Text = "Сброс";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(426, 124);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(85, 23);
            this.change.TabIndex = 21;
            this.change.Text = "Выбрать все";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 401);
            this.Controls.Add(this.change);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.educF);
            this.Controls.Add(this.areaF);
            this.Controls.Add(this.moneyF);
            this.Controls.Add(this.sexF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reduc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.money);
            this.Controls.Add(this.work);
            this.Controls.Add(this.telep);
            this.Controls.Add(this.address);
            this.Controls.Add(this.select);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.appls);
            this.Name = "ClientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню пользователя";
            this.Load += new System.EventHandler(this.ClientMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appls;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox telep;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reduc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox sexF;
        private System.Windows.Forms.CheckBox moneyF;
        private System.Windows.Forms.CheckBox areaF;
        private System.Windows.Forms.CheckBox educF;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button change;
    }
}