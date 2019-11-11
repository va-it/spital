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
    class Monitor
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public bool Active { get; set; }

        private static readonly string selectStatement = "SELECT * FROM monitor";

        private static readonly string selectWhereStatement = "SELECT * FROM monitor WHERE monitorID = @monitorID";

        private static readonly string insertStatement = "INSERT INTO monitor (monitorID, active) VALUES (@monitorID, @active)";

        private static readonly string updateStatement = "UPDATE monitor SET active = @active WHERE monitorID = @monitorID";

        /// <summary>
        /// Constructor. Sets Id and active flag
        /// </summary>
        public Monitor(int id)
        {
            // should this values be retrieved from database?
            Id = id;
            Active = true;
        }

        /// <summary>
        /// Stops previously triggered alarm.
        /// </summary>
        public void StopAlarm()
        {
            // Stop alarm
        }

        /// <summary>
        /// Displays the readings from associated modules.
        /// </summary>
        public void DisplayPatientData()
        {
            // Display readings from modules
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
                command.Parameters.Add(new SqlParameter("monitorID", Id));
                command.Parameters.Add(new SqlParameter("active", Active));

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
                command.Parameters.AddWithValue("@active", Active);
                command.Parameters.AddWithValue("@monitorID", Id);

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
