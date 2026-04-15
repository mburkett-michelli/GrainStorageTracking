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
    public partial class frmEditVariety : Form
    {
        Seed_Storage_Dataset.VarietiesRow VarietiesRow;
        public string NewName;

        public frmEditVariety(Seed_Storage_Dataset.VarietiesRow SelectedVarietiesRow)
        {
            InitializeComponent();
            VarietiesRow = SelectedVarietiesRow;
            this.varietyTextBox.Text = VarietiesRow.Variety; 
            
        }

      

        private void EditVariety_Load(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.varietyTextBox.Text))
            {
                Alert.Show("Variety Name Cannot Be Blank", frmAlert.enumButtonStyle.OkOnly);
            }
            else
            {
                if (varietiesTableAdapter.FillByChangingExistingName(seed_Storage_Dataset.Varieties, VarietiesRow.UID, this.varietyTextBox.Text) > 0)
                {
                    Alert.Show("Variety " + varietyTextBox.Text + " Already Exists", frmAlert.enumButtonStyle.OkOnly);
                }
                else
                {
                    try
                    {
                        using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                        {
                            Q.UpdateVarietyName(VarietiesRow.Variety, this.varietyTextBox.Text);
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
