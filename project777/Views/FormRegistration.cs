using project777.DataBase;
using project777.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace project777
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_registration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {

                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(textBox_lastname.Text))
            {

                MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_fathername.Text))
            {

                MessageBox.Show("Заполните отчество", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_codename.Text))
            {

                MessageBox.Show("Заполните кодовое слово", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_clue.Text))
            {

                MessageBox.Show("Введите подсказку для кодового слова", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_password.Text))
            {

                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (!string.Equals(textBox_password.Text, textBox_passwordaccept.Text))
            {

                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK);
                return;

            }

            if (string.IsNullOrWhiteSpace(textBox_login.Text))
            {

                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK);
                return;
            }

          
            string pattern1 = @"^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$";
            if (!Regex.IsMatch(textBox_password.Text, pattern1))
            {

                MessageBox.Show("Пароль должен содержать не менее 6 символов, по крайней мере 1 заглавную букву, 1 строчную букву и 1 цифру без пробелов.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string pattern2 = @"^[А-я,а-я]+$";
            if (!Regex.IsMatch(textBox_name.Text, pattern2))
            {

                MessageBox.Show("Неправильно введено имя", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (!Regex.IsMatch(textBox_lastname.Text, pattern2))
            {

                MessageBox.Show("Неправильно введена фамилия", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (!Regex.IsMatch(textBox_name.Text, pattern2))
            {

                MessageBox.Show("Неправильно введено отчество", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            string pattern3 = @"^[A-Za-z0-9]+([A-Za-z0-9]*|[._-]?[A-Za-z0-9]+)*$";
            if (!Regex.IsMatch(textBox_login.Text, pattern3))
            {

                MessageBox.Show("Логин может состоять только из латинских букв и цифр. Без пробелов и спец. знаков.", "Ошибка", MessageBoxButtons.OK);
                return;
            }


            var context = new Context();
            var existUser = context.Users.FirstOrDefault(x=>x.Login==textBox_login.Text.ToLower());
            if (existUser!=null)
            {

                MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButtons.OK);
                return;

            }


            var user = new User
            {
                Name = textBox_name.Text,
                Login = textBox_login.Text.ToLower(),
                Password = textBox_password.Text,
            };
            context.Users.Add(user);
            context.SaveChanges();

            var usercodename = new UserCodeName
            {
                UserId = user.Id,
                CodeName = textBox_codename.Text.ToLower(),
                Clue = textBox_clue.Text,
            };
            context.UserCodeNames.Add(usercodename);
            context.SaveChanges();

            this.Close();

        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
