using Project_IS.Models;
using Project_IS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_IS.UI
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(); // ВСЁ!
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            var user = _authService.Login(username, password); // čia mano PRISIJUNGTI migtukas, ir jis kviecia AUTHSERVICE funkcija 

            if (user == null)
            {
                MessageBox.Show("Incorrect username or password");
                return;
            }

            // Разные действия в зависимости от роли
            if (user is Admin admin)
            {
                MessageBox.Show($"Welcome, admin {admin.FirstName}!");
                //тут можно открыть форму админа:
                var form = new AdminForm(admin);
                form.Show();
                this.Hide();
            }
            else if (user is Teacher teacher)
            {
                MessageBox.Show($"Welcome, teacher {teacher.FirstName}!");
                var form = new TeacherForm(teacher);
                form.Show();
                this.Hide();
            }
            else if (user is Student student)
            {
                MessageBox.Show($"Welcome, student {student.FirstName}!");
                var form = new StudentForm(student);
                form.Show();
                this.Hide();
            }
            else
            {
                // На всякий случай, если вдруг Role какая-то другая
                MessageBox.Show($"Welcome, {user.FirstName}!");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
