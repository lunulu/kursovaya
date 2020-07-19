using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //Кнопка закрытия программы
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка проверки логина и пароля и переход к основному окну
        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = "admin";
            string password = "123456";
            loginBox.ForeColor = Color.FromArgb(220, 220, 220);
            loginImage.BackColor = Color.FromArgb(220, 220, 220);
            passwordBox.ForeColor = Color.FromArgb(220, 220, 220);
            passwordImage.BackColor = Color.FromArgb(220, 220, 220);

            if (loginBox.Text == "") loginBox.Text = "Введите логин";
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Введите пароль";
                passwordBox.PasswordChar = '\u0000';
            }
            if (loginBox.Text == login && passwordBox.Text == password)
            {
                this.Hide();
                MainPage mp = new MainPage();
                mp.Show();
            }
            if (loginBox.Text != login && loginBox.Text.Length > 0 && loginBox.Text != "Введите логин")
            {
                loginBox.Text = "Неверный логин";
                passwordBox.Text = "";
            }
            if (passwordBox.Text != password && passwordBox.Text.Length > 0 && passwordBox.Text != "Введите пароль" && loginBox.Text == login)
            {
                passwordBox.Text = "Неверный пароль";
                passwordBox.PasswordChar = '\u0000';
            }

        }

        //Работа с полями логин и пароль
        private void loginBox_Click(object sender, EventArgs e)
        {
            loginBox.Text = "";
            loginBox.ForeColor = Color.FromArgb(237, 176, 33);
            loginImage.BackColor = Color.FromArgb(237, 176, 33);
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.Text = "";
            passwordBox.ForeColor = Color.FromArgb(237, 176, 33);
            passwordImage.BackColor = Color.FromArgb(237, 176, 33);
            passwordBox.PasswordChar = '*';
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.FromArgb(220, 220, 220);
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.FromArgb(237, 176, 33);
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(237, 176, 33);
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void loginBox_MouseEnter(object sender, EventArgs e)
        {
            loginBox.ForeColor = Color.FromArgb(237, 176, 33);

        }

        private void passwordBox_MouseEnter(object sender, EventArgs e)
        {
            passwordBox.ForeColor = Color.FromArgb(237, 176, 33);
        }

        private void loginBox_MouseLeave(object sender, EventArgs e)
        {
            if (loginBox.Text == "Введите логин") loginBox.ForeColor = Color.FromArgb(220, 220, 220);
        }

        private void passwordBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Введите пароль") passwordBox.ForeColor = Color.FromArgb(220, 220, 220);
        }

    }
}