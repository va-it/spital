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
    public partial class MonitorForm : Form
    {
        List<PictureBox> modulesIcons = new List<PictureBox>();
        List<Label> modulesReadings = new List<Label>();

        public MonitorForm()
        {
            InitializeComponent();
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            // Code to stop the alarm
            MessageBox.Show("Alarm has been stopped", "Alarm stopped");
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            // Code to select the modules
            Form modules = new ModulesForm();
            modules.Show();
        }

        private void limitsButton_Click(object sender, EventArgs e)
        {
            // Code to edit the modules limits
            Form limits = new LimitsForm();
            limits.Show();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            Monitor monitor = new Monitor();

            monitor.Active = true;

            // the save function should return the row ID
            monitor.Save();
        }

        private void GenerateListsOfControls()
        {
            modulesReadings.Add(moduleReading1);
            modulesReadings.Add(moduleReading2);
            modulesReadings.Add(moduleReading3);
            modulesReadings.Add(moduleReading4);

            modulesIcons.Add(moduleIcon1);
            modulesIcons.Add(moduleIcon2);
            modulesIcons.Add(moduleIcon3);
            modulesIcons.Add(moduleIcon4);
        }
    }
}
