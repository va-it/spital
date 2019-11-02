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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

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

            string selectedStaff = staffType.SelectedValue.ToString();

            switch (selectedStaff)
            {
                case "1":
                    Nurse nurse = new Nurse(1,username,password);
                    nurse.Save();
                    break;
                case "2":
                    Consultant consultant = new Consultant(2,username,password);
                    consultant.Save();
                    break;
            }

            try
            {
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

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            FillStaffType();
        }

        public void FillStaffType()
        {
            DataSet dataSet = DatabaseConnection.Instance.GetDataSet("SELECT staffTypeID, typeName FROM staffType");

            staffType.ValueMember = "staffTypeID";
            staffType.DisplayMember = "typeName";
            staffType.DataSource = dataSet.Tables[0];
            
        }
                    
        
    }
}
