
namespace project777
{
    partial class FormRegistration
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
            this.bt_registration = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_fathername = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_passwordaccept = new System.Windows.Forms.TextBox();
            this.textBox_codename = new System.Windows.Forms.TextBox();
            this.textBox_clue = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_registration
            // 
            this.bt_registration.Location = new System.Drawing.Point(231, 446);
            this.bt_registration.Name = "bt_registration";
            this.bt_registration.Size = new System.Drawing.Size(100, 23);
            this.bt_registration.TabIndex = 0;
            this.bt_registration.Text = "Зарегистрироваться";
            this.bt_registration.UseVisualStyleBackColor = true;
            this.bt_registration.Click += new System.EventHandler(this.bt_registration_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(205, 44);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(185, 23);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(205, 94);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(185, 23);
            this.textBox_lastname.TabIndex = 2;
            // 
            // textBox_fathername
            // 
            this.textBox_fathername.Location = new System.Drawing.Point(205, 142);
            this.textBox_fathername.Name = "textBox_fathername";
            this.textBox_fathername.Size = new System.Drawing.Size(185, 23);
            this.textBox_fathername.TabIndex = 3;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(205, 194);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(185, 23);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(205, 246);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(185, 23);
            this.textBox_password.TabIndex = 5;
            // 
            // textBox_passwordaccept
            // 
            this.textBox_passwordaccept.Location = new System.Drawing.Point(205, 297);
            this.textBox_passwordaccept.Name = "textBox_passwordaccept";
            this.textBox_passwordaccept.Size = new System.Drawing.Size(185, 23);
            this.textBox_passwordaccept.TabIndex = 6;
            // 
            // textBox_codename
            // 
            this.textBox_codename.Location = new System.Drawing.Point(205, 349);
            this.textBox_codename.Name = "textBox_codename";
            this.textBox_codename.Size = new System.Drawing.Size(185, 23);
            this.textBox_codename.TabIndex = 7;
            // 
            // textBox_clue
            // 
            this.textBox_clue.Location = new System.Drawing.Point(205, 395);
            this.textBox_clue.Name = "textBox_clue";
            this.textBox_clue.Size = new System.Drawing.Size(185, 23);
            this.textBox_clue.TabIndex = 8;
            this.textBox_clue.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(205, 26);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(31, 15);
            this.lable1.TabIndex = 9;
            this.lable1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(205, 124);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(58, 15);
            this.label_f.TabIndex = 11;
            this.label_f.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Подтверждение пароля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Кодовое слово";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Подсказка к кодовому слову";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_f);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.textBox_clue);
            this.Controls.Add(this.textBox_codename);
            this.Controls.Add(this.textBox_passwordaccept);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_fathername);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.bt_registration);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_registration;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_fathername;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_passwordaccept;
        private System.Windows.Forms.TextBox textBox_codename;
        private System.Windows.Forms.TextBox textBox_clue;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}