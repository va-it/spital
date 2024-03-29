﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace spital
{
    public partial class MonitorForm : Form
    {
        static Timer myTimer = new System.Windows.Forms.Timer();

        List<MonitorModule> monitorModules = new List<MonitorModule>();
        public List<Alarm> alarms = new List<Alarm>();
        List<Label> moduleName = new List<Label>();
        List<PictureBox> modulesIcon = new List<PictureBox>();
        List<Label> moduleReading = new List<Label>();
        List<Label> limitMin = new List<Label>();
        List<Label> limitMax = new List<Label>();
        List<String> alarmMessage = new List<string>();

        Monitor monitor = new Monitor();

        public int MonitorId { get; set; }
        public bool Active { get; set; }
        public bool HasAlarms { get; set; }

        public MonitorForm()
        {
            InitializeComponent();
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            // Code to stop the alarm
            MessageBox.Show("Alarm has been stopped", "Alarm stopped");
            StopAlarms();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            // Instiate ModulesForm and display
            Form modules = new ModulesForm(this);
            modules.Show();
        }

        private void limitsButton_Click(object sender, EventArgs e)
        {
            // Code to edit the modules limits
            Form limits = new LimitsForm(this);
            limits.Show();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            monitor.Id = MonitorId;

            GenerateListsOfControls();

            // Check if we already a monitor with this ID
            Monitor newMonitor = Monitor.GetOne(MonitorId);

            if (newMonitor.Id == 0)
            {
                monitor.Save();
            }      
            
            monitorNumber.Text = MonitorId.ToString();
        }

        private void MonitorForm_Shown(object sender, EventArgs e)
        {
            RefreshModules();
        }

        /// <summary>
        /// Populates Lists with controls from Form
        /// </summary>
        private void GenerateListsOfControls()
        {
            moduleName.Add(moduleName1);
            moduleName.Add(moduleName2);
            moduleName.Add(moduleName3);
            moduleName.Add(moduleName4);

            modulesIcon.Add(moduleIcon1);
            modulesIcon.Add(moduleIcon2);
            modulesIcon.Add(moduleIcon3);
            modulesIcon.Add(moduleIcon4);

            limitMin.Add(label_Module1Min);
            limitMin.Add(label_Module2Min);
            limitMin.Add(label_Module3Min);
            limitMin.Add(label_Module4Min);

            limitMax.Add(label_Module1Max);
            limitMax.Add(label_Module2Max);
            limitMax.Add(label_Module3Max);
            limitMax.Add(label_Module4Max);

            moduleReading.Add(label1reading);
            moduleReading.Add(label2reading);
            moduleReading.Add(label3reading);
            moduleReading.Add(label4reading);
        }

        /// <summary>
        /// Checks if any alarm is for a monitorModule with the passed ID
        /// </summary>
        /// <param name="monitorModuleId"></param>
        /// <returns>Boolean</returns>
        public bool CheckIfMonitorModuleHasAlarm(int monitorModuleId)
        {
            foreach (Alarm alarm in alarms)
            {
                if (alarm.MonitorModule.Id == monitorModuleId)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Generates random reading, and compares value with set limits
        /// </summary>
        public void CheckReadings()
        {
            int index = 0;
            bool hasAlarm = false;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                hasAlarm = CheckIfMonitorModuleHasAlarm(monitorModule.Id);
                HasAlarms = hasAlarm;

                if (!hasAlarm)
                {
                    float random = RandomGenerator.Instance.Generate(monitorModule.AssignedMin - 1, monitorModule.AssignedMax + 1);

                    //logic to get the readings one place after the decimal
                    string s = Convert.ToString(random);
                    for (int i = 0; i <= s.Length - 1; i++)
                    {
                        if (s[i] == '.')
                            moduleReading.ElementAt(index).Text = s.Substring(0, i + 2);
                    }

                    monitorModule.CheckReading(float.Parse(moduleReading.ElementAt(index).Text));
                }
                else
                {
                    foreach (Alarm alarm in alarms)
                    {
                        if (alarm.MonitorModule.Id == monitorModule.Id)
                        {
                            moduleReading.ElementAt(index).Text = alarm.Reading.ToString();
                        }
                    }

                    ShowAlarms();
                }

                ++index;
            }
        }

        /// <summary>
        /// Called every time the Timer() ticks
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            CheckReadings();

            alarms = monitor.GetActiveAlarms();

            ShowAlarms();

            myTimer.Enabled = true;

        }

        /// <summary>
        /// Retrieves monitorModules from database and sets min and max limit controls values
        /// </summary>
        public void GetMonitorModules()
        {
            monitorModules = MonitorModule.GetAllFromMonitor(MonitorId);

            int index = 0;

            foreach (MonitorModule monitorModule in monitorModules)
            {
                moduleName.ElementAt(index).Text = monitorModules.ElementAt(index).Module.Name;
                modulesIcon.ElementAt(index).ImageLocation = @"../../Resources/" + monitorModules.ElementAt(index).Module.Icon;
                limitMin.ElementAt(index).Text = Convert.ToString(monitorModules.ElementAt(index).AssignedMin);
                limitMax.ElementAt(index).Text = Convert.ToString(monitorModules.ElementAt(index).AssignedMax);

                ++index;
            }
        }

        /// <summary>
        /// Removes background from modules readings and promts
        /// Central Display to change bed background and hide alarm icon and message
        /// </summary>
        public void ResetAlarms()
        {
            foreach (Label reading in moduleReading)
            {
                reading.BackColor = Color.White;
            }

            AlarmTextBox.Text = "";

            HasAlarms = false;

            CentralDisplay.Instance.HideAlarms(this);
        }

        /// <summary>
        /// Empties all module names and limits before retrieving new values from database
        /// </summary>
        public void RefreshModules()
        {
            ClearControls();
            GetMonitorModules();
            Timer();
        }

        /// <summary>
        /// Timer function to generate random modules readings
        /// </summary>
        public void Timer()
        {
            CheckReadings();
            //Calls the event at the end of the elapsed time interval
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            //Sets the timer interval to 5 seconds.
            myTimer.Interval = 5000;
            myTimer.Start();
        }

        /// <summary>
        /// Removes values from all controls
        /// </summary>
        public void ClearControls()
        {
            foreach (Label label in moduleName)
            {
                label.Text = null;
            }

            foreach (PictureBox pictureBox in modulesIcon)
            {
                pictureBox.Image = null;
            }

            foreach (Label label in limitMin)
            {
                label.Text = null;
            }

            foreach (Label label in limitMax)
            {
                label.Text = null;
            }

            foreach (Label label in moduleReading)
            {
                label.Text = null;
                label.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Sets alarms messages and changes background of module readings
        /// </summary>
        public void ShowAlarms()
        {
            alarmMessage.Clear();

            alarms = monitor.GetActiveAlarms();

            for (int i = 0; i < moduleName.Count; ++i)
            {
                moduleReading.ElementAt(i).BackColor = Color.White;

                foreach (Alarm alarm in alarms)
                {
                    alarmMessage.Add(alarm.MonitorModule.Module.Name + " out of range");

                    AlarmTextBox.Text = string.Join(Environment.NewLine, alarmMessage.ToArray());

                    if (moduleName.ElementAt(i).Text == alarm.MonitorModule.Module.Name)
                    {
                        moduleReading.ElementAt(i).BackColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Stops alarms and resets readings background and alarms messages
        /// </summary>
        public void StopAlarms()
        {
            foreach (Alarm alarm in alarms)
            {
                alarm.Stop();
            }

            ResetAlarms();
        }
    }
}

   