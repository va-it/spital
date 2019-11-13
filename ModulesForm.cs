using spital.Properties;
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
        public ModulesForm()
        {
            InitializeComponent();
            FillModuleType();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            SelectedModule();
            // Form limits = new LimitsForm();
            // this.Close();
            // limits.Show();
        }

        /*
         * METHODS
         */

        // to retrive module type from database
        public void FillModuleType()
        {
            DataTable moduleTypeTable = Module.GetAll();

            checkedListBox_Modules.DataSource = moduleTypeTable;
            checkedListBox_Modules.ValueMember = "moduleID";
            checkedListBox_Modules.DisplayMember = "name";
        }

        // to store selected module to database in table "monitorModule" based on the moduleID
        public void SelectedModule()
        {
            foreach (DataRowView row in checkedListBox_Modules.CheckedItems)
            {
                // THIS IS TO SHOW THAT WE HAVE THE MODULE ID
                //MessageBox.Show(row["moduleID"].ToString());


                // THIS IS TO SHOW THAT THE CONSTRUCTOR CREATES THE MODULE FROM VALUES IN DATABASE
                int moduleID = int.Parse(row["moduleID"].ToString());
                MonitorModule monitorModule = new MonitorModule(moduleID);
                monitorModule.Save();

                //MessageBox.Show(module.Name);
            }
        }
    }
}
