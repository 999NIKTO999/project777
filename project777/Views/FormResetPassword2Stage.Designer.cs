
namespace project777
{
    partial class FormResetPassword2Stage
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
            this.bt_newpassword = new System.Windows.Forms.Button();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_passwordvalidate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_newpassword
            // 
            this.bt_newpassword.Location = new System.Drawing.Point(301, 218);
            this.bt_newpassword.Name = "bt_newpassword";
            this.bt_newpassword.Size = new System.Drawing.Size(120, 51);
            this.bt_newpassword.TabIndex = 0;
            this.bt_newpassword.Text = "я больше не забуду пароль";
            this.bt_newpassword.UseVisualStyleBackColor = true;
            this.bt_newpassword.Click += new System.EventHandler(this.bt_newpassword_Click);
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(263, 170);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.PasswordChar = '*';
            this.textBox_password2.Size = new System.Drawing.Size(198, 23);
            this.textBox_password2.TabIndex = 1;
            // 
            // textBox_password1
            // 
            this.textBox_password1.Location = new System.Drawing.Point(263, 117);
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.Size = new System.Drawing.Size(198, 23);
            this.textBox_password1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый пароль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Подтверждение нового пароля";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_passwordvalidate
            // 
            this.lb_passwordvalidate.Location = new System.Drawing.Point(478, 117);
            this.lb_passwordvalidate.Name = "lb_passwordvalidate";
            this.lb_passwordvalidate.Size = new System.Drawing.Size(156, 76);
            this.lb_passwordvalidate.TabIndex = 5;
            this.lb_passwordvalidate.Text = "Пароль должен содержать не менее 6 символов, по крайней мере 1 заглавную букву, 1" +
    " строчную букву и 1 цифру без пробелов.";
            this.lb_passwordvalidate.Visible = false;
            this.lb_passwordvalidate.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // FormResetPassword2Stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.lb_passwordvalidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password1);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.bt_newpassword);
            this.Name = "FormResetPassword2Stage";
            this.Text = "Восстановить пароль";
            this.Load += new System.EventHandler(this.FormResetPassword2Stage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_newpassword;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.TextBox textBox_password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_passwordvalidate;
    }
}