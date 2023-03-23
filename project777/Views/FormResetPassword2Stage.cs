using project777.DataBase;
using project777.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace project777
{
    public partial class FormResetPassword2Stage : Form
    {

        private User _user;
        public FormResetPassword2Stage(User user)
        {
            InitializeComponent();
            _user = user;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_newpassword_Click(object sender, EventArgs e)
        {

            

            if (!string.Equals(textBox_password1.Text, textBox_password2.Text))
            {

                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK);
                return;

            }

            string pattern1 = @"^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$";
            if (!Regex.IsMatch(textBox_password1.Text, pattern1))
            {
                lb_passwordvalidate.Visible = true;
                lb_passwordvalidate.Text = "Пароль должен содержать не менее 6 символов, по крайней мере 1 заглавную букву, 1 строчную букву и 1 цифру без пробелов.";
                lb_passwordvalidate.ForeColor = Color.Red;
                return;
            }

            lb_passwordvalidate.Visible = false;
            var context = new Context();
            _user.Password = textBox_password1.Text;
            context.Users.Update(_user);
            context.SaveChanges();



            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void FormResetPassword2Stage_Load(object sender, EventArgs e)
        {
            





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
