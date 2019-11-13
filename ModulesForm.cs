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
        List<PictureBox> modulesIcons = new List<PictureBox>();
        List<CheckBox> modules = new List<CheckBox>();

        public ModulesForm()
        {
            InitializeComponent();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            SaveSelectedModules();

            this.Close();
            Form limits = new LimitsForm();
            limits.Show();
        }

        private void GenerateListsOfControls()
        {
            modules.Add(moduleSelection1);
            modules.Add(moduleSelection2);
            modules.Add(moduleSelection3);
            modules.Add(moduleSelection4);
            modules.Add(moduleSelection5);
            modules.Add(moduleSelection6);
            modules.Add(moduleSelection7);
            modules.Add(moduleSelection8);

            modulesIcons.Add(ModulePicture1);
            modulesIcons.Add(ModulePicture2);
            modulesIcons.Add(ModulePicture3);
            modulesIcons.Add(ModulePicture4);
            modulesIcons.Add(ModulePicture5);
            modulesIcons.Add(ModulePicture6);
            modulesIcons.Add(ModulePicture7);
            modulesIcons.Add(ModulePicture8);
        }

        private void ModulesForm_Load(object sender, EventArgs e)
        {
            GenerateListsOfControls();

            DataTable moduleDataTable = Module.GetAll();

            int index = 0;

            foreach (DataRow row in moduleDataTable.Rows)
            {
                modules.ElementAt(index).Text = row["name"].ToString();
                modulesIcons.ElementAt(index).Text = row["icon"].ToString();

                index++;
            }
        }

        private void SaveSelectedModules()
        {
            int index = 0;

            foreach (CheckBox checkBox in modules)
            {
                if (modules.ElementAt(index).Checked)
                {
                    // Save this module into the monitorModule table
                    Monitor monitor = new Monitor(1);
                    
                    // Instantiate module from ID in checkbox
                    // MonitorModule monitorModule = new MonitorModule(monitor, module);
                    // monitorModule.Save();
                }

                index++;
            }
        }
    }
}
