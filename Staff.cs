using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spital.Properties;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace spital
{
    abstract class Staff
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; }
        public int StaffTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private static readonly string encryptionPassword = "7689iknh7564fbg6ghjgbt6";

        private static readonly string selectStatement = "SELECT * FROM staff;";

        private static readonly string selectWithUsername = " SELECT * FROM staff WHERE username=@username;";

        private static readonly string insertStatement =
            "INSERT INTO staff (staffTypeID, username, password) VALUES (@staffTypeID, @username, @password);";

        private static readonly string updateStatement =
            "UPDATE staff SET staffTypeID = @staffTypeID, username = @username, password = @password " +
            "WHERE staffID = @staffID;";

        /// <summary>
        /// Constructor. Sets Id automatically and values from parameters
        /// </summary>
        /// <param name="staffType"></param>
        public Staff(int staffType, string username, string password)
        {
            StaffTypeId = staffType;
            Username = username;
            Password = Encryption.EncryptText(password, encryptionPassword);
        }

        //public List<Staff> GetActiveStaff()
        //{
        //    List<Staff> activeStaff = new List<Staff>();

        //    //Get all active staff where staffID is this.id

        //    foreach(Session session in Session.GetActiveStaffSession(Id))
        //    {
        //        if ()
        //    }
        //}


        public static bool ValidateCredentials(string username, string password)
        {
            // Retrieve values from DB and validate
            /* 
             * Note, need to compare encrypted version of password
             * so the passed password needs to be encrypted first
             */

            bool valid = false;

            DataSet staffDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);

            DataTable staffDataTable = staffDataSet.Tables[0];

            foreach (DataRow row in staffDataTable.Rows)
            {
                if (String.Equals(username, row["username"].ToString()))
                {
                    string comparePassword = Encryption.DecryptText(row["password"].ToString(), encryptionPassword);

                    if (String.Equals(password, comparePassword))
                    {
                        // Credentials match
                        valid = true;
                    }
                }
            }

            return valid;
        }
        /// <summary>
        /// Triggers authentication and, upon success, starts session
        /// </summary>
        public void Register()
        {
            // trigger authentication and, upon success, start session
        }

        /// <summary>
        /// Triggers authentication and, upon success, ends active session
        /// </summary>
        public void DeRegister()
        {
            // trigger authentication and, upon success, end session
        }

        /// <summary>
        /// Authentication trigger
        /// </summary>
        public void Login()
        {
            // Authentication trigger
        }

        public void Notify()
        {
            switch (StaffTypeId)
            {
                case 1:
                    // Nurse, notify via SMS/Pager
                    break;
                case 2:
                    // Consultant, notify via email
                    break;
                default:
                    // No type matched.
                    break;
            }

        }

        /// <summary>
        /// Inserts this instance as row into staff table
        /// </summary>
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@staffTypeID", StaffTypeId));
                command.Parameters.Add(new SqlParameter("@username", Username));
                command.Parameters.Add(new SqlParameter("@password", Password));

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
                command.Parameters.Add(new SqlParameter("@staffTypeID", StaffTypeId));
                command.Parameters.Add(new SqlParameter("@username", Username));
                command.Parameters.Add(new SqlParameter("@password", Password));
                command.Parameters.Add(new SqlParameter("@staffID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }

        }

        public static DataTable GetWithUsername(string username)
        {
            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWithUsername);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@username", username));

            DataSet staffDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable staffDataTable = staffDataSet.Tables[0];

            return staffDataTable;
        }
    }
}
