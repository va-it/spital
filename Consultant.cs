using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Consultant : Staff
    {
        public string Email { get; set; }

        public Consultant(
            int staffType, string username, string password,
            string firstName, string middleName, string lastName,
            string email
            ) : base(staffType, username, password, firstName, middleName, lastName)
        {
            Email = email;
        }
    }
}
