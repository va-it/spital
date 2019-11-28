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
            BedLabel();
            InitializeMonitorForms();

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

        public void BedLabel()
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

        private void InitializeMonitorForms()
        {
            MonitorForm monitorForm1 = new MonitorForm();
            monitorForm1.MonitorId = 1;
            monitorForms.Add(monitorForm1);

            MonitorForm monitorForm2 = new MonitorForm();
            monitorForm2.MonitorId = 2;
            monitorForms.Add(monitorForm2);

            MonitorForm monitorForm3 = new MonitorForm();
            monitorForm3.MonitorId = 3;
            monitorForms.Add(monitorForm3);

            MonitorForm monitorForm4 = new MonitorForm();
            monitorForm4.MonitorId = 4;
            monitorForms.Add(monitorForm4);

            MonitorForm monitorForm5 = new MonitorForm();
            monitorForm5.MonitorId = 5;
            monitorForms.Add(monitorForm5);

            MonitorForm monitorForm6 = new MonitorForm();
            monitorForm6.MonitorId = 6;
            monitorForms.Add(monitorForm6);

            MonitorForm monitorForm7 = new MonitorForm();
            monitorForm7.MonitorId = 7;
            monitorForms.Add(monitorForm7);

            MonitorForm monitorForm8 = new MonitorForm();
            monitorForm8.MonitorId = 8;
            monitorForms.Add(monitorForm8);
        }

        public void DisplayAlarm(Alarm alarm)
        {
            int monitorId = alarm.MonitorModule.Monitor.Id;

            //ideally, if we use a Usercontrol we can loop over all of them until
            // we get to the one for Monitor with monitorId

            switch (monitorId)
            {
                case 1:
                    alertsignpicturebox_bed1.Image = Resources.icon_Alert;
                    pictureBox_bed1.BackColor = Color.Yellow;
                    label_bed1msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 2:
                    alertsignpicturebox_bed2.Image = Resources.icon_Alert;
                    pictureBox_bed2.BackColor = Color.Yellow;
                    label_bed2msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 3:
                    alertsignpicturebox_bed3.Image = Resources.icon_Alert;
                    pictureBox_bed3.BackColor = Color.Yellow;
                    label_bed3msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 4:
                    alertsignpicturebox_bed4.Image = Resources.icon_Alert;
                    pictureBox_bed4.BackColor = Color.Yellow;
                    label_bed4msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 5:
                    alertsignpicturebox_bed5.Image = Resources.icon_Alert;
                    pictureBox_bed5.BackColor = Color.Yellow;
                    label_bed5msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 6:
                    alertsignpicturebox_bed6.Image = Resources.icon_Alert;
                    pictureBox_bed6.BackColor = Color.Yellow;
                    label_bed6msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 7:
                    alertsignpicturebox_bed7.Image = Resources.icon_Alert;
                    pictureBox_bed7.BackColor = Color.Yellow;
                    label_bed7msg.Text = alarm.MonitorModule.Module.Name;
                    break;
                case 8:
                    alertsignpicturebox_bed8.Image = Resources.icon_Alert;
                    pictureBox_bed8.BackColor = Color.Yellow;
                    label_bed8msg.Text = alarm.MonitorModule.Module.Name;
                    break;

            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void bed1_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(0).Show();
            if (monitorForms.ElementAt(0).Active)
            {
                pictureBox_bed1.BackColor = Color.Chartreuse;
            }
        }

        private void bed2_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(1).ShowDialog();
            if (monitorForms.ElementAt(1).Active)
            {
                // we need to check if there active alarms.
                // if yes, then don't set the colour here
                pictureBox_bed2.BackColor = Color.Chartreuse;
            }
        }

        private void bed3_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(2).ShowDialog();
            if (monitorForms.ElementAt(2).Active)
            {
                pictureBox_bed3.BackColor = Color.Chartreuse;
            }
        }

        private void bed4_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(3).ShowDialog();
            if (monitorForms.ElementAt(3).Active)
            {
                pictureBox_bed4.BackColor = Color.Chartreuse;
            }
        }

        private void bed5_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(4).ShowDialog();
            if (monitorForms.ElementAt(4).Active)
            {
                pictureBox_bed5.BackColor = Color.Chartreuse;
            }
        }

        private void bed6_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(5).ShowDialog();
            if (monitorForms.ElementAt(5).Active)
            {
                pictureBox_bed6.BackColor = Color.Chartreuse;
            }
        }

        private void bed7_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(6).ShowDialog();
            if (monitorForms.ElementAt(6).Active)
            {
                pictureBox_bed7.BackColor = Color.Chartreuse;
            }
        }

        private void bed8_panel_Click(object sender, EventArgs e)
        {
            monitorForms.ElementAt(7).ShowDialog();
            if (monitorForms.ElementAt(7).Active)
            {
                pictureBox_bed8.BackColor = Color.Chartreuse;
            }
        }

        public void HideAlarms(MonitorForm monitor)
        {
            // remove picture and text from monitorUserControl based on monitor.Id
        }
    }
}
