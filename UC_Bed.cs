using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spital
{
    public partial class UC_Bed : UserControl
    {
        public UC_Bed()
        {
            InitializeComponent();
        }

        public string BedNumber
        {
            get { return label_BedNumber.Text; }
            set { label_BedNumber.Text = value; }
        }

    }
}
