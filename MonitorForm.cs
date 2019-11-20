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
        List<MonitorModule> monitorModules = new List<MonitorModule>();
        List<PictureBox> modulesIcons = new List<PictureBox>();
        List<Label> moduleName = new List<Label>();

        public Nullable<int> MonitorId { get; set; }

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
            Form modules = new ModulesForm(this);
            modules.Show();
        }

        private void limitsButton_Click(object sender, EventArgs e)
        {
            // Code to edit the modules limits
            Form limits = new LimitsForm(this);
            limits.Show();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            FillMonitor();
            Monitor monitor = new Monitor
            {
                Active = true
            };

            MonitorId = monitor.Save();
        }

        private void FillMonitor()
        {
            GenerateListsOfControls();
            GetLimitForm();
        }

        private void GenerateListsOfControls()
        {
            moduleName.Add(moduleName1);
            moduleName.Add(moduleName2);
            moduleName.Add(moduleName3);
            moduleName.Add(moduleName4);

            modulesIcons.Add(moduleIcon1);
            modulesIcons.Add(moduleIcon2);
            modulesIcons.Add(moduleIcon3);
            modulesIcons.Add(moduleIcon4);
        }

        private void GetLimitForm()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(MonitorId);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                moduleName.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                ++index;
            }
        }

        //private void MonitorForm_Shown(object sender, EventArgs e)
        //{
        //    FillMonitor();
        //}
    }
}
