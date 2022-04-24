
namespace l7.forms
{
    partial class UpdateClient
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
            this.ok = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.oldPas = new System.Windows.Forms.TextBox();
            this.newPas = new System.Windows.Forms.TextBox();
            this.telep = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(310, 287);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 0;
            this.ok.Text = "Ок";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(41, 287);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(153, 42);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(151, 23);
            this.login.TabIndex = 2;
            // 
            // oldPas
            // 
            this.oldPas.Location = new System.Drawing.Point(153, 84);
            this.oldPas.Name = "oldPas";
            this.oldPas.PasswordChar = '*';
            this.oldPas.Size = new System.Drawing.Size(151, 23);
            this.oldPas.TabIndex = 3;
            // 
            // newPas
            // 
            this.newPas.Location = new System.Drawing.Point(153, 133);
            this.newPas.Name = "newPas";
            this.newPas.PasswordChar = '*';
            this.newPas.Size = new System.Drawing.Size(151, 23);
            this.newPas.TabIndex = 4;
            // 
            // telep
            // 
            this.telep.Location = new System.Drawing.Point(153, 181);
            this.telep.Name = "telep";
            this.telep.Size = new System.Drawing.Size(151, 23);
            this.telep.TabIndex = 5;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(153, 227);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(151, 23);
            this.address.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Старый пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Новый пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Адрес:";
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.telep);
            this.Controls.Add(this.newPas);
            this.Controls.Add(this.oldPas);
            this.Controls.Add(this.login);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ok);
            this.Name = "UpdateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateClient";
            this.Load += new System.EventHandler(this.UpdateClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox oldPas;
        private System.Windows.Forms.TextBox newPas;
        private System.Windows.Forms.TextBox telep;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}