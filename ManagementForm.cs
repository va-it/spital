using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
            FillAlarmReport();
            FillSessionReport();
        }


        public void FillAlarmReport()
        {
            DataTable alarmTable = Alarm.GetAll();
            AlarmReport_DataGrid.DataSource = alarmTable;
        }


        public void FillSessionReport()
        {
            DataTable sessionTable = Session.GetAll();
            SessionReport_DataGrid.DataSource = sessionTable;
        }
    }
}
