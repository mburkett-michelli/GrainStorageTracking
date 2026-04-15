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
    public partial class frmBinInventory : Form
    {
        public frmBinInventory()
        {
            InitializeComponent();
        }

        private void frmBinInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seed_Storage_Dataset.vw_Inventory' table. You can move, or remove it, as needed.
            this.vw_InventoryTableAdapter.Fill(this.seed_Storage_Dataset.vw_Inventory);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex== this.btnAdjust.Index )
            {

                using (frmPassword frm = new frmPassword())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Seed_Storage_Dataset.vw_InventoryRow SelectedRow;
                        SelectedRow = (Seed_Storage_Dataset.vw_InventoryRow)(DataRow)((DataRowView)this.vwInventoryBindingSource.Current).Row;
                        using (frmAdjust_Bin frmAdjust = new frmAdjust_Bin(SelectedRow.Bin_Description))
                        {
                            frmAdjust.ShowDialog();
                            this.vw_InventoryTableAdapter.Fill(this.seed_Storage_Dataset.vw_Inventory);

                        }
                    }

                }













            }
        }
    }
}
