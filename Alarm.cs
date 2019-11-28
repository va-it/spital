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
            "SELECT * FROM alarm INNER JOIN monitorModule ON monitorModule.monitorModuleID = alarm.monitorModuleID;";
        private static readonly string selectWhereStatement =
            "SELECT * FROM alarm WHERE alarmID=@alarmID;";

        private static readonly string insertStatement =
            "INSERT INTO alarm (staffID,monitorModuleID,startDateTime,endDateTime) " +
            "VALUES (@staffID,@monitorModuleID,@startDateTime,@endDateTime);";

        private static readonly string updateStatement =
            "UPDATE alarm SET staffID = @staffID, monitorModule = @monitorModule, " +
            "startDateTime = @startDateTime, endDateTime = @endDateTime WHERE alarmID = @alarmID;";
        
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
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@monitorModule", MonitorModule));
                command.Parameters.Add(new SqlParameter("@startDateTime", StartDateTime));
                command.Parameters.Add(new SqlParameter("@endDateTime", EndDateTime));

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
                command.Parameters.Add(new SqlParameter("@monitorModule", MonitorModule));
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

        
        public string Name { get; set; }
        public string StaffID { get; set; }
        public string MonitorModuleID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Alarm(int id)
        {
            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStatement);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@alarmID", id));

            DataSet alarmDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable alarmDataTable = alarmDataSet.Tables[0];

            if (alarmDataTable.Rows.Count == 1)
            {
                DataRow row = alarmDataTable.Rows[0];

                Id = Int32.Parse(row["alarmID"].ToString());
                StaffID = row["staffID"].ToString();
                MonitorModuleID = row["monitorModuleID"].ToString();
                Start = DateTime.Parse(row["startDateTime"].ToString());
                End = DateTime.Parse(row["endDateTme"].ToString());
            }
        }
        public static DataTable GetAll()
        {
            DataSet alarmDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable alarmDataTable = alarmDataSet.Tables[0];
            return alarmDataTable;
        }



    }
}
