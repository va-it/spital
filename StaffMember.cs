using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    abstract class StaffMember
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; set;  }
        private string EncryptionPassword { get; set; }
        private string Password { get; set; }
        private string Storage { get; set; }
        private string Username { get; set; }
        private Session Session { get; set; }


        /// <summary>
        /// Constructor. Sets Id, EncryptionPassword and Storage.
        /// </summary>
        public StaffMember()
        {
            Id = 1;
            EncryptionPassword = "AAA";
            Storage = "BBB";
            
        }

        /// <summary>
        /// Sets and saves Username and Password based on parameter.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void SaveCredentials(string username, string password)
        {
            Username = username;
            Password = password;

            // Save in DB
        }

        /// <summary>
        /// Validate parameters against values in database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateCredentials(string username, string password)
        {
            // Compare username and password with values in DB
            bool comparison = true;

            return comparison;
        }


        /// <summary>
        /// Logs in the staff member, assigns and starts a sessions.
        /// </summary>
        public void Register()
        {
            Login();

            // Assign session to this staff member.
            Session.StaffMemberId = Id;

            // Start session
            Session.Start();

            // Save session in DB
        }

        /// <summary>
        /// Ends the current session for this staff member.
        /// </summary>
        public void DeRegister()
        {
            // End session by assigning current date and time to DateTimeEnd
            Session.End();
        }

        /// <summary>
        /// Authenticates the staff member.
        /// </summary>
        public void Login()
        {
            // Authenticate user 
        }

    }
}
