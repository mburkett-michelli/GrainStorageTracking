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
    public partial class frmEditBin : Form
    {
        Seed_Storage_Dataset.BinsRow BinsRow;
        public string NewName;

        public frmEditBin(Seed_Storage_Dataset.BinsRow SelectedBinsRow)
        {
            InitializeComponent();
            BinsRow = SelectedBinsRow;
            this.binTextBox.Text = SelectedBinsRow.Bin; 
        }

 
        private void frmEditBin_Load(object sender, EventArgs e)
        {
            


        }
        




        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.binTextBox.Text))
            {
                Alert.Show("Bin Name Cannot Be Blank", frmAlert.enumButtonStyle.OkOnly);
            }
            else
            {
                if (binsTableAdapter.FillByChangingExistingName(seed_Storage_Dataset.Bins, BinsRow.UID, this.binTextBox.Text) > 0)
                {
                    Alert.Show("Bin " + binTextBox.Text + " Already Exists", frmAlert.enumButtonStyle.OkOnly);
                }
                else
                {
                    try
                    {
                        using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                        {
                            Q.UpdateBinName(BinsRow.Bin , this.binTextBox.Text);
                            this.NewName = this.binTextBox.Text;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        Alert.Show("Could Not Update Name" + ex.Message, frmAlert.enumButtonStyle.OkOnly);
                    }

                }

            }
        }
    }
}
