using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Monitor Monitor { get; set; }
        public Module Module { get; set; }
        public float AssignedMin { get; set; }
        public float AssignedMax { get; set; }

        private static readonly string selectStatement = 
            "SELECT * FROM monitorModule INNER JOIN module ON module.moduleID = monitorModule.moduleID";

        private static readonly string selectWhereStatement =
            "SELECT * FROM monitorModule INNER JOIN module ON module.moduleID = monitorModule.moduleID " +
            "WHERE monitorModuleID = @monitorModuleID";

        private static readonly string insertStatement =
            "INSERT INTO monitorModule (monitorID, moduleID, assignedMin, assignedMax) " +
            "VALUES (@monitorID, @moduleID, @assignedMin, @assignedMax)";

        private static readonly string updateStatement =
            "UPDATE monitorModule SET monitorID = @monitorID, moduleID = @moduleID, assignedMin = @assignedMin " +
            "assignedMax = @assignedMax WHERE monitorModuleID = @monitorModuleID";

        /// <summary>
        /// Constructor. Sets value of monitor and module from parameters
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="module"></param>
        public MonitorModule(Monitor monitor = null, Module module = null)
        {
            Monitor = monitor;
            Module = module;
        }

        /// <summary>
        /// Triggers an alarm for this monitor and module pair.
        /// </summary>
        public void TriggerAlarm()
        {
            Alarm alarm = new Alarm(this);
        }

        /// <summary>
        /// Returns a DataTable object of all MonitorModules
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAll()
        {
            DataSet monitorModuleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];

            return monitorModuleDataTable;
        }

        public static List<MonitorModule> GetAllFromMonitor(int monitorID)
        {
            DataSet monitorModuleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];

            List<MonitorModule> monitorModulesList = new List<MonitorModule>();

            foreach (DataRow monitorModuleRow in monitorModuleDataTable.Rows)
            {
                if (Int32.Parse(monitorModuleRow["monitorID"].ToString()) == monitorID)
                {
                    Monitor monitor = new Monitor(Int32.Parse(monitorModuleRow["monitorID"].ToString()));
                    Module module = new Module(Int32.Parse(monitorModuleRow["moduleID"].ToString()));
                    MonitorModule monitorModule = new MonitorModule(monitor, module);
                    monitorModulesList.Add(monitorModule);
                }
            }

            return monitorModulesList;
        }

        /// <summary>
        /// Retrieve one MonitorModule from the database based on its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>MonitorModule</returns>
        public static MonitorModule GetOne(int id)
        {
            MonitorModule monitorModule = new MonitorModule();

            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStatement);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@monitorModuleID", id));

            DataSet monitorModuleDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];

            if (monitorModuleDataTable.Rows.Count == 1)
            {
                DataRow row = monitorModuleDataTable.Rows[0];

                Monitor monitor = new Monitor(Int32.Parse(row["monitorID"].ToString()));
                Module module = new Module(Int32.Parse(row["moduleID"].ToString()));

                monitorModule = new MonitorModule(monitor, module)
                {
                    AssignedMin = float.Parse(row["assignedMin"].ToString()),
                    AssignedMax = float.Parse(row["assignedMax"].ToString())
                };
            }

            return monitorModule;
        }

        /// <summary>
        /// Inserts this instance as row into monitorModule table
        /// </summary>
        public void Save()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@monitorID", Monitor.Id));
                command.Parameters.Add(new SqlParameter("@moduleID", Module.Id));
                command.Parameters.Add(new SqlParameter("@assignedMin", AssignedMin));
                command.Parameters.Add(new SqlParameter("@assignedMax", AssignedMax));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        /// <summary>
        /// Updates entry in database with values from this instance 
        /// </summary>
        public void Update()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.Add(new SqlParameter("@monitorID", Monitor.Id));
                command.Parameters.Add(new SqlParameter("@moduleID", Module.Id));
                command.Parameters.Add(new SqlParameter("@assignedMin", AssignedMin));
                command.Parameters.Add(new SqlParameter("@assignedMax", AssignedMax));
                command.Parameters.Add(new SqlParameter("@monitorModuleID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
