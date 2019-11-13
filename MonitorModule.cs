using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    class MonitorModule
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; }
        public int ModuleID { get; set; }
        public Monitor Monitor { get; set; }
        public Module Module { get; set; }
        public float AssignedMin { get; set; }
        public float AssignedMax { get; set; }

        //Generic SELECT and INSERT Statement for MonitorModule Table
        private static readonly string selectStatement = "SELECT * FROM monitorModule";
        private static readonly string insertStatement = "INSERT INTO monitorModule (monitorModuleID, monitorID, moduleID, assignedMax, assignedMin)" + "VALUES (@monitorModuleID, @monitorID, @moduleID, @assignedMax, @assignedMin)";

        /// <summary>
        /// Constructor. Sets value of moduleID
        /// </summary>

        public MonitorModule(int moduleID)
        {
            ModuleID = moduleID;
        }

        /// <summary>
        /// Triggers an alarm for this monitor and module pair.
        /// </summary>
        public void TriggerAlarm()
        {
            Alarm alarm = new Alarm(this);
        }

        public void Save()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("moduleID", ModuleID));

                DatabaseConnection.Instance.ExectuteInsert(command);

            }

            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
