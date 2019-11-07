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
        private int Id { get; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public float DefaultMin { get; set; }
        public float DefaultMax { get; set; }

        //Generic SELECT and INSERT Statement for module table 
        private static readonly string selectStatement = "SELECT * FROM module";
        private static readonly string insertStatement = "INSERT INTO module (moduleID, name, defaultMin, defaultMax)" + "VALUES (@moduleID, @name, @defaultMin, @defaultMax)";

        /// <summary>
        /// Constructor. Sets Id, name, icon, min and max values based on values from database
        /// </summary>
        public Module()
        {
            Id = 1;
            Name = "Heart Rate";
            Icon = "heart_rate.png";
            DefaultMin = 80;
            DefaultMax = 180;
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
