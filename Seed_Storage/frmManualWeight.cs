using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seed_Storage
{
    public partial class frmManualWeight : Form
    {
        public int Weight;

        public frmManualWeight(int CurrentWeight)
        {
            
            InitializeComponent();
            this.numericUpDown1.Value = CurrentWeight;
            this.numericUpDown1.Focus();
            this.numericUpDown1.Select(0, 100);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Weight = (int)this.numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
