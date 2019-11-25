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
        public CentralDisplay()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void bed1_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 1;
            monitorForm.Show();
            if (monitorForm.Active)
            {
                pictureBox_bed1.BackColor = Color.Chartreuse;
            }

            monitorForm.CheckReadings();
        }

        private void bed2_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 2;
            monitorForm.Show();
            if (monitorForm.Active)
            {
                pictureBox_bed2.BackColor = Color.Chartreuse;
            }
        }

        private void bed3_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 3;
            monitorForm.Show();
            if (monitorForm.Active)
            {
                pictureBox_bed3.BackColor = Color.Chartreuse;
            }
        }

        private void bed4_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 4;
            monitorForm.Show();
            if (monitorForm.Active)
            {
                pictureBox_bed4.BackColor = Color.Chartreuse;
            }
        }

        private void bed5_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 5;
            monitorForm.Show();
            if (monitorForm.Active)
            {
                pictureBox_bed5.BackColor = Color.Chartreuse;
            }

        }

        private void bed6_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 6;
            monitorForm.Show();

            if (monitorForm.Active)
            {
                pictureBox_bed6.BackColor = Color.Chartreuse;
            }
        }

        private void bed7_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 7;
            monitorForm.Show();

            if (monitorForm.Active)
            {
                pictureBox_bed7.BackColor = Color.Chartreuse;
            }
        }

        private void bed8_panel_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.MonitorId = 8;
            monitorForm.Show();

            if (monitorForm.Active)
            {
                pictureBox_bed8.BackColor = Color.Chartreuse;
            }

        }

        public static void ShowNotification(MonitorForm monitor)
        {

        }
    }
}
