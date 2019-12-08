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

        MonitorForm monitorForm1;
        MonitorForm monitorForm2;
        MonitorForm monitorForm3;
        MonitorForm monitorForm4;
        MonitorForm monitorForm5;
        MonitorForm monitorForm6;
        MonitorForm monitorForm7;
        MonitorForm monitorForm8;

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
            GenerateControlList();
        }

        /// <summary>
        /// Adds bed userControls to List of beds
        /// </summary>
        public void GenerateControlList()
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

        /// <summary>
        /// Displays details of alarm from parameter on the appropriate bed usercontrol
        /// </summary>
        /// <param name="alarm"></param>
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
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        /// <summary>
        /// Hides alarm icon and message from bed userControl
        /// </summary>
        /// <param name="monitor"></param>
        public void HideAlarms(MonitorForm monitor)
        {
            // remove picture and text from monitorUserControl based on monitor.Id
            foreach (UserControl_bed userControl_Bed in beds)
            {
                if (monitor.MonitorId == int.Parse(userControl_Bed.hiddenLabel_MonitorID.Text))
                {
                    userControl_Bed.MuteAlarm();
                }
            }
        }

        private void userControl_bed1_Click(object sender, EventArgs e)
        {
            if (monitorForm1 == null)
            {
                //Initialise monitor
                monitorForm1 = new MonitorForm();
                monitorForm1.MonitorId = int.Parse(userControl_bed1.MonitorID);
                monitorForms.Add(monitorForm1);
            }

            DisplayMonitorForm(1);

            if (monitorForm1.Active && !monitorForm1.HasAlarms)
            {
                userControl_bed1.MarkBedAsActive();
            }
        }

        private void userControl_bed2_Click(object sender, EventArgs e)
        {
            if (monitorForm2 == null)
            {
                //Initialise monitor
                monitorForm2 = new MonitorForm();
                monitorForm2.MonitorId = int.Parse(userControl_bed2.MonitorID);
                monitorForms.Add(monitorForm2);
            }
            
            DisplayMonitorForm(2);

            if (monitorForm2.Active && !monitorForm2.HasAlarms)
            {
                userControl_bed2.MarkBedAsActive();
            }
        }

        private void userControl_bed3_Click(object sender, EventArgs e)
        {
            if (monitorForm3 == null)
            {
                //Initialise monitor
                monitorForm3 = new MonitorForm();
                monitorForm3.MonitorId = int.Parse(userControl_bed3.MonitorID);
                monitorForms.Add(monitorForm3);
            }
            
            DisplayMonitorForm(3);

            if (monitorForm3.Active && !monitorForm3.HasAlarms)
            {
                userControl_bed3.MarkBedAsActive();
            }
        }

        private void userControl_bed4_Click(object sender, EventArgs e)
        {
            if (monitorForm4 == null)
            {
                //Initialise monitor
                monitorForm4 = new MonitorForm();
                monitorForm4.MonitorId = int.Parse(userControl_bed4.MonitorID);
                monitorForms.Add(monitorForm4);
            }

            DisplayMonitorForm(4);

            if (monitorForm4.Active && !monitorForm4.HasAlarms)
            {
                userControl_bed4.MarkBedAsActive();
            }
        }

        private void userControl_bed5_Click(object sender, EventArgs e)
        {
            if (monitorForm5 == null)
            {
                //Initialise monitor
                monitorForm5 = new MonitorForm();
                monitorForm5.MonitorId = int.Parse(userControl_bed5.MonitorID);
                monitorForms.Add(monitorForm5);
            }

            DisplayMonitorForm(5);

            if (monitorForm5.Active && !monitorForm5.HasAlarms)
            {
                userControl_bed5.MarkBedAsActive();
            }
        }

        private void userControl_bed6_Click(object sender, EventArgs e)
        {
            if (monitorForm6 == null)
            {
                //Initialise monitor
                monitorForm6 = new MonitorForm();
                monitorForm6.MonitorId = int.Parse(userControl_bed6.MonitorID);
                monitorForms.Add(monitorForm6);
            }

            DisplayMonitorForm(6);

            if (monitorForm6.Active && !monitorForm6.HasAlarms)
            {
                userControl_bed6.MarkBedAsActive();
            }

        }

        private void userControl_bed7_Click(object sender, EventArgs e)
        {
            if (monitorForm7 == null)
            {
                //Initialise monitor
                monitorForm7 = new MonitorForm();
                monitorForm7.MonitorId = int.Parse(userControl_bed7.MonitorID);
                monitorForms.Add(monitorForm7);
            }

            DisplayMonitorForm(7);

            if (monitorForm7.Active && !monitorForm7.HasAlarms)
            {
                userControl_bed7.MarkBedAsActive();
            }
        }

        private void userControl_bed8_Click(object sender, EventArgs e)
        {
            if (monitorForm8 == null)
            {
                //Initialise monitor
                monitorForm8 = new MonitorForm();
                monitorForm8.MonitorId = int.Parse(userControl_bed8.MonitorID);
                monitorForms.Add(monitorForm8);
            }
            
            DisplayMonitorForm(8);

            if (monitorForm8.Active && !monitorForm8.HasAlarms)
            {
                userControl_bed8.MarkBedAsActive();
            }
        }

        /// <summary>
        /// Display monitor form based on monitor ID
        /// </summary>
        /// <param name="monitorId"></param>
        private void DisplayMonitorForm(int monitorId)
        {
            foreach (MonitorForm monitorForm in monitorForms)
            {
                if (monitorForm.MonitorId == monitorId)
                {
                    //Display initialised monitor
                    monitorForm.ShowDialog();
                }
            }
        }



        private void bt_ManagementReport_Click(object sender, EventArgs e)
        {
            ManagementForm managementForm = new ManagementForm();
            managementForm.ShowDialog();
        }

        private void button_startshift_Click(object sender, EventArgs e)
        {
            string action = "start";
            LoginForm loginForm = new LoginForm(action);
            loginForm.ShowDialog();
        }
    }
}
