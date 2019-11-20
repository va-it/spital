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
        private DateTime DateTimeStart { get; set; }
        private DateTime DateTimeEnd { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement = 
            "SELECT * FROM session INNER JOIN staff ON session.staffID = staff.staffID;";

        private static readonly string selectWhereStatement =
            "SELECT * FROM session INNER JOIN staff ON session.staffID = staff.staffID " +
            "WHERE sessionID = @sessionID;";

        private static readonly string insertStatement =
            "INSERT INTO session (staffID, dateTimeStart, dateTimeEnd) " +
            "VALUES (@staffID, @dateTimeStart, @dateTimeEnd);";

        private static readonly string updateStatement =
            "UPDATE session SET staffID = @staffID, dateTimeStart = @dateTimeStart, " +
            "dateTimeEnd = @dateTimeEnd, WHERE sessionID = @sessionID;";

        /// <summary>
        /// Constructor. Sets Id value;
        /// </summary>
        public Session(int id)
        {
            Id = id;
            DateTimeStart = DateTime.Now;
        }

        /// <summary>
        /// Sets DateTimeStart value to the current date and time.
        /// </summary>
        public void Start()
        {
            DateTimeStart = DateTime.Now;
        }

        /// <summary>
        /// Sets DateTimeEnd value to the current date and time.
        /// </summary>
        public void End()
        {
            DateTimeEnd = DateTime.Now;
        }

        /// <summary>
        /// Returns a DataTable object of all sessions
        /// </summary>
        /// <returns></returns>
        public DataTable GetAll()
        {
            DataSet sessionDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable sessionDataTable = sessionDataSet.Tables[0];

            return sessionDataTable;
        }

        public static List<Session> GetActive()
        {
            List<Session> activeSessions = new List<Session>();

            DataSet sessionDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable sessionDataTable = sessionDataSet.Tables[0];

            foreach (DataRow sessionRow in sessionDataTable.Rows)
            {
                DateTime endDateTime = Convert.ToDateTime(sessionRow["endDateTime"].ToString());

                if (endDateTime == null || endDateTime > DateTime.Now)
                {
                    // There is no endDateTime set or it's in the future
                    Session session = new Session(Int32.Parse(sessionRow["sessionID"].ToString()));
                    activeSessions.Add(session);
                }
            }

            return activeSessions;
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
                session.DateTimeStart = DateTime.Parse(row["dateTimeStart"].ToString());
                session.DateTimeEnd = DateTime.Parse(row["dateTimeEnd"].ToString());
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
                command.Parameters.Add(new SqlParameter("@staffID", Id));
                command.Parameters.Add(new SqlParameter("@dateTimeStart", DateTimeStart));
                command.Parameters.Add(new SqlParameter("@dateTimeEnd", DateTimeEnd));

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
                command.Parameters.Add(new SqlParameter("@dateTimeStart", DateTimeStart));
                command.Parameters.Add(new SqlParameter("@dateTimeEnd", DateTimeEnd));
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
