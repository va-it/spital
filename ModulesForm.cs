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
            Form limits = new LimitsForm();
            this.Close();
            limits.Show();
        }

        /*
         * METHODS
         */

        // to retrive module type from database
        public void FillModuleType()
        { 
            DataSet dataSet = DatabaseConnection.Instance.GetDataSet("SELECT name FROM module");

            DataTable moduleTable = dataSet.Tables[0];

            foreach(DataRow row in moduleTable.Rows)
            {
                checkedListBox_Modules.Items.Add(row["name"].ToString());
            }
        }
    }
}
