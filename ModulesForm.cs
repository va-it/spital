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
        private MonitorForm Monitor { get; set; }

        public ModulesForm(MonitorForm monitorForm)
        {
            InitializeComponent();
            Monitor = monitorForm;
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            SaveSelectedModules();

            this.Close();
            Form limits = new LimitsForm(Monitor);
            limits.Show();
        }


        // to retrive module type from database
        public void FillModuleType()
        {
            DataTable modulesTable = Module.GetAll();

            checkedListBox_Modules.DataSource = modulesTable;
            checkedListBox_Modules.ValueMember = "moduleID";
            checkedListBox_Modules.DisplayMember = "name";
            
        }

        // Store selected modules into database in table "monitorModule" based on the monitor and module id
        private void SaveSelectedModules()
        {
            foreach (DataRowView row in checkedListBox_Modules.CheckedItems)
            {
                int moduleID = int.Parse(row["moduleID"].ToString());

                //create monitor and module objects
                Monitor monitor = new Monitor(Monitor.MonitorId);
                Module module = new Module(moduleID);

                MonitorModule monitorModule = new MonitorModule(monitor, module);
                monitorModule.AssignedMin = module.DefaultMin;
                monitorModule.AssignedMax = module.DefaultMax;
                monitorModule.Save();
            }
        }

        private void ModulesForm_Load(object sender, EventArgs e)
        {
            FillModuleType();
        }
    }
}
