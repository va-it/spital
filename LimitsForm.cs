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

        private void LimitsForm_Load(object sender, EventArgs e)
        {
            FillLimits();
        }

        private void FillLimits()
        {
            GenerateControlsLists();

            GetAllFromMonitor();


        }

        private void GenerateControlsLists()
        {
            modules.Add(labelModule1);
            modules.Add(labelModule1);
            modules.Add(labelModule1);
            modules.Add(labelModule1);
        }


        private void GetAllFromMonitor()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(1);

            for (int i = 0; i < monitorModules.Count; ++i)
            {
                modules.ElementAt(i).Text = monitorModules.ElementAt(i).Module.Name;
            }           
        }
    }
}
