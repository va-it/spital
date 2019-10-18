using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Module
    {
        private int Id { get; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Module()
        {
            this.Id = 1;
            this.Name = "Heart Rate";
            this.Icon = "heart_rate.png";
            this.Min = 80;
            this.Max = 180;
        }
    }
}
