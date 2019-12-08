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
    public class MonitorModule
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public Monitor Monitor { get; set; }
        public Module Module { get; set; }
        public float AssignedMin { get; set; }
        public float AssignedMax { get; set; }
        public bool Deleted { get; set; }

        private static readonly string selectStatement = 
            "SELECT * FROM monitorModule INNER JOIN module ON module.moduleID = monitorModule.moduleID " +
            "WHERE monitorModule.deleted = 0";

        private static readonly string selectWhereStatement =
            "SELECT * FROM monitorModule INNER JOIN module ON module.moduleID = monitorModule.moduleID " +
            "WHERE monitorModuleID = @monitorModuleID AND monitorModule.deleted = 0;";

        private static readonly string insertStatement =
            "INSERT INTO monitorModule (monitorID, moduleID, assignedMin, assignedMax) " +
            "VALUES (@monitorID, @moduleID, @assignedMin, @assignedMax);";

        private static readonly string updateStatement =
            "UPDATE monitorModule SET monitorID = @monitorID, moduleID = @moduleID, assignedMin = @assignedMin, " +
            "assignedMax = @assignedMax, deleted = @deleted WHERE monitorModuleID = @monitorModuleID;";

        private static readonly string deleteStatement = 
            "UPDATE monitorModule SET deleted = 1 WHERE monitorModuleID = @monitorModuleID;";

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
        public void TriggerAlarm(float reading)
        {
            Alarm alarm = new Alarm(this, reading);
            alarm.Save();
            alarm.NotifyCentralDisplay();
        }

        /// <summary>
        /// Returns a DataTable object of all MonitorModules
        /// </summary>
        /// <returns>DataTable of all monitorModules</returns>
        public static DataTable GetAll()
        {
            DataSet monitorModuleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];

            return monitorModuleDataTable;
        }

        /// <summary>
        /// Retrieve all monitorModules for monitor with ID as parameter
        /// </summary>
        /// <param name="monitorID"></param>
        /// <returns>List of monitorModules for monitor with ID as parameter</returns>
        public static List<MonitorModule> GetAllFromMonitor(Nullable<int> monitorID)
        {
            List<MonitorModule> monitorModulesList = new List<MonitorModule>();

            if (monitorID.HasValue)
            {
                DataSet monitorModuleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
                DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];

                foreach (DataRow monitorModuleRow in monitorModuleDataTable.Rows)
                {
                    if (Int32.Parse(monitorModuleRow["monitorID"].ToString()) == monitorID)
                    {
                        Monitor monitor = new Monitor(Int32.Parse(monitorModuleRow["monitorID"].ToString()));
                        Module module = new Module(Int32.Parse(monitorModuleRow["moduleID"].ToString()));
                        MonitorModule monitorModule = new MonitorModule(monitor, module);
                        monitorModule.Id = Int32.Parse(monitorModuleRow["monitorModuleID"].ToString());
                        monitorModule.AssignedMin = float.Parse(monitorModuleRow["assignedMin"].ToString());
                        monitorModule.AssignedMax = float.Parse(monitorModuleRow["assignedMax"].ToString());
                        monitorModule.Deleted = Convert.ToBoolean(monitorModuleRow["deleted"].ToString());
                        monitorModulesList.Add(monitorModule);
                    }
                }
            }

            return monitorModulesList;
        }

        /// <summary>
        /// Triggers alarm if parameter is outside the AssignedMin and AssignedMax range
        /// </summary>
        /// <param name="random"></param>
        public void CheckReading(float random)
        {
            if (random < AssignedMin || random > AssignedMax)
            { 
                TriggerAlarm(random);
            }
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
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@monitorID", Monitor.Id));
                command.Parameters.Add(new SqlParameter("@moduleID", Module.Id));
                command.Parameters.Add(new SqlParameter("@assignedMin", AssignedMin));
                command.Parameters.Add(new SqlParameter("@assignedMax", AssignedMax));

                lastInsertedID = DatabaseConnection.Instance.ExecuteInsert(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }

            return lastInsertedID;
        }

        /// <summary>
        /// Updates entry in database with values from this instance 
        /// </summary>
        public void Update()
        {
            int rowsAffected = 0;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.Add(new SqlParameter("@monitorID", Monitor.Id));
                command.Parameters.Add(new SqlParameter("@moduleID", Module.Id));
                command.Parameters.Add(new SqlParameter("@assignedMin", AssignedMin));
                command.Parameters.Add(new SqlParameter("@assignedMax", AssignedMax));
                command.Parameters.Add(new SqlParameter("@deleted", Deleted));
                command.Parameters.Add(new SqlParameter("@monitorModuleID", Id));

                rowsAffected = DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        /// <summary>
        /// Sets the value of deleted column for this entry to TRUE
        /// </summary>
        /// <returns></returns>
        public int Delete()
        {
            int rowsAffected = 0;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = deleteStatement;
                command.Parameters.Add(new SqlParameter("@monitorModuleID", Id));

                rowsAffected = DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }

            return rowsAffected;
        }
    }
}
