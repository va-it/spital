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
    public class Monitor
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public bool Active { get; set; }

        private static readonly string selectStatement = "SELECT * FROM monitor;";

        private static readonly string selectWhereStatement = "SELECT * FROM monitor WHERE monitorID = @monitorID;";

        private static readonly string insertStatement = "INSERT INTO monitor (monitorID, active) VALUES (@monitorID, @active);";

        private static readonly string updateStatement = "UPDATE monitor SET active = @active WHERE monitorID = @monitorID;";

        /// <summary>
        /// Constructor. Instantiate object without values
        /// </summary>
        public Monitor() { }

        /// <summary>
        /// Constructor. Sets Id and Active based on values from database
        /// </summary>
        public Monitor(Nullable<int> id)
        {
            if (id.HasValue)
            {
                SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStatement);
                sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@monitorID", id));

                DataSet monitorDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

                DataTable monitorDataTable = monitorDataSet.Tables[0];

                if (monitorDataTable.Rows.Count == 1)
                {
                    DataRow row = monitorDataTable.Rows[0];

                    Id = Int32.Parse(row["monitorID"].ToString());
                    Active = Convert.ToBoolean(row["active"].ToString());
                }
            }           
        }

        
        /// <summary>
        /// Retrieve one Monitor from the database based on its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Monitor</returns>
        public static Monitor GetOne(int id)
        {
            Monitor monitor = new Monitor(id);

            return monitor;
        }

        /// <summary>
        /// Inserts this instance as row into monitor table
        /// </summary>
        public void Save()
        {

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@monitorID", Id));
                command.Parameters.Add(new SqlParameter("@active", Active));

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
                command.Parameters.Add(new SqlParameter("@active", Active));
                command.Parameters.Add(new SqlParameter("@monitorID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        public List<Alarm> GetActiveAlarms()
        {
            List<Alarm> activeAlarms = new List<Alarm>();

            // Get all alarms where monitorID is this.Id

            foreach (Alarm alarm in Alarm.GetAllForMonitor(Id))
            {
                if (!alarm.EndDateTime.HasValue)
                {
                    activeAlarms.Add(alarm);
                }
            }

            return activeAlarms;
        }
    }
}
