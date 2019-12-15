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
        public float Reading { get; set; }

        private static readonly string selectStatement =
            "SELECT * FROM alarm INNER JOIN monitorModule ON " +
            "monitorModule.monitorModuleID = alarm.monitorModuleID AND monitorModule.deleted = 0;";
        private static readonly string selectWhereStatement =
            "SELECT * FROM alarm WHERE alarmID=@alarmID;";

        private static readonly string selectAlarm =
            "SELECT alarm.alarmID AS 'Alarm ID', monitorModule.monitorID AS 'Monitor ID', " +
            "module.name AS 'Module Name' , alarm.startDateTime AS 'Alarm Start Time', " +
            "alarm.endDateTime AS 'Alarm End Time', alarm.reading AS 'Reading' FROM alarm " +
            "LEFT JOIN monitorModule ON monitorModule.monitorModuleID = alarm.monitorModuleID " +
            "LEFT JOIN module ON monitorModule.moduleID = module.moduleID";

        private static readonly string insertStatement =
            "INSERT INTO alarm (monitorModuleID,startDateTime,endDateTime,reading) " +
            "VALUES (@monitorModuleID,@startDateTime,@endDateTime,@reading);";

        private static readonly string updateStatement =
            "UPDATE alarm SET monitorModuleID = @monitorModuleID, " +
            "startDateTime = @startDateTime, endDateTime = @endDateTime WHERE alarmID = @alarmID;";

        public Alarm() { }

        /// <summary>
        /// Constructor. Sets MonitorModule from parameter and defines DateTimeStart and Reading 
        /// </summary>
        /// <param name="monitorModule"></param>
        public Alarm(MonitorModule monitorModule, float reading)
        {
            MonitorModule = monitorModule;
            StartDateTime = DateTime.Now;
            Reading = reading;
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
                command.Parameters.Add(new SqlParameter("@reading", Reading));
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
                command.Parameters.Add(new SqlParameter("@reading", Reading));
                command.Parameters.Add(new SqlParameter("@alarmID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
        
        /// <summary>
        /// Retrieves all records from database
        /// </summary>
        /// <returns>DataTable of all alarms</returns>
        public static DataTable GetAll()
        {
            DataSet alarmDataSet = DatabaseConnection.Instance.GetDataSet(selectAlarm);
            DataTable alarmDataTable = alarmDataSet.Tables[0];
            return alarmDataTable;
        }

        /// <summary>
        /// Retrieves all alarms associated with the monitor with ID as parameter
        /// </summary>
        /// <param name="monitorID"></param>
        /// <returns>List of alarms for monitor with ID as parameter</returns>
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
                    if (alarmRow["reading"] != DBNull.Value)
                    {
                        alarm.Reading = float.Parse(alarmRow["reading"].ToString());
                    }   
                    alarms.Add(alarm);
                }
            }

            return alarms;
        }

        /// <summary>
        /// Prompts Central Display to show details about this alarm
        /// </summary>
        public void NotifyCentralDisplay()
        {
            CentralDisplay.Instance.DisplayAlarm(this);
        }

        /// <summary>
        /// Prompts Staff to notify members with active sessions
        /// </summary>
        public void NotifyStaff()
        {
            Staff.NotifyMembersWithActiveSessions(this);
        }
    }
}
