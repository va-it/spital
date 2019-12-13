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
    public partial class ModulesForm : Form
    {
        private MonitorForm MonitorForm { get; set; }

        public ModulesForm(MonitorForm monitorForm)
        {
            InitializeComponent();
            MonitorForm = monitorForm;
        }

        /// <summary>
        /// Retrieves modules from database to populate checkedListBox
        /// </summary>
        public void FillModulesSelection()
        {
            DataTable modulesTable = Module.GetAll();

            checkedListBox_Modules.DataSource = modulesTable;
            checkedListBox_Modules.ValueMember = "moduleID";
            checkedListBox_Modules.DisplayMember = "name";
            
        }

        /// <summary>
        /// Store selected modules in table "monitorModule"
        /// </summary>
        private void SaveSelectedModules()
        {
            List<int> monitorModulesToSkip = new List<int>();

            // retrieve list of monitorModules for current monitor
            List<MonitorModule> monitorModules = MonitorModule.GetAllFromMonitor(MonitorForm.MonitorId);

            //List to store all monitorModules that need to be saved
            List<MonitorModule> modulesToSave = new List<MonitorModule>();

            //List to store all monitorModules that need to be deleted
            List<MonitorModule> modulesToDelete = new List<MonitorModule>();

            // loop over every checkbox
            for (int i = 0; i < checkedListBox_Modules.Items.Count; ++i)
            {
                DataRowView moduleCheckBox = checkedListBox_Modules.Items[i] as DataRowView;
                int moduleID = Int32.Parse(moduleCheckBox["ModuleID"].ToString());

                // if module is checked
                if (checkedListBox_Modules.GetItemCheckState(i) == CheckState.Checked)
                {
                    
                    // and it is not found in the monitorModule table
                    if (!monitorModules.Exists(x => x.Module.Id == moduleID))
                    {
                        // then we will need to save it
                        //create monitor and module objects
                        Monitor monitor = new Monitor(MonitorForm.MonitorId);
                        Module module = new Module(moduleID);

                        MonitorModule monitorModule = new MonitorModule(monitor, module);
                        monitorModule.AssignedMin = module.DefaultMin;
                        monitorModule.AssignedMax = module.DefaultMax;

                        modulesToSave.Add(monitorModule);
                    }
                }
                else
                {
                    // if the module is unchecked
                    if (checkedListBox_Modules.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        // we need to check if it was previously checked and saved
                        int indexOfMonitorModuleToDelete = monitorModules.FindIndex(x => x.Module.Id == moduleID);

                        // monitorModule is saved in monitorModule table
                        if (indexOfMonitorModuleToDelete != -1)
                        {
                            // In which case it will need to be deleted
                            modulesToDelete.Add(monitorModules.ElementAt(indexOfMonitorModuleToDelete));
                        }
                    }
                }
            }

            foreach (MonitorModule monitorModuleToSave in modulesToSave)
            {
                monitorModuleToSave.Save();
            }

            foreach (MonitorModule monitorModuleToDelete in modulesToDelete)
            {
                monitorModuleToDelete.Delete();
                StopAlarmForUnpluggedModule(monitorModuleToDelete);
            }
        }

        /// <summary>
        /// Stops alarm if triggered by module that is being unplugged
        /// </summary>
        /// <param name="monitorModuleToDelete">Module being unplugged</param>
        private void StopAlarmForUnpluggedModule(MonitorModule monitorModuleToDelete)
        {
            foreach (Alarm alarm in MonitorForm.alarms)
            {
                if (alarm.MonitorModule.Id == monitorModuleToDelete.Id)
                {
                    alarm.Stop();
                }
            }
        }

        /// <summary>
        /// Automatically select modules in checkedListBox if already attached to monitor
        /// </summary>
        private void SelectExistingModules()
        {
            List<MonitorModule> monitorModules = MonitorModule.GetAllFromMonitor(MonitorForm.MonitorId);

            for (int i = 0; i < checkedListBox_Modules.Items.Count; ++i)
            {
                DataRowView module = checkedListBox_Modules.Items[i] as DataRowView;
                int moduleId = Int32.Parse(module["ModuleID"].ToString());

                foreach (MonitorModule monitorModule in monitorModules)
                {
                    if (moduleId == monitorModule.Module.Id)
                    {
                        checkedListBox_Modules.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void ModulesForm_Load(object sender, EventArgs e)
        {
            FillModulesSelection();
            SelectExistingModules();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            SaveSelectedModules();

            this.Close();
            Form limits = new LimitsForm(MonitorForm);
            limits.Show();
        }
    }
}
