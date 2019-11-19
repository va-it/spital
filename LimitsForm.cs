using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace spital
{
    public partial class LimitsForm : Form
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //Temp variable to connect to database to check update is working 
        //private SqlConnection _con;
        //private SqlCommand _cmd;
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

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
            SaveAssignedLimits();
            Close();
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

        private void SaveAssignedLimits()
        {
            for (int i = 0; i < monitorModules.Count; ++i)
            {
                monitorModules.ElementAt(i).AssignedMin = (float)limitMin.ElementAt(i).Value;
                monitorModules.ElementAt(i).AssignedMax = (float)limitMax.ElementAt(i).Value;

                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                //Temp code to connect directly to database and check if the update is working 
                //This code is giving scalar variable error for monitorModuleID

                //_con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\git\spital\Spital.mdf; Integrated Security = True; Connect Timeout = 30");
                //_con.Open();
                //_cmd = new SqlCommand("UPDATE monitorModule SET assignedMax=@assignedMax, assignedMin=@assignedMin WHERE monitorModuleID=@monitorModuleID", _con);
                //_cmd.Parameters.AddWithValue("@assignedMax", maxLimit1.Value);
                //_cmd.Parameters.AddWithValue("@assignedMin", minLimit1.Value);
                //_cmd.ExecuteNonQuery();

                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                monitorModules.ElementAt(i).Update();
            }

        }


        private void LimitsForm_Shown(object sender, EventArgs e)
        {
            FillLimits();
        }
    }
}
