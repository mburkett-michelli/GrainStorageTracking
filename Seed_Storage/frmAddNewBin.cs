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
    public partial class frmAddNewBin : Form
    {


        public string NewName;
        public frmAddNewBin()
        {
            InitializeComponent();
            this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);

            this.dtStartDate.Value = DateTime.Now;
            this.varietiesBindingSource.MoveFirst(); 
        }

     

        private void frmAddNewBin_Load(object sender, EventArgs e)
        {

            this.varietiesListTableAdapter.Fill(this.seed_Storage_Dataset.VarietiesList);

        }

        private void capacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.binTextBox.Text))
            {
                Alert.Show("Bin Name Cannot Be Blank", frmAlert.enumButtonStyle.OkOnly);
            }
            if (string.IsNullOrEmpty(this.cboVariety.Text))
            {
                Alert.Show("Variety Cannot Be Blank", frmAlert.enumButtonStyle.OkOnly);
            }
            else if (this.numCapacity.Value <=0)
            {

                Alert.Show("Capacity Cannot Be Zero", frmAlert.enumButtonStyle.OkOnly);
            }

            else if (this.numCapacity.Value < this.numStartingBushels.Value  )
            {

                Alert.Show("You Cannot Have More Starting Bushels Than Bin Capacity", frmAlert.enumButtonStyle.OkOnly);
            }
            else
            {
                if (binsTableAdapter.FillByDescription(this.seed_Storage_Dataset.Bins,this.binTextBox.Text )>0)
                {
                    Alert.Show("Bin "+this.binTextBox.Text +" Already Exists", frmAlert.enumButtonStyle.OkOnly);
                }
                else
                {
                    try
                    {
                        
                        int Capacity = (int)numCapacity.Value; 
                        int StartBushels = (int)numStartingBushels.Value;
                        DateTime StartTime =DateTime.Parse( this.dtStartDate.Value.ToShortDateString() +" 12:00:00 AM" ) ;

                        
                        Seed_Storage_Dataset.BinsRow row = seed_Storage_Dataset.Bins.NewBinsRow();
                        row.UID = Guid.NewGuid();
                        row.Bin = this.binTextBox.Text;
                        row.Variety = this.cboVariety.Text;
                        row.Use_For_Inbound_Loads = this.use_For_Inbound_LoadsCheckBox.Checked;
                        row.Capacity = Capacity;
                        row.Starting_Bushels = StartBushels;
                        row.Starting_Time = StartTime;
                        this.seed_Storage_Dataset.Bins.AddBinsRow(row);
                        this.binsTableAdapter.Update(this.seed_Storage_Dataset);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Alert.Show("Error Creating Bin " + ex.Message);

                    }


                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

      
    }
}
