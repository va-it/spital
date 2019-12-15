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
    public class Consultant : Staff
    {
        public new int Id { get; set; }
        public string Email { get; set; }
        public int StaffID { get; set; }
        public string storage = "notification.txt";

        private static readonly string selectStatement = "SELECT * FROM consultant;";

        private static readonly string insertStatement = "INSERT INTO consultant (email, staffID) VALUES (@email, @staffID);";

        private static readonly string updateStatement =
            "UPDATE consultant SET email = @email, staffID = @staffID WHERE consultantID = @consultantID;";

        private static readonly string selectWhereStaffID =
            "SELECT * FROM consultant INNER JOIN staff ON consultant.staffID = staff.staffID " +
            "WHERE consultant.staffID = @staffID;";

        /// <summary>
        /// Constructor. Instantiates staff class with values from parameters and sets email and staffId of consultant instance
        /// </summary>
        /// <param name="staffTypeId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        public Consultant(int staffTypeId, string username, string password, string email = null) 
        : base(staffTypeId, username, password)
        {
            Email = email;
            StaffID = base.Id;
        }

        public Consultant()
        {
        }

        public void SendEmail(Alarm alarm)
        {
            string notifaicationType = "Email";
            // Here there should be code to send SMS.
            //Then we write to file
            Staff.WriteNotificationToFile(alarm, StaffID, notifaicationType);
        }


        /// <summary>
        /// Inserts this instance as row into consultant table
        /// </summary>
        public new Nullable<int> Save()
        {
            Nullable<int> savedStaffID = base.Save();

            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@email", Email));
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
                command.Parameters.Add(new SqlParameter("@email", Email));
                command.Parameters.Add(new SqlParameter("@staffID", StaffID));
                command.Parameters.Add(new SqlParameter("@consultantID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

        public static Consultant GetOneFromStaffID(int staffID)
        {

            Consultant consultant = new Consultant();
            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStaffID);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@staffID", staffID));

            DataSet nurseDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable nurseDataTable = nurseDataSet.Tables[0];

            if (nurseDataTable.Rows.Count == 1)
            {
                DataRow nurseRow = nurseDataTable.Rows[0];

                consultant.Id = int.Parse(nurseRow["consultantID"].ToString());
                consultant.StaffID = int.Parse(nurseRow["staffID"].ToString());
                consultant.StaffTypeId = int.Parse(nurseRow["staffTypeID"].ToString());
                consultant.Username = nurseRow["username"].ToString();
                consultant.Password = nurseRow["password"].ToString();
                consultant.Email = nurseRow["email"].ToString();

                consultant.StaffID = int.Parse(nurseRow["staffID"].ToString());
            }

            return consultant;
        }
    }
}
