
namespace l7.forms
{
    partial class NewAppl
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
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.work = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Enabled = false;
            this.create.Location = new System.Drawing.Point(312, 71);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 0;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Location = new System.Drawing.Point(312, 112);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 1;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(312, 165);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(106, 68);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(165, 23);
            this.work.TabIndex = 3;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(106, 112);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 23);
            this.money.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Должность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мин ЗП:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите район города";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.Location = new System.Drawing.Point(28, 166);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(191, 23);
            this.area.TabIndex = 9;
            // 
            // NewAppl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 236);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.work);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.change);
            this.Controls.Add(this.create);
            this.Name = "NewAppl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заявку";
            this.Load += new System.EventHandler(this.NewAppl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox area;
    }
}