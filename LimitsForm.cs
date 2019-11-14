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
        private MonitorForm Monitor { get; set; }

        List<MonitorModule> monitorModules = new List<MonitorModule>();
        List<Label> modules = new List<Label>();

        List<NumericUpDown> limitMin = new List<NumericUpDown>();
        List<NumericUpDown> limitMax = new List<NumericUpDown>();

        public LimitsForm(MonitorForm monitorForm)
        {
            InitializeComponent();
            Monitor = monitorForm;
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillLimits()
        {
            GenerateControlsLists();
            GetMonitorModules();
            //GetDefaultLimit();
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

        }


        private void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(1);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                modules.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                limitMin.ElementAt(index).Value = Convert.ToDecimal(monitorModules.ElementAt(index).Module.DefaultMin);
                limitMax.ElementAt(index).Value = Convert.ToDecimal(monitorModules.ElementAt(index).Module.DefaultMax);
                ++index;
            }
        }

        //private void GetDefaultLimit()
        //{
        //    monitorModules = MonitorModule.GetAllFromMonitor(1);

        //    int index = 0;

        //    foreach (MonitorModule monitorModule in monitorModules)
        //    {
        //        limit.ElementAt(index).Value = Convert.ToDecimal(monitorModules.ElementAt(index).Module.DefaultMin);
        //        ++index;
        //    } 
        //}


        private void LimitsForm_Shown(object sender, EventArgs e)
        {
            FillLimits();
        }
    }
}
