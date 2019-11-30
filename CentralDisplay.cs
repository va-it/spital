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
    public partial class CentralDisplay : Form
    {
        List<UserControl> beds = new List<UserControl>();

        List<MonitorForm> monitorForms = new List<MonitorForm>();

        private static CentralDisplay _instance;

        public static CentralDisplay Instance
        {
            get
            {
                //check if the object was created 
                if (_instance == null)
                {
                    //create the object
                    _instance = new CentralDisplay();
                }

                return _instance;
            }
        }

        public CentralDisplay()
        {
            InitializeComponent();
            GenerateConstrolList();
            BedNumberLabel();
        }

        public void GenerateConstrolList()
        {
            beds.Add(userControl_bed1);
            beds.Add(userControl_bed2);
            beds.Add(userControl_bed3);
            beds.Add(userControl_bed4);
            beds.Add(userControl_bed5);
            beds.Add(userControl_bed6);
            beds.Add(userControl_bed7);
            beds.Add(userControl_bed8);
        }

        public void BedNumberLabel()
        {
            userControl_bed1.BedNumber = "Bed 1";
            userControl_bed2.BedNumber = "Bed 2";
            userControl_bed3.BedNumber = "Bed 3";
            userControl_bed4.BedNumber = "Bed 4";
            userControl_bed5.BedNumber = "Bed 5";
            userControl_bed6.BedNumber = "Bed 6";
            userControl_bed7.BedNumber = "Bed 7";
            userControl_bed8.BedNumber = "Bed 8";
        }

        public void DisplayAlarm(Alarm alarm)
        {
            int monitorId = alarm.MonitorModule.Monitor.Id;

            foreach (UserControl_bed userControl_Bed in beds)
            {
                if (monitorId == alarm.MonitorModule.Monitor.Id && int.Parse(userControl_Bed.hiddenLabel_MonitorID.Text) == monitorId )
                {
                    userControl_Bed.AlertPictureBox = Resources.icon_Alert;
                    userControl_Bed.pictureBox_bed.BackColor = Color.Yellow;
                    userControl_Bed.Alert = alarm.MonitorModule.Module.Name;
                }
                
            }

            //ideally, if we use a Usercontrol we can loop over all of them until
            // we get to the one for Monitor with monitorId

            //switch (monitorId)
            //{
            //    case 1:
            //        alertsignpicturebox_bed1.Image = Resources.icon_Alert;
            //        pictureBox_bed1.BackColor = Color.Yellow;
            //        label_bed1msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 2:
            //        alertsignpicturebox_bed2.Image = Resources.icon_Alert;
            //        pictureBox_bed2.BackColor = Color.Yellow;
            //        label_bed2msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 3:
            //        alertsignpicturebox_bed3.Image = Resources.icon_Alert;
            //        pictureBox_bed3.BackColor = Color.Yellow;
            //        label_bed3msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 4:
            //        alertsignpicturebox_bed4.Image = Resources.icon_Alert;
            //        pictureBox_bed4.BackColor = Color.Yellow;
            //        label_bed4msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 5:
            //        alertsignpicturebox_bed5.Image = Resources.icon_Alert;
            //        pictureBox_bed5.BackColor = Color.Yellow;
            //        label_bed5msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 6:
            //        alertsignpicturebox_bed6.Image = Resources.icon_Alert;
            //        pictureBox_bed6.BackColor = Color.Yellow;
            //        label_bed6msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 7:
            //        alertsignpicturebox_bed7.Image = Resources.icon_Alert;
            //        pictureBox_bed7.BackColor = Color.Yellow;
            //        label_bed7msg.Text = alarm.MonitorModule.Module.Name;
            //        break;
            //    case 8:
            //        alertsignpicturebox_bed8.Image = Resources.icon_Alert;
            //        pictureBox_bed8.BackColor = Color.Yellow;
            //        label_bed8msg.Text = alarm.MonitorModule.Module.Name;
            //        break;

            //}
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        public void HideAlarms(MonitorForm monitor)
        {
            // remove picture and text from monitorUserControl based on monitor.Id
        }
        

        private void userControl_bed1_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm1 = new MonitorForm();
            monitorForm1.MonitorId = 1;
            userControl_bed1.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm1.MonitorId);
            monitorForms.Add(monitorForm1);

            //Display initialised monitor
            monitorForms.ElementAt(0).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(0).Active)
            {
                userControl_bed1.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }

        private void userControl_bed2_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm2 = new MonitorForm();
            monitorForm2.MonitorId = 2;
            userControl_bed2.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm2.MonitorId);
            monitorForms.Add(monitorForm2);

            //Display initialised monitor
            monitorForms.ElementAt(1).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(1).Active)
            {
                userControl_bed2.pictureBox_bed.BackColor = Color.Chartreuse;
            }

        }

        private void userControl_bed3_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm3 = new MonitorForm();
            monitorForm3.MonitorId = 3;
            userControl_bed3.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm3.MonitorId);
            monitorForms.Add(monitorForm3);

            //Display initialised monitor
            monitorForms.ElementAt(2).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(2).Active)
            {
                userControl_bed3.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }

        private void userControl_bed4_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm4 = new MonitorForm();
            monitorForm4.MonitorId = 4;
            userControl_bed4.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm4.MonitorId);
            monitorForms.Add(monitorForm4);

            //Display initialised monitor
            monitorForms.ElementAt(3).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(3).Active)
            {
                userControl_bed4.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }

        private void userControl_bed5_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm5 = new MonitorForm();
            monitorForm5.MonitorId = 5;
            userControl_bed5.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm5.MonitorId);
            monitorForms.Add(monitorForm5);

            //Display initialised monitor
            monitorForms.ElementAt(4).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(4).Active)
            {
                userControl_bed5.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }

        private void userControl_bed6_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm6 = new MonitorForm();
            monitorForm6.MonitorId = 6;
            userControl_bed6.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm6.MonitorId);
            monitorForms.Add(monitorForm6);

            //Display initialised monitor
            monitorForms.ElementAt(5).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(5).Active)
            {
                userControl_bed6.pictureBox_bed.BackColor = Color.Chartreuse;
            }

        }

        private void userControl_bed7_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm7 = new MonitorForm();
            monitorForm7.MonitorId = 7;
            userControl_bed7.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm7.MonitorId);
            monitorForms.Add(monitorForm7);

            //Display initialised monitor
            monitorForms.ElementAt(6).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(6).Active)
            {
                userControl_bed7.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }

        private void userControl_bed8_Click(object sender, EventArgs e)
        {
            //Initialise monitor
            MonitorForm monitorForm8 = new MonitorForm();
            monitorForm8.MonitorId = 8;
            userControl_bed8.hiddenLabel_MonitorID.Text = Convert.ToString(monitorForm8.MonitorId);
            monitorForms.Add(monitorForm8);

            //Display initialised monitor
            monitorForms.ElementAt(7).ShowDialog();

            //Set Background colour for the pictureBox_bed to green once the monitorForm/Bed is active
            if (monitorForms.ElementAt(7).Active)
            {
                userControl_bed8.pictureBox_bed.BackColor = Color.Chartreuse;
            }
        }
    }
}
