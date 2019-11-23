using spital.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    public partial class LimitsForm : Form
    {
        private MonitorForm Monitor { get; set; }

        List<MonitorModule> monitorModules = new List<MonitorModule>();

        List<PictureBox> vitalIcon = new List<PictureBox>();
        public List<Label> modules = new List<Label>();
        List<NumericUpDown> limitMin = new List<NumericUpDown>();
        List<NumericUpDown> limitMax = new List<NumericUpDown>();


        public LimitsForm(MonitorForm monitorForm)
        {
            InitializeComponent();
            Monitor = monitorForm;
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            SaveAssignedLimits();
            this.Close();
        }

        private void FillLimits()
        {
            GenerateControlsLists();

            GetMonitorModules();
        }

        private void GenerateControlsLists()
        {
            modules.Add(labelModule1);
            modules.Add(labelModule2);
            modules.Add(labelModule3);
            modules.Add(labelModule4);
            limitMin.Add(minLimit1);
            limitMin.Add(minLimit2);
            limitMin.Add(minLimit3);
            limitMin.Add(minLimit4);
            limitMax.Add(maxLimit1);
            limitMax.Add(maxLimit2);
            limitMax.Add(maxLimit3);
            limitMax.Add(maxLimit4);
            vitalIcon.Add(ModuleIcon1);
            vitalIcon.Add(ModuleIcon2);
            vitalIcon.Add(ModuleIcon3);
            vitalIcon.Add(ModuleIcon4);

        }


        private void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(Monitor.MonitorId);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                modules.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                vitalIcon.ElementAt(index).ImageLocation = @"../../Resources/" + monitorModules.ElementAt(index).Module.Icon;
                limitMin.ElementAt(index).Value = (int)monitorModules.ElementAt(index).AssignedMin;
                limitMax.ElementAt(index).Value = (int)monitorModules.ElementAt(index).AssignedMax;
                ++index;
            }
        }

        private void SaveAssignedLimits()
        {
            for (int i = 0; i < monitorModules.Count; ++i)
            {
                monitorModules.ElementAt(i).AssignedMin = (float)limitMin.ElementAt(i).Value;
                monitorModules.ElementAt(i).AssignedMax = (float)limitMax.ElementAt(i).Value;

                monitorModules.ElementAt(i).Update();
            }
        }

        private void LimitsForm_Shown(object sender, EventArgs e)
        {
            FillLimits();
        }
    }
}
