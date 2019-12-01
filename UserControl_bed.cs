using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using spital.Properties;

namespace spital
{
    //[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserControl_bed : UserControl
    {
        public UserControl_bed()
        {
            InitializeComponent();
        }

        //Monitor monitor = new Monitor();
        //MonitorForm monitorForm = new MonitorForm();

        public string BedNumber
        {
            get { return label_bednumber.Text; }
            set { label_bednumber.Text = value; }
        }

        public string Alert
        {
            get { return label_alertmsg.Text; }
            set { label_alertmsg.Text = value; }
        } 
        
        public string MonitorID
        {
            get { return hiddenLabel_MonitorID.Text; }
            set { hiddenLabel_MonitorID.Text = value; }
        }

        public Image AlertPictureBox
        {
            get { return pictureBox_alert.Image; }
            set { pictureBox_alert.Image = value; }
        }

        public void MarkBedAsActive()
        {
            pictureBox_bed.BackColor = Color.Chartreuse;
        }

        private void button_mute_Click(object sender, EventArgs e)
        {
            AlertPictureBox = null;
            Alert = "";
        }
    }
}
