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

        List<PictureBox> moduleIcon = new List<PictureBox>();
        public List<Label> modules = new List<Label>();
        List<NumericUpDown> limitMin = new List<NumericUpDown>();
        List<NumericUpDown> limitMax = new List<NumericUpDown>();


        public LimitsForm(MonitorForm monitorForm)
        {
            InitializeComponent();
            Monitor = monitorForm;
        }

        /// <summary>
        /// Populates Lists with controls in Form and retrieves monitorModule
        /// to insert values in NumericUpDown controls
        /// </summary>
        private void FillLimits()
        {
            GenerateControlsLists();
            GetMonitorModules();
        }

        /// <summary>
        /// Populates Lists with controls from Form
        /// </summary>
        private void GenerateControlsLists()
        {
            modules.Add(labelModule1);
            modules.Add(labelModule2);
            modules.Add(labelModule3);
            modules.Add(labelModule4);

            moduleIcon.Add(ModuleIcon1);
            moduleIcon.Add(ModuleIcon2);
            moduleIcon.Add(ModuleIcon3);
            moduleIcon.Add(ModuleIcon4);

            limitMin.Add(minLimit1);
            limitMin.Add(minLimit2);
            limitMin.Add(minLimit3);
            limitMin.Add(minLimit4);

            limitMax.Add(maxLimit1);
            limitMax.Add(maxLimit2);
            limitMax.Add(maxLimit3);
            limitMax.Add(maxLimit4);
        }

        /// <summary>
        /// Retrieves monitorModules for specific monitor 
        /// and populates NumericUpDown controls with assigned limits
        /// </summary>
        private void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(Monitor.MonitorId);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                modules.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                moduleIcon.ElementAt(index).ImageLocation = @"../../Resources/" + monitorModules.ElementAt(index).Module.Icon;
                limitMin.ElementAt(index).Value = Convert.ToDecimal(monitorModules.ElementAt(index).AssignedMin);
                limitMax.ElementAt(index).Value = Convert.ToDecimal(monitorModules.ElementAt(index).AssignedMax);
                ++index;
            }
        }

        /// <summary>
        /// Updates monitorModules with specified limits
        /// </summary>
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveAssignedLimits();
            Monitor.Active = true;
            this.Close();

            Monitor.RefreshModules();
        }
    }
}
