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
    public partial class frmSetupOptions : Form
    {
        public frmSetupOptions()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (frmBins frm = new frmBins())
            {
                frm.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (frmSetup frm = new frmSetup())
            {
                frm.ShowDialog();  
                Program.Restart = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmSelectVarieties frm = new frmSelectVarieties(false))
            {
                frm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (frmCustomers frm = new frmCustomers())
            {
                frm.ShowDialog();
            }
        }
    }
}
