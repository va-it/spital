﻿using System;
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
    public partial class ModulesForm : Form
    {
        public ModulesForm()
        {
            InitializeComponent();
        }

        private void modulesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form limits = new LimitsForm();
            limits.Show();
        }
    }
}
