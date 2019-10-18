using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Monitor
    {
        private int Id { get; }
        public List<Module> Modules { get; set; }

        public Monitor(Module[] modules)
        {
            this.Id = 1;

            foreach (Module module in modules)
            {
                this.Modules.Add(module);
            }
            
        }
    }
}
