
namespace l7.forms
{
    partial class AddSent
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
            this.sex = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.workPlaces = new System.Windows.Forms.TextBox();
            this.work = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.areaC = new System.Windows.Forms.ComboBox();
            this.educC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(340, 153);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(134, 23);
            this.sex.TabIndex = 0;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(340, 182);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(134, 23);
            this.age.TabIndex = 2;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(113, 153);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(122, 23);
            this.money.TabIndex = 3;
            this.money.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // workPlaces
            // 
            this.workPlaces.Location = new System.Drawing.Point(113, 182);
            this.workPlaces.Name = "workPlaces";
            this.workPlaces.Size = new System.Drawing.Size(122, 23);
            this.workPlaces.TabIndex = 4;
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(113, 211);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(281, 23);
            this.work.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(382, 327);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(219, 366);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Location = new System.Drawing.Point(55, 327);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 9;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(117, 42);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(277, 94);
            this.listBox.TabIndex = 10;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Список вакансий:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "ЗП:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Образование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Мин возраст:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Район города:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Рабочие места:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пол:";
            // 
            // areaC
            // 
            this.areaC.FormattingEnabled = true;
            this.areaC.Location = new System.Drawing.Point(114, 240);
            this.areaC.Name = "areaC";
            this.areaC.Size = new System.Drawing.Size(150, 23);
            this.areaC.TabIndex = 19;
            // 
            // educC
            // 
            this.educC.FormattingEnabled = true;
            this.educC.Location = new System.Drawing.Point(113, 269);
            this.educC.Name = "educC";
            this.educC.Size = new System.Drawing.Size(151, 23);
            this.educC.TabIndex = 20;
            // 
            // AddSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 405);
            this.Controls.Add(this.educC);
            this.Controls.Add(this.areaC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.change);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.work);
            this.Controls.Add(this.workPlaces);
            this.Controls.Add(this.money);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Name = "AddSent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вакансию";
            this.Load += new System.EventHandler(this.AddSent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox workPlaces;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox areaC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox educC;
    }
}