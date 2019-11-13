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
    public partial class LimitsForm : Form
    {
        List<MonitorModule> monitorModules = new List<MonitorModule>();
        List<Label> modules = new List<Label>();

        public LimitsForm()
        {
            InitializeComponent();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
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
        }


        private void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(1);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                modules.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                ++index;
            }
        }

        private void LimitsForm_Shown(object sender, EventArgs e)
        {
            FillLimits();
        }
    }
}
