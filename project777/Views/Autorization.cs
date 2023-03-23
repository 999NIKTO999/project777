using project777.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_auth_Click(object sender, EventArgs e)
        {
            var context = new Context();
            var existUser = context.Users.FirstOrDefault(x => x.Login == textBox_login.Text.ToLower() && x.Password == textBox_password.Text);
            if (existUser == null)
            {

                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK);
                return;

            }
            this.Hide();
            var form = new FormBD(existUser);
            form.Closed += (s, args) => this.Show();
            form.Show();
            




        }

        private void bt_registration_Click(object sender, EventArgs e)
        {
            using var form = new FormRegistration();
            form.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
        }

      

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_password.PasswordChar = (char)0;
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormResetPassword();
            form2.Closed += (s, args) => this.Show();
            form2.Show();
        }
    }

     
}
