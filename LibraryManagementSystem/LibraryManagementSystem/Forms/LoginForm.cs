using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService = new AuthService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool success = authService.Login(
            textBoxUserName.Text,
            textBoxPassword.Text
            );

            if (!success)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            MainDashboardForm dashboard = new MainDashboardForm();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            textBoxUserName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if enter is pressed, move focus to password field
            if ((e.KeyChar == (char)Keys.Enter) && (textBoxPassword.Text == ""))
            {
                textBoxPassword.Focus();
            }
            else if ((e.KeyChar == (char)Keys.Enter) && (textBoxPassword.Text != ""))
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            //up key pressed go to username
            if (e.KeyCode == Keys.Up)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPassword.Focus();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrationPage_Click(object sender, EventArgs e)
        {
            RegistrationForm regPage = new RegistrationForm();
            regPage.FormClosed += RegPage_FormClosed;
            regPage.Show();
            this.Hide();
        }

        private void RegPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, show the text. If unchecked, hide it.
            if (checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

