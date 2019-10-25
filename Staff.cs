using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Staff
    {
        // Auto-implemented properties for trivial get and set
        public int Id { get; set; }
        public int StaffTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }

        /// <summary>
        /// Constructor. Sets Id automatically and values from parameters
        /// </summary>
        /// <param name="staffType"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="mobileNumber"></param>
        public Staff(
            int staffType, string username, string password, 
            string firstName, string middleName, string lastName,
            string email = "", string mobileNumber = ""
            )
        {
            Id = 1;
            StaffTypeId = staffType;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            MobileNumber = mobileNumber;

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



    }
}
