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
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form limits = new Limits();
            limits.Show();
        }
    }
}
