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
    class Nurse : Staff
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int StaffID { get; set; }

        private static readonly string selectStatement = "SELECT * FROM nurse;";

        private static readonly string selectWhereStatement = "SELECT * FROM nurse WHERE nurseID = @nurseID;";

        private static readonly string insertStatement = 
            "INSERT INTO nurse (phoneNumber, staffID) VALUES (@phoneNumber, @staffID);";

        private new static readonly string updateStatement =
            "UPDATE nurse SET phoneNumber = @phoneNumber, staffID = @staffID WHERE nurseID = @nurseID;";

        private Nurse() { }


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

        

        // WIP CODE
        public static Nurse GetOne(int id)
        {
            Nurse nurse = new Nurse();

            SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();
            command.CommandText = selectWhereStatement;
            command.Parameters.Add(new SqlParameter("@nurseID", id));

            DataSet nurseDataSet = DatabaseConnection.Instance.GetDataSet(selectWhereStatement);
            DataTable nurseDataTable = nurseDataSet.Tables[0];

            if (nurseDataTable.Rows.Count == 1)
            {
                DataRow row = nurseDataTable.Rows[0];

                // Only one record has been retrieved
                nurse.Id = Int32.Parse(row["nurseID"].ToString());
                nurse.PhoneNumber = row["phoneNumber"].ToString();
            }

            return nurse;
        }

        /// <summary>
        /// Inserts this instance as row into nurse table
        /// </summary>
        public new Nullable<int> Save()
        {
            base.Save();

            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@phoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@staffID", base.Id));

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
    }
}
