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
    class Module
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public float DefaultMin { get; set; }
        public float DefaultMax { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement = "SELECT * FROM module";

        private static readonly string insertStatement = 
            "INSERT INTO module (moduleID, name, defaultMin, defaultMax)" + 
            "VALUES (@moduleID, @name, @defaultMin, @defaultMax)";

        private static readonly string updateStatement = 
            "UPDATE module SET name = @name, icon = @icon, defaultMin = @defaultMin, " +
            "defaultMax = @defaultMax WHERE moduleID = @moduleID";

        /// <summary>
        /// Constructor. Sets name, icon, min and max values based on values from database
        /// </summary>
        public Module(int id)
        {
            /*
             * WE MAY WANT TO CHANGE THIS SO THAT WE DON'T HAVE TO
             * TO RETRIEVE ALL THE VALUES IN THE FUTURE BUT ADD A WHERE CLAUSE TO
             * THE INSERT STATEMENT
             */

            DataSet dataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable moduleTable = dataSet.Tables[0];

            foreach (DataRow row in moduleTable.Rows)
            {
                if (Int32.Parse(row["moduleID"].ToString()) == id)
                {
                    Id = id;
                    Name = row["name"].ToString();
                    DefaultMin = float.Parse(row["defaultMax"].ToString());
                    DefaultMax = float.Parse(row["defaultMax"].ToString());
                }
            }
        }

        /// <summary>
        /// Assigns parameters to module limits.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void AssignLimit(int min, int max)
        {
            DefaultMin = min;
            DefaultMax = max;
        }

        /// <summary>
        /// Inserts this instance as row into module table
        /// </summary>
        public void Save()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("moduleID", Id));
                command.Parameters.Add(new SqlParameter("name", Name));
                command.Parameters.Add(new SqlParameter("icon", Icon));
                command.Parameters.Add(new SqlParameter("defautMin", DefaultMin));
                command.Parameters.Add(new SqlParameter("defaultMax", DefaultMax));

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
        public void Update()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = updateStatement;
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@icon", Icon);
                command.Parameters.AddWithValue("@defaultMin", DefaultMin);
                command.Parameters.AddWithValue("@defaultMax", DefaultMax);
                command.Parameters.AddWithValue("@moduleID", Id);

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

    }
}
