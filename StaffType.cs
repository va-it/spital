using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class StaffType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public StaffType(string description)
        {
            Id = 1;
            Description = description;
        }
    }
}
