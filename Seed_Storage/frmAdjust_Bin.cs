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
    public partial class frmAdjust_Bin : Form
    {
        public frmAdjust_Bin(string Bin)
        {
            InitializeComponent();

            this.binsTableAdapter.FillByDescription(this.seed_Storage_Dataset.Bins,Bin);
            this.binsBindingSource.MoveFirst();
        }

        private void frmAdjust_Bin_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.binsBindingSource.EndEdit();
                this.binsTableAdapter.Update(seed_Storage_Dataset);
                this.DialogResult = DialogResult.OK  ;
                this.Close();
            }
            catch (Exception ex)
            {
                Alert.Show("Error Adjusting Bin " + ex.Message);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void capacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numCapacity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numStartingBushels_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblStartBushels_Click(object sender, EventArgs e)
        {

        }
    }
}
