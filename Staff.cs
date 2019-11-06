﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spital.Properties;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace spital
{
    abstract class Staff
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public int StaffTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }

        private static readonly string encryptionPassword = "7689iknh7564fbg6ghjgbt6";

        private static readonly string selectStatement = "SELECT * FROM staff";
        private static readonly string insertStatement = 
            "INSERT INTO staff (staffTypeID, username, password, email, mobileNumber) " +
            "VALUES (@staffTypeID, @username, @password, @email, @mobileNumber)";

        /// <summary>
        /// Constructor. Sets Id automatically and values from parameters
        /// </summary>
        /// <param name="staffType"></param>
        public Staff(int staffType, string username, string password)
        {
            Id = 1;
            StaffTypeId = staffType;
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Saves username and password values in database based on parameters
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void SaveCredentials(string username, string password)
        {
            Username = username;
            Password = password;

            // Save to DB
        }

        public static bool ValidateCredentials(string username, string password)
        {
            // Retrieve values from DB and validate
            /* 
             * Note, need to compare encrypted version of password
             * so the passed password needs to be encrypted first
             */

            bool valid = false;

            DataSet staffDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);

            DataTable staffDataTable = staffDataSet.Tables[0];

            foreach (DataRow row in staffDataTable.Rows)
            {
                if (String.Equals(username, row["username"].ToString()))
                {
                    string comparePassword = Encryption.DecryptText(row["password"].ToString(), encryptionPassword);

                    if (String.Equals(password, comparePassword))
                    {
                        // Credentials match
                        valid = true;
                    }
                }
            }

            return valid;
        }
        /// <summary>
        /// Triggers authentication and, upon success, starts session
        /// </summary>
        public void Register()
        {
            // trigger authentication and, upon success, start session
        }

        /// <summary>
        /// Triggers authentication and, upon success, ends active session
        /// </summary>
        public void DeRegister()
        {
            // trigger authentication and, upon success, end session
        }

        /// <summary>
        /// Authentication trigger
        /// </summary>
        public void Login()
        {
            // Authentication trigger
        }

        public void Notify()
        {
            switch (StaffTypeId)
            {
                case 1:
                    // Nurse, notify via SMS/Pager
                    break;
                case 2:
                    // Consultant, notify via email
                    break;
                default:
                    // No type matched.
                    break;
            }

        }

        public void Save()
        {
            try
            {
                SqlCommand command = DatabaseConnection.Instance.GetSqlCommand();

                command.CommandText = insertStatement; //set the sql query
                command.Parameters.Add(new SqlParameter("staffTypeID", StaffTypeId));
                command.Parameters.Add(new SqlParameter("username", Username));
                command.Parameters.Add(new SqlParameter("password", Password));
                command.Parameters.Add(new SqlParameter("email", Email));
                command.Parameters.Add(new SqlParameter("mobileNumber", MobileNumber));

                DatabaseConnection.Instance.ExectuteInsert(command);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! Message: " + error.Message + ". Please try again.", "Error");
            }
            
        }


    }
}
