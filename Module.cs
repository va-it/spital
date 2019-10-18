using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Module
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// Constructor. Sets Id, name, icon, min and max values based on values from database
        /// </summary>
        public Module()
        {
            Id = 1;
            Name = "Heart Rate";
            Icon = "heart_rate.png";
            Min = 80;
            Max = 180;
        }
    }
}
