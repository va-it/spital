﻿using spital.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spital
{
    class MonitorModule
    {
        // Auto-implemented properties for trivial get and set
        private int Id { get; }
        public Monitor Monitor { get; set; }
        public Module Module { get; set; }
        public int AssignedMin { get; set; }
        public int AssignedMax { get; set; }


        private static readonly string selectStatement = "SELECT * FROM monitorModule";
        private static readonly string insertStatement = 
        "INSERT INTO monitorModule(monitorID,moduleID,assignedMax,assignedMin) VALUES (@monitorID,@moduleID,@assignedMax,@assignedMin)";
        
        /// <summary>
        /// Constructor. Sets value of Id and defines monitor and module from parameters
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="module"></param>
        public MonitorModule(Monitor monitor, Module module)
        {
            Id = 1;
            Monitor = monitor;
            Module = module;
        }

        /// <summary>
        /// Triggers an alarm for this monitor and module pair.
        /// </summary>
        public void TriggerAlarm()
        {
            Alarm alarm = new Alarm(this);
        }

        public static DataTable GetAll()
        {
            DataSet monitorModuleDataSet = DatabaseConnection.Instance.GetDataSet(selectStatement);
            DataTable monitorModuleDataTable = monitorModuleDataSet.Tables[0];
            return monitorModuleDataTable;
        }
    }
}
