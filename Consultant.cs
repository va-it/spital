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
            int staffTypeId, string username, string password,
            string firstName = null, string middleName = null, string lastName = null,
            string email = null
            ) : base(staffTypeId, username, password, firstName, middleName, lastName)
        {
            Email = email;
        }
    }
}
