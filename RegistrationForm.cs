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
            string contactDetails = textBox_ContactDetails.Text;

            //check input from password and confirm password match 
            if (password != passwordConfirm)
            {
                MessageBox.Show("The two passwords need to match! Please try again.", "Password mismatch");
                return;
            }

            StaffType selectedStaff = staffType.SelectedItem as StaffType;

            try
            {
                switch (selectedStaff.Id)
                {
                    case 1:
                        Nurse nurse = new Nurse(1, username, password, contactDetails);
                        nurse.Save();
                        break;
                    case 2:
                        Consultant consultant = new Consultant(2, username, password, contactDetails);
                        consultant.Save();
                        break;
                }

                MessageBox.Show("Registration successful! Please Log in.", "Success");


                // close this form window
                this.Close();

                
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

        /// <summary>
        /// Populates select control with staff types stored in database
        /// </summary>
        public void FillStaffType()
        {

            List<StaffType> staffTypes = new List<StaffType>();
            staffTypes = StaffType.GetAll();

            staffType.ValueMember = "staffTypeID";
            staffType.DisplayMember = "name";
            staffType.DataSource = staffTypes;

        }

        private void staffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaffType selectedStaff = staffType.SelectedItem as StaffType;;

            switch (selectedStaff.Id)
            {
                case 1:
                    label_ContactDetails.Text = "Mobile number";
                    pictureBox_ContactDetails.Image = Resources.icon_Mobile;
                    break;
                case 2:
                    label_ContactDetails.Text = "Email";
                    pictureBox_ContactDetails.Image = Resources.icon_Email;
                    break;
            }
        }
    }
}
