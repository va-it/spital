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
    public class Alarm
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public MonitorModule MonitorModule { get; set; }
        public DateTime StartDateTime { get; set; }
        public Nullable<DateTime> EndDateTime { get; set; }

        private static readonly string selectStatement = 
            "SELECT * FROM alarm INNER JOIN monitorModule ON monitorModule.monitorModuleID = alarm.monitorModuleID;";

        private static readonly string insertStatement =
            "INSERT INTO alarm (monitorModuleID,startDateTime,endDateTime) " +
            "VALUES (@monitorModuleID,@startDateTime,@endDateTime);";

        private static readonly string updateStatement =
            "UPDATE alarm SET monitorModuleID = @monitorModuleID, " +
            "startDateTime = @startDateTime, endDateTime = @endDateTime WHERE alarmID = @alarmID;";

        public Alarm() { }

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
            this.Update();
        }

        /// <summary>
        /// Inserts this instance as row into alarm table
        /// </summary>
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@monitorModuleID", MonitorModule.Id));
                command.Parameters.Add(new SqlParameter("@startDateTime", StartDateTime));
                command.Parameters.Add(new SqlParameter("@endDateTime", DBNull.Value));

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
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.Add(new SqlParameter("@monitorModuleID", MonitorModule.Id));
                command.Parameters.Add(new SqlParameter("@startDateTime", StartDateTime));
                command.Parameters.Add(new SqlParameter("@endDateTime", EndDateTime));
                command.Parameters.Add(new SqlParameter("@alarmID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        public static List<Alarm> GetAllForMonitor(int monitorID)
        {
            List<Alarm> alarms = new List<Alarm>();

            DataSet alarmDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable alarmDataTable = alarmDataSet.Tables[0];

            foreach (DataRow alarmRow in alarmDataTable.Rows)
            {

                MonitorModule monitorModule = MonitorModule.GetOne(Int32.Parse(alarmRow["monitorModuleID"].ToString()));

                if (monitorModule.Monitor.Id == monitorID)
                {
                    Alarm alarm = new Alarm();

                    alarm.Id = Int32.Parse(alarmRow["alarmId"].ToString());
                    alarm.MonitorModule = monitorModule;
                    alarm.MonitorModule.Id = Int32.Parse(alarmRow["monitorModuleID"].ToString());
                    alarm.StartDateTime = DateTime.Parse(alarmRow["startDateTime"].ToString());
                    if (alarmRow["endDateTime"] != DBNull.Value)
                    {
                        alarm.EndDateTime = DateTime.Parse(alarmRow["endDateTime"].ToString());
                    }
                    alarms.Add(alarm);
                }
            }

            return alarms;
        }

    }
}
