﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class Session
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; set; }
        private DateTime DateTimeStart { get; set; }
        private DateTime DateTimeEnd { get; set; }

        /// <summary>
        /// Constructor. Sets Id and DateTimeStart
        /// </summary>
        public Session()
        {
            Id = 1;
            DateTimeStart = DateTime.Now;
        }

        /// <summary>
        /// Sets DateTimeEnd value to the current date and time.
        /// </summary>
        public void End()
        {
            DateTimeEnd = DateTime.Now;
        }
    }
}
