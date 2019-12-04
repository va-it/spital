using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spital;

namespace spitalTests
{
    [TestClass]
    public class MonitorTests
    {
        [TestMethod]
        public void Monitor_WithAlarms_GetsActiveAlarms()
        {
            Monitor monitor = new Monitor();
            monitor.Id = 1;
            monitor.Active = true;

            // fixtures
            List<Alarm> alarms = new List<Alarm>();
            Alarm alarm1 = new Alarm();
            alarm1.Id = 1;
            alarm1.MonitorModule = new MonitorModule();
            alarm1.MonitorModule.Monitor.Id = 1;
            alarm1.MonitorModule.Module.Id = 1;
            alarm1.MonitorModule.AssignedMin = 10.5F;
            alarm1.MonitorModule.AssignedMax = 20.5F;
            alarm1.StartDateTime = DateTime.Parse("2019/12/04 10:30:00 AM");

            alarms.Add(alarm1);

        }
    }
}
