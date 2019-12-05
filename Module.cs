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
    public class Module
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public float DefaultMin { get; set; }
        public float DefaultMax { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement = "SELECT * FROM module;";

        private static readonly string selectWhereStatement = "SELECT * FROM module WHERE moduleID = @moduleID;";

        private static readonly string insertStatement = 
            "INSERT INTO module (name, icon, defaultMin, defaultMax) " + 
            "VALUES (@name, @icon, @defaultMin, @defaultMax);";

        private static readonly string updateStatement = 
            "UPDATE module SET name = @name, icon = @icon, defaultMin = @defaultMin, " +
            "defaultMax = @defaultMax WHERE moduleID = @moduleID;";

        public Module() { }

        /// <summary>
        /// Constructor. Sets name, icon, min and max values based on values from database
        /// </summary>
        public Module(Nullable<int> id)
        {
            SqlDataAdapter sqlDataAdapter = DatabaseConnection.Instance.GetSqlAdapter(selectWhereStatement);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@moduleID", id));

            DataSet moduleDataSet = DatabaseConnection.Instance.ExecuteSelect(sqlDataAdapter);

            DataTable moduleDataTable = moduleDataSet.Tables[0];

            if (moduleDataTable.Rows.Count == 1)
            {
                DataRow row = moduleDataTable.Rows[0];

                Id = Int32.Parse(row["moduleID"].ToString());
                Name = row["name"].ToString();
                Icon = row["icon"].ToString();
                DefaultMin = float.Parse(row["defaultMin"].ToString());
                DefaultMax = float.Parse(row["defaultMax"].ToString());
            }
        }

        /// <summary>
        /// Assigns parameters to module limits.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void AssignLimits(float min, float max)
        {
            DefaultMin = min;
            DefaultMax = max;
        }

        /// <summary>
        /// Returns a DataTable object of all Modules
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAll()
        {
            DataSet moduleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable moduleDataTable = moduleDataSet.Tables[0];

            return moduleDataTable;
        }

        /// <summary>
        /// Retrieve one Module from the database based on its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Module</returns>
        public static Module GetOne(Nullable<int> id)
        {
            Module module = new Module(id);

            return module;
        }

        /// <summary>
        /// Inserts this instance as row into module table
        /// </summary>
        public Nullable<int> Save()
        {
            Nullable<int> lastInsertedID = null;

            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement;
                command.Parameters.Add(new SqlParameter("@name", Name));
                command.Parameters.Add(new SqlParameter("@icon", Icon));
                command.Parameters.Add(new SqlParameter("@defaultMin", DefaultMin));
                command.Parameters.Add(new SqlParameter("@defaultMax", DefaultMax));

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
                command.Parameters.Add(new SqlParameter("@name", Name));
                command.Parameters.Add(new SqlParameter("@icon", Icon));
                command.Parameters.Add(new SqlParameter("@defaultMin", DefaultMin));
                command.Parameters.Add(new SqlParameter("@defaultMax", DefaultMax));
                command.Parameters.Add(new SqlParameter("@moduleID", Id));

                DatabaseConnection.Instance.ExecuteCommand(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
        }

    }
}
