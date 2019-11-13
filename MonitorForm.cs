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
            GenerateListsOfControls();
            DataTable monitorModuleDataTable = MonitorModule.GetAll();

            int index = 0;

            foreach (DataRow row in monitorModuleDataTable.Rows)
            {
                modulesReadings.ElementAt(index).Text = row["name"].ToString();
                modulesIcons.ElementAt(index).Text = row["icon"].ToString();

                index++;
            }

            MonitorModule monitorModule = new MonitorModule();
            monitorModule = MonitorModule.GetOne(6);

            modulesReadings.ElementAt(5).Text = monitorModule.Module.Name;
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
