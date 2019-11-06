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
        public string Email { get; set; }

        private static readonly string selectStatement = "SELECT * FROM consultant";
        private static readonly string insertStatement = "INSERT INTO nurse (email) VALUES (@email)";

        public Consultant(int staffTypeId, string username, string password, string email = null) 
        : base(staffTypeId, username, password)
        {
            Email = email;
        }

        public new void Save()
        {
            base.Save();

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("email", Email));

                DatabaseConnection.Instance.ExectuteInsert(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }
    }
}
