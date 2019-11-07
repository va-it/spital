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
        public int ModuleID { get; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public float DefaultMin { get; set; }
        public float DefaultMax { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement = "SELECT * FROM module";
        private static readonly string insertStatement = "INSERT INTO module (moduleID, name, defaultMin, defaultMax)" + "VALUES (@moduleID, @name, @defaultMin, @defaultMax)";

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
                    ModuleID = id;
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
        public void AssignLimit(float min, float max)
        {
            DefaultMin = min;
            DefaultMax = max;
        }

        /*
         * METHODS
         */

        // to get data from module table in database 
        public static DataTable GetAll()
        {
            DataSet dataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable moduleTable = dataSet.Tables[0];
            return moduleTable;
        }
    }
}
