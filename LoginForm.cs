using spital.Properties;
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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {


            string username = textBox_username.Text;
            string password = textBox_password.Text;

            bool allowLogin = Staff.ValidateCredentials(username, password);

            if (allowLogin)
            {
                // Start session etc.
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Please try again");
                textBox_password.Text = "";
            }

        }
    }
}
