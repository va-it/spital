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
        private CheckBox[] _checkBoxes;

        public ModulesForm()
        {
            InitializeComponent();
            FillModuleType();
        }
 
        private void modulesButton_Click(object sender, EventArgs e)
        {
            Form limits = new LimitsForm();

            if (!moduleSelection1.Checked)
            {
                if (moduleSelection2.Checked)
                {
                    //Assign to labelModule2 in LimitForm
                    string CheckboxText = moduleSelection2.Text;
                    

                }
                else if (moduleSelection3.Checked)
                {
                    //Assign to labelModule3 in LimitForm
                }
                else if (moduleSelection4.Checked)
                {
                    //Assign to labelModule4 in LimitForm
                }
            }
            else
            {
                //Assign to labelModule1 in LimitForm
            }

            this.Close();
            limits.Show();
        }

        /*
         * METHODS
         */

        // to retrive module type from database
        public void FillModuleType()
        { 
            DataSet dataSet = DatabaseConnection.Instance.GetDataSet("SELECT moduleName FROM module");

            DataTable moduleTable = dataSet.Tables[0];

            Form moduleForm = new ModulesForm();

            _checkBoxes = new CheckBox[] { moduleSelection1, moduleSelection2, moduleSelection3, moduleSelection4 };

            foreach(CheckBox checkBox in _checkBoxes)
            {
                foreach (DataRow row in moduleTable.Rows)
                {
                   _checkBoxes.text = row["moduleName"].ToString();
                }
            }
        }
    }
}
