using project777.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project777
{
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private void FormResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
        
        }



        private void bt_clue_Click(object sender, EventArgs e)
        {
            var context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Login == textBox_login.Text.ToLower());
            if (user == null)
            {
                MessageBox.Show("Такой логин не найден", "Ошибка", MessageBoxButtons.OK);
                return;

            }
           if (textBox_login.Text == null)
            {

                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK);
                return;


            }



            var clue = context.UserCodeNames.FirstOrDefault(x => x.UserId == user.Id).Clue;

            MessageBox.Show(clue, "Подсказка", MessageBoxButtons.OK);
            


        }

        private void bt_checkcodename_Click(object sender, EventArgs e)
        {
            var context = new Context();
            var user = context.Users.FirstOrDefault(x => x.Login == textBox_login.Text.ToLower());
            if (user == null)
            {
                MessageBox.Show("Такой логин не найден", "Ошибка", MessageBoxButtons.OK);
                return;

            }

            var codename = context.UserCodeNames.FirstOrDefault(x => x.UserId == user.Id && x.CodeName == textBox_codename.Text.ToLower());
            if (codename == null)
            {
                MessageBox.Show("кодовое слово неверно", "Ошибка", MessageBoxButtons.OK);
                return;

            }


            this.Hide();
            var form2 = new FormResetPassword2Stage(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
