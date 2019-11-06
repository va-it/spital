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
        private static readonly string insertStatement = "INSERT INTO nurse (phoneNumber, staffID) VALUES (@phoneNumber, @staffID)";

        public Nurse(int staffTypeId, string username, string password, string phoneNumber = null) 
        : base(staffTypeId, username, password)
        {
            PhoneNumber = phoneNumber;
            StaffID = base.Id;
        }

        public new void Save()
        {
            base.Save();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("phoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("staffID", base.Id));

                DatabaseConnection.Instance.ExectuteInsert(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
