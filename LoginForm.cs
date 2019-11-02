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

            DataSet dataSet = DatabaseConnection.Instance.GetDataSet("SELECT * FROM staff");
            DataTable staff = dataSet.Tables[0];

            foreach (DataRow row in staff.Rows)
            {
                string staffTypeId = row["staffTypeId"].ToString();

                switch (staffTypeId)
                {
                    case "1":
                        Nurse nurse = new Nurse(Int32.Parse(staffTypeId), username, password);
                        // are credentials OK?
                        if (nurse.ValidateCredentials(username,password))
                        {
                            //code to open the next form goes here
                            MessageBox.Show("Credentials are valid!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!", "Wrong Credentials");
                        }
                        break;
                    case "2":
                        Consultant consultant = new Consultant(Int32.Parse(staffTypeId), username, password);
                        // are credentials OK?
                        if (consultant.ValidateCredentials(username,password))
                        {
                            //code to open the next form goes here
                            MessageBox.Show("Credentials are valid!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!", "Wrong Credentials");
                        }
                        break;
                }
            }

            

            
        }
    }
}
