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
        public string PhoneNumber { get; set; }

        private static readonly string selectStatement = "SELECT * FROM nurse";
        private static readonly string insertStatement = "INSERT INTO nurse (phoneNumber) VALUES (@phoneNumber)";

        public Nurse(int staffTypeId, string username, string password, string phoneNumber = null) 
        : base(staffTypeId, username, password)
        {
            PhoneNumber = phoneNumber;
        }

        public new void Save()
        {
            base.Save();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("phoneNumber", PhoneNumber));

                DatabaseConnection.Instance.ExectuteInsert(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
