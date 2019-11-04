using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    abstract class Staff
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public int StaffTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Constructor. Sets Id automatically and values from parameters
        /// </summary>
        /// <param name="staffType"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        public Staff(
            int staffType, string username, string password, 
            string firstName, string middleName, string lastName
            )
        {
            Id = 1;
            StaffTypeId = staffType;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;

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

        public void ValidateCredentials(string username, string password)
        {
            // Retrieve values from DB and validate
            /* 
             * Note, need to compare encrypted version of password
             * so the passed password needs to be encrypted first
             */
            
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


    }
}
