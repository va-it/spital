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

        public Nurse(int staffTypeId, string username, string password, string mobileNumber = null) 
        : base(staffTypeId, username, password)
        {
            MobileNumber = mobileNumber;
        }
    }
}
