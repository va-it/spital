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
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            // Code to stop the alarm
            MessageBox.Show("Alarm has been stopped", "Alarm stopped");
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            // Code to select the modules
            Form modules = new ModulesForm();
            modules.Show();
        }

        private void limitsButton_Click(object sender, EventArgs e)
        {
            // Code to edit the modules limits
            Form limits = new LimitsForm();
            limits.Show();
        }

        private DataTable RetrieveModules()
        {
            return MonitorModule.GetAll();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            DataTable monitorModuleDataTable = RetrieveModules();

            int index = 1;


            foreach (DataRow row in monitorModuleDataTable.Rows)
            {
                if (index==1)
                {
                    moduleReading1.Text = row["name"].ToString();
                }

                if (index == 2)
                {
                    moduleReading2.Text = row["name"].ToString();
                }

                if (index == 3)
                {
                    moduleReading3.Text = row["name"].ToString();
                }

                if (index == 4)
                {
                    moduleReading4.Text = row["name"].ToString();
                }

                index++;

            }


            
        }
    }
}
