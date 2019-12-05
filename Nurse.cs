using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    class Nurse : Staff
    {
        public new int Id { get; }
        public string PhoneNumber { get; set; }
        public int StaffID { get; set; }

        private static readonly string selectStatement = "SELECT * FROM nurse;";

        private static readonly string selectWhereStaffID =
            "SELECT * FROM nurse INNER JOIN staff ON nurse.staffID = staff.staffID " +
            "WHERE nurse.staffID = @staffID;";

        private static readonly string insertStatement = 
            "INSERT INTO nurse (phoneNumber, staffID) VALUES (@phoneNumber, @staffID);";

        private static readonly string updateStatement =
            "UPDATE nurse SET phoneNumber = @phoneNumber, staffID = @staffID WHERE nurseID = @nurseID;";

        public Nurse()
        {
        }

        /// <summary>
        /// Constructor. Instantiates staff class with values from parameters and sets phoneNumber and staffId of nurse instance
        /// </summary>
        /// <param name="staffTypeId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        public Nurse(int staffTypeId, string username, string password, string phoneNumber = null) 
        : base(staffTypeId, username, password)
        {
            PhoneNumber = phoneNumber;
            StaffID = base.Id;
        }

        /// <summary>
        /// Method to SMS. Calls base class function WriteNotificationToFile
        /// </summary>
        public void SendSMS(Alarm alarm)
        {
            string notifaicationType = "SMS";
            // Here there should be code to send SMS.
            //Then we write to file
            Staff.WriteNotificationToFile(alarm, notifaicationType);
        }

        /// <summary>
        /// Inserts this instance as row into nurse table
        /// </summary>
        public new Nullable<int> Save()
        {
            Nullable<int> savedStaffID = base.Save();

            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@phoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@staffID", savedStaffID));

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
        public new void Update()
        {
            base.Update();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.Add(new SqlParameter("@phoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@staffID", StaffID));
                command.Parameters.Add(new SqlParameter("@nurseID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        public static Nurse GetOneFromStaffID(int staffID)
        {

            Nurse nurse = new Nurse();
            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStaffID);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@staffID", staffID));

            DataSet nurseDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable nurseDataTable = nurseDataSet.Tables[0];

            if (nurseDataTable.Rows.Count == 1)
            {
                DataRow nurseRow = nurseDataTable.Rows[0];

                nurse.StaffTypeId = int.Parse(nurseRow["staffTypeID"].ToString());
                nurse.Username = nurseRow["username"].ToString();
                nurse.Password = nurseRow["password"].ToString();
                nurse.PhoneNumber = nurseRow["phoneNumber"].ToString();

                nurse.StaffID = int.Parse(nurseRow["staffID"].ToString());
            }

            return nurse;
        }
    }
}
