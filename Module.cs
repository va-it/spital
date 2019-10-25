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
        public int DefaultMin { get; set; }
        public int DefaultMax { get; set; }

        /// <summary>
        /// Constructor. Sets Id, name, icon, min and max values based on values from database
        /// </summary>
        public Module()
        {
            Id = 1;
            Name = "Heart Rate";
            Icon = "heart_rate.png";
            DefaultMin = 80;
            DefaultMax = 180;
        }

        /// <summary>
        /// Assigns parameters to module limits.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void AssignLimit(int min, int max)
        {
            DefaultMin = min;
            DefaultMax = max;
        }
    }
}
