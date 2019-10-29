using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //method to save user input to the .txt file for the time being until database is implemented
        private void Button_Register_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string passwordConfirm = textBox_ConfirmPassword.Text;

            //check input from password and confirm password match 
            if (password != passwordConfirm)
            {
                MessageBox.Show("The two passwords need to match! Please try again.", "Password mismatch");
                return;
            }

            User user = new User
            {
                Username = username,
                Password = password
            };

            try
            {
                user.Save();
                MessageBox.Show("Registration successful! Please Log in.", "Success");
                // close this form window
                Close();
                // open login page 
                LoginForm login = new LoginForm();
                login.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
