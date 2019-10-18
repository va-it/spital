using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Monitor
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; }
        public bool Active { get; set; }

        /// <summary>
        /// Constructor. Sets Id and active flag
        /// </summary>
        public Monitor()
        {
            Id = 1;
            Active = true;            
        }
    }
}
