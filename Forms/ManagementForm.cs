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
            GetAlarms();
            GetSessions();
        }

        /// <summary>
        /// Populates Alarms_Datagrid with all alarm records from database
        /// </summary>
        public void GetAlarms()
        {
            DataTable alarmTable = Alarm.GetAll();
            Alarms_DataGrid.DataSource = alarmTable;
        }

        /// <summary>
        /// Populates Sessions_Datagrid with all session records from database
        /// </summary>
        public void GetSessions()
        {
            DataTable sessionTable = Session.GetAll();
            Sessions_DataGrid.DataSource = sessionTable;
        }
    }
}
