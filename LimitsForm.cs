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
            SaveMinAssignedLimitsVincenzo();
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

        /*
         * Method to save assigned limit to the monitorModule table in database
         * Below code not working, unable to assign the value to the variable assignMin
         */

        private void SaveMinAssignedLimits()
        {

            foreach(Control control in minBox.Controls)
            {
                NumericUpDown numericUpDown = control as NumericUpDown;

                MonitorModule monitorModule = new MonitorModule();
                var assignedMin = monitorModule.AssignedMin;

                Module module = new Module(assignedMin);

                MonitorModule moduleMinAssignedLimit = new MonitorModule(module);
                moduleMinAssignedLimit.Save();
            }
        }

        private void SaveMinAssignedLimitsVincenzo()
        {
            // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // You could do like the commented code below or look at the uncommented FOR loop.
            // I think that's better since we assign Min and Max in one go.
            // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            //int i = 0;

            //// loop over all the MIN numericUpAndDown
            //foreach (NumericUpDown min in limitMin)
            //{
            //    // assign value to AssignedMin property of monitorModule object
            //    monitorModules.ElementAt(i).AssignedMin = (float)min.Value;

            //    // save monitorModule object at the index position
            //    monitorModules.ElementAt(i).Save();

            //    ++i;
            //}

            //int j = 0;
            //// loop over all the MAX numericUpAndDown
            //foreach (NumericUpDown max in limitMax)
            //{
            //    // assign value to AssignedMin property of monitorModule object
            //    monitorModules.ElementAt(j).AssignedMin = (float)max.Value;

            //    // save monitorModule object at the index position
            //    monitorModules.ElementAt(j).Save();

            //    ++j;
            //}

            // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            // Loop for as many times as the number of monitorModules and get relative min and max
            // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            for (int i = 0; i < monitorModules.Count; ++i)
            {
                // there is no need to create instance of monitorModule or numericUpAndDown
                // because we already have the objects in the List<XXX> variable

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
