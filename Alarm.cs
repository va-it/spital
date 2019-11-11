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
    class Alarm
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; }
        // Why do we have staffID in the alarm table?
        public Staff Staff { get; set; }
        public MonitorModule MonitorModule { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        private static readonly string selectStatement = 
            "SELECT * FROM alarm INNER JOIN monitorModule ON monitorModule.monitorModuleID = alarm.monitorModuleID";

        private static readonly string insertStatement =
            "INSERT INTO alarm (staffID,monitorModuleID,startDateTime,endDateTime) " +
            "VALUES (@staffID,@monitorModuleID,@startDateTime,@endDateTime)";

        private static readonly string updateStatement =
            "UPDATE alarm SET staffID = @staffID, monitorModule = @monitorModule, " +
            "startDateTime = @startDateTime, endDateTime = @endDateTime WHERE alarmID = @alarmID";
        
        /// <summary>
        /// Constructor. Sets MonitorModule from parameter and defines Id and DateTimeStart 
        /// </summary>
        /// <param name="monitorModule"></param>
        public Alarm(MonitorModule monitorModule)
        {
            MonitorModule = monitorModule;
            StartDateTime = DateTime.Now;
        }

        /// <summary>
        /// Sets current date and time to DateTimeEnd 
        /// </summary>
        public void Stop()
        {
            EndDateTime = DateTime.Now;
        }

        /// <summary>
        /// Inserts this instance as row into alarm table
        /// </summary>
        public void Save()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("monitorModule", MonitorModule));
                command.Parameters.Add(new SqlParameter("startDateTime", StartDateTime));
                command.Parameters.Add(new SqlParameter("endDateTime", EndDateTime));

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
                command.Parameters.AddWithValue("@monitorModule", MonitorModule);
                command.Parameters.AddWithValue("@startDateTime", StartDateTime);
                command.Parameters.AddWithValue("@endDateTime", EndDateTime);
                command.Parameters.AddWithValue("@alarmID", Id);

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

    }
}
