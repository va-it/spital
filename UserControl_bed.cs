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

namespace spital
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserControl_bed : UserControl
    {
        public UserControl_bed()
        {
            InitializeComponent();
        }

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

    }
}
