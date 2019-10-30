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
    public partial class LoginForm : Form
    {
        User user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            textBox_password.Text = "";

            user = new User
            {
                Username = username,
                Password = password
            };

            // are credentials OK?
            if (user.ValidateCredential)
            {
                //code to open the next form goes here
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Wrong Credentials");
            }
        }
    }
}
