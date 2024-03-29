﻿using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class StaffType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static readonly string selectStatement = "SELECT * FROM staffType";
        private static readonly string insertStatement = "INSERT INTO staffType (name) VALUES (@name)";

        /// <summary>
        /// Constructor, Instantiates the class with Name from parameter
        /// </summary>
        /// <param name="name"></param>
        public StaffType(string name = null)
        {
            Name = name;
        }

        /// <summary>
        /// Retrieves all records from database
        /// </summary>
        /// <returns>List of all staffTypes in database</returns>
        public static List<StaffType> GetAll()
        {
            DataSet staffTypesDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable staffTypeTable = staffTypesDataSet.Tables[0];

            List<StaffType> staffTypes = new List<StaffType>();

            foreach (DataRow row in staffTypeTable.Rows)
            {
                StaffType staffType = new StaffType
                {
                    Id = (int)row["staffTypeID"],
                    Name = row["name"].ToString()
                };

                staffTypes.Add(staffType);
            }

            return staffTypes;
        }
    }
}
