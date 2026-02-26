using LibraryManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly UserService userService = new UserService();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            // Required fields check
            if (string.IsNullOrWhiteSpace(textBoxFullname.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxMobile.Text) ||
                string.IsNullOrWhiteSpace(comboBoxDepertment.Text) ||
                comboBoxDepertment.Text == "Select Depertment")
            {
                MessageBox.Show("All fields must be filled.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trigger validation once
            textBoxPassword_TextChanged(textBoxPassword, EventArgs.Empty);
            textBoxEmail_TextChanged(textBoxEmail, EventArgs.Empty);

            // Stop if password/email invalid
            if (!string.IsNullOrEmpty(errorProviderPassword.GetError(textBoxPassword)) &&
                !string.IsNullOrEmpty(errorProviderEmail.GetError(textBoxEmail)))
            {
                MessageBox.Show("Fix password and email errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (!string.IsNullOrEmpty(errorProviderEmail.GetError(textBoxEmail)))
            {
                MessageBox.Show("Fix email errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (!string.IsNullOrEmpty(errorProviderPassword.GetError(textBoxPassword)))
            {
                MessageBox.Show("Fix password errors first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                userService.RegisterStudent(
                    textBoxUserName.Text,
                    textBoxPassword.Text,
                    textBoxFullname.Text,
                    textBoxEmail.Text,
                    textBoxMobile.Text,
                    dateTimePicker1.Value,
                    comboBoxDepertment.Text
                );

                MessageBox.Show("Registration Successful!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxFullname.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxUserName.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxMobile.Focus();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBoxMobile.Focus();
            }
        }

        private void textBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void textBoxMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dateTimePicker1.Focus();
            }
        }

        private void textBoxMobile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBoxEmail.Focus();
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBoxDepertment.Focus();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 6)
            {
                errorProviderPassword.SetError(textBoxPassword, "Password must be more than 6 characters.");
            }
            else
            {
                errorProviderPassword.SetError(textBoxPassword, ""); // Clear the error
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple Email Regex
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                errorProviderEmail.SetError(textBoxEmail, "Invalid email format.");
            }
            else
            {
                errorProviderEmail.SetError(textBoxEmail, "");
            }
        }


    }
}
