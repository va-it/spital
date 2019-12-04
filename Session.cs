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
    class Session
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; set; }
        public int StaffId { get; set; }
        private DateTime StartDateTime { get; set; }
        private Nullable<DateTime> EndDateTime { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement =
            "SELECT * FROM session INNER JOIN staff ON session.staffID = staff.staffID;";

        private static readonly string selectActiveStaffSession =
            "SELECT * FROM session " +
            "INNER JOIN staff ON session.staffID = staff.staffID " +
            "WHERE session.endDateTime IS NULL;";

        private static readonly string selectWhereStatement =
            "SELECT * FROM session INNER JOIN staff ON session.staffID = staff.staffID " +
            "WHERE sessionID = @sessionID;";

        private static readonly string insertStatement =
            "INSERT INTO session (staffID, startDateTime) " +
            "VALUES (@staffID, @startDateTime);";

        private static readonly string updateStatement =
            "UPDATE session SET staffID = @staffID, startDateTime = @startDateTime, " +
            "endDateTime = @endDateTime, WHERE sessionID = @sessionID;";

        //SELECT statement for session details
        private static readonly string selectSessionDetails =
            "SELECT session.staffID AS 'Staff ID', staff.username AS 'Username', session.startDateTime AS 'Start Date Time',  session.endDateTime AS 'End Date Time'" +
            "FROM session " +
            "INNER JOIN staff ON session.staffID = staff.staffID";

        /// <summary>
        /// Constructor. Sets Id value;
        /// </summary>
        public Session(int staffID)
        {
            StaffId = staffID;
            StartDateTime = DateTime.Now;
            EndDateTime = null;
        }

        public Session() { }

        /// <summary>
        /// Sets DateTimeStart value to the current date and time.
        /// </summary>
        public void Start()
        {
            StartDateTime = DateTime.Now;
        }

        /// <summary>
        /// Sets DateTimeEnd value to the current date and time.
        /// </summary>
        public void End()
        {
            EndDateTime = DateTime.Now;
        }

        /// <summary>
        /// Returns a DataTable object of all sessions
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAll()
        {
            DataSet sessionDataSet = DatabaseConnection.Instance.GetDataSet(selectSessionDetails);
            DataTable sessionDataTable = sessionDataSet.Tables[0];
            return sessionDataTable;
        }

        /// <summary>
        /// Retrieves all active sessions 
        /// </summary>
        /// <returns>A DataTable containing active sessions</returns>
        public static DataTable GetActiveSessions()
        {
            
            DataSet activeSessionsDataSet = DatabaseConnection.Instance.GetDataSet(selectActiveStaffSession);
            DataTable activeSessionsDataTable = activeSessionsDataSet.Tables[0];

            return activeSessionsDataTable;
        }


        // WIP CODE
        public Session GetOne(int id)
        {
            Session session = new Session(id);

            SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();
            command.CommandText = selectWhereStatement;
            command.Parameters.Add(new SqlParameter("@sessionID", id));

            DataSet sessionDataSet = DatabaseConnection.Instance.GetDataSet(selectWhereStatement);
            DataTable sessionDataTable = sessionDataSet.Tables[0];

            if (sessionDataTable.Rows.Count == 1)
            {
                DataRow row = sessionDataTable.Rows[0];

                // Only one record has been retrieved
                session = new Session(id);
                session.StaffId = Int32.Parse(row["staffID"].ToString());
                session.StartDateTime = DateTime.Parse(row["dateTimeStart"].ToString());
                session.EndDateTime = DateTime.Parse(row["dateTimeEnd"].ToString());
            }

            return session;
        }

        /// <summary>
        /// Inserts this instance as row into session table
        /// </summary>
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@staffID", StaffId));
                command.Parameters.Add(new SqlParameter("@startDateTime", StartDateTime));
                if (EndDateTime != null)
                {
                    command.Parameters.Add(new SqlParameter("@endDateTime", EndDateTime));
                }

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
                command.Parameters.Add(new SqlParameter("@staffID", StaffId));
                command.Parameters.Add(new SqlParameter("@dateTimeStart", StartDateTime));
                command.Parameters.Add(new SqlParameter("@dateTimeEnd", EndDateTime));
                command.Parameters.Add(new SqlParameter("@sessionID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }



    }
}
