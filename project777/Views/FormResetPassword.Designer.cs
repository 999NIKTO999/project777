
namespace project777
{
    partial class FormResetPassword
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
            this.bt_clue = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_codename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_checkcodename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_clue
            // 
            this.bt_clue.Location = new System.Drawing.Point(383, 159);
            this.bt_clue.Name = "bt_clue";
            this.bt_clue.Size = new System.Drawing.Size(89, 43);
            this.bt_clue.TabIndex = 0;
            this.bt_clue.Text = "Получить подсказку";
            this.bt_clue.UseVisualStyleBackColor = true;
            this.bt_clue.Click += new System.EventHandler(this.bt_clue_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(292, 68);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(180, 23);
            this.textBox_login.TabIndex = 2;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_codename
            // 
            this.textBox_codename.Location = new System.Drawing.Point(292, 113);
            this.textBox_codename.Name = "textBox_codename";
            this.textBox_codename.Size = new System.Drawing.Size(180, 23);
            this.textBox_codename.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кодовое слово";
            // 
            // bt_checkcodename
            // 
            this.bt_checkcodename.Location = new System.Drawing.Point(292, 159);
            this.bt_checkcodename.Name = "bt_checkcodename";
            this.bt_checkcodename.Size = new System.Drawing.Size(85, 43);
            this.bt_checkcodename.TabIndex = 7;
            this.bt_checkcodename.Text = "Продолжить";
            this.bt_checkcodename.UseVisualStyleBackColor = true;
            this.bt_checkcodename.Click += new System.EventHandler(this.bt_checkcodename_Click);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.bt_checkcodename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_codename);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.bt_clue);
            this.Name = "FormResetPassword";
            this.Text = "Восстановить пароль";
            this.Load += new System.EventHandler(this.FormResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_clue;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_codename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_checkcodename;
    }
}