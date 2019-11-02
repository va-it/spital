using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Nurse : Staff
    {
        public string MobileNumber { get; set; }

        public Nurse(
            int staffTypeId, string username, string password,
            string firstName = null, string middleName = null, string lastName = null,
            string mobileNumber = null
            ) : base(staffTypeId, username, password, firstName, middleName, lastName)
        {
            MobileNumber = mobileNumber;
        }
    }
}
