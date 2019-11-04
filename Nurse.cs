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
            int staffType, string username, string password,
            string firstName, string middleName, string lastName,
            string mobileNumber
            ) : base(staffType, username, password, firstName, middleName, lastName)
        {
            MobileNumber = mobileNumber;
        }
    }
}
