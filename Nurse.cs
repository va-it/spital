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
    class Nurse : Staff
    {
        public int Id { get; }
        public string PhoneNumber { get; set; }
        public int StaffID { get; set; }

        private static readonly string selectStatement = "SELECT * FROM nurse";

        private static readonly string insertStatement = 
            "INSERT INTO nurse (phoneNumber, staffID) VALUES (@phoneNumber, @staffID)";

        private new static readonly string updateStatement =
            "UPDATE nurse SET phoneNumber = @phoneNumber, staffID = @staffID WHERE nurseID = @nurseID";


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
        /// Inserts this instance as row into nurse table
        /// </summary>
        public new void Save()
        {
            base.Save();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("phoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("staffID", base.Id));

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
        public new void Update()
        {
            base.Update();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.AddWithValue("@phoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@staffID", StaffID);
                command.Parameters.AddWithValue("@nurseID", Id);

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
