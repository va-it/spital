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
    class Consultant : Staff
    {
        public int Id { get; }
        public string Email { get; set; }
        public int StaffID { get; set; }

        private static readonly string selectStatement = "SELECT * FROM consultant";

        private static readonly string insertStatement = "INSERT INTO nurse (email, staffID) VALUES (@email, @staffID)";

        private new static readonly string updateStatement =
            "UPDATE consultant SET email = @email, staffID = @staffID WHERE consultantID = @consultantID";

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

        /// <summary>
        /// Inserts this instance as row into consultant table
        /// </summary>
        public new void Save()
        {
            base.Save();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@email", Email));
                command.Parameters.Add(new SqlParameter("@staffID", base.Id));

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
    }
}
