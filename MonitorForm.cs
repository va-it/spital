using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace spital
{
    public partial class MonitorForm : Form
    {
        List<MonitorModule> monitorModules = new List<MonitorModule>();

        List<Label> moduleName = new List<Label>();
        List<PictureBox> modulesIcon = new List<PictureBox>();
        List<Label> moduleReading = new List<Label>();
        List<Label> limitMin = new List<Label>();
        List<Label> limitMax = new List<Label>();

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
            
            Monitor monitor = new Monitor
            {
                Active = true
            };

            MonitorId = monitor.Save();
            
        }

        private void FillMonitor()
        {
            GenerateListsOfControls();
            GetMonitorModules();
        }

        private void GenerateListsOfControls()
        {
            moduleName.Add(moduleName1);
            moduleName.Add(moduleName2);
            moduleName.Add(moduleName3);
            moduleName.Add(moduleName4);

            modulesIcon.Add(moduleIcon1);
            modulesIcon.Add(moduleIcon2);
            modulesIcon.Add(moduleIcon3);
            modulesIcon.Add(moduleIcon4);

            limitMin.Add(label_Module1Min);
            limitMin.Add(label_Module2Min);
            limitMin.Add(label_Module3Min);
            limitMin.Add(label_Module4Min);

            limitMax.Add(label_Module1Max);
            limitMax.Add(label_Module2Max);
            limitMax.Add(label_Module3Max);
            limitMax.Add(label_Module4Max);

            moduleReading.Add(label1reading);
            moduleReading.Add(label2reading);
            moduleReading.Add(label3reading);
            moduleReading.Add(label4reading);
        }


        public void GetReadings()
        {
            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                float random = RandomGenerator.Instance.Generate(monitorModule.AssignedMin - 1, monitorModule.AssignedMax + 1);
                moduleReading.ElementAt(index).Text = Convert.ToString(random);

                ++index;
            }
        }

        public void CheckReadings()
        {
            GetReadings();

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                monitorModule.CheckReading(float.Parse(moduleReading.ElementAt(index).Text));

                ++index;
            }
        }

        public void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(MonitorId);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                moduleName.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                modulesIcon.ElementAt(index).ImageLocation = @"../../Resources/" + monitorModules.ElementAt(index).Module.Icon;
                limitMin.ElementAt(index).Text = Convert.ToString(monitorModules.ElementAt(index).AssignedMin);
                limitMax.ElementAt(index).Text = Convert.ToString(monitorModules.ElementAt(index).AssignedMax);

                ++index;
            }
                
        }

        private void MonitorForm_Shown(object sender, EventArgs e)
        {
            RefreshModules();
        }

        public void RefreshModules()
        {
            FillMonitor();
            CheckReadings();
        }
    }
}

   