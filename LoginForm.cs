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
        string Action { get; set; }

        public LoginForm(string action)
        {
            InitializeComponent();

            Action = action;
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            bool allowLogin = Staff.ValidateCredentials(username, password);

            if (allowLogin)
            {
                // Start session etc. 
                switch (Action)
                {
                    case "start":
                        //start session
                        DataTable staffDataTable = Staff.GetWithUsername(username);
                        if (staffDataTable.Rows.Count == 1)
                        {
                            DataRow row = staffDataTable.Rows[0];

                            int staffID = Int32.Parse(row["staffID"].ToString());
                            Session session = new Session(staffID);
                            session.Save();
                        }
                        break;

                    case "stop":
                        //stop session
                        break;

                }
                this.Close();

                // Ensure Central Display is shown
                CentralDisplay.Instance.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Please try again");
                textBox_password.Text = "";
            }

        }
    }
}
