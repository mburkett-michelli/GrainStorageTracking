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
    public partial class frmEditAddCommodities : Form
    {
        Seed_Storage_Dataset.CommoditiesRow  CommoditiesRow;
        public string NewName;

        public frmEditAddCommodities(Seed_Storage_Dataset.CommoditiesRow CommoditiesRow)
        {
            InitializeComponent();
            this.CommoditiesRow = CommoditiesRow;
            if (this.CommoditiesRow != null)
            {
                this.txtCommodity.Text = this.CommoditiesRow.Commodity ;
                this.lblPrompt.Text = "Edit " + this.CommoditiesRow.Commodity;
            }
            else
            {
                this.lblPrompt.Text = "Add New Commodity";
            }
        }




        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCommodity.Text))
            {
                Alert.Show("Commodity Name Cannot Be Empty");
            }
            else
            {
                if (this.CommoditiesRow != null)
                {

                    if (commoditiesTableAdapter.FillByChangingExistingName(this.seed_Storage_Dataset.Commodities , CommoditiesRow.UID, this.txtCommodity.Text) > 0)
                    {
                        Alert.Show("Commodity " + this.txtCommodity.Text + " Already Exists");

                    }

                    else
                    {
                        commoditiesTableAdapter.FillByCommodity(this.seed_Storage_Dataset.Commodities, CommoditiesRow.Commodity);
                        Seed_Storage_Dataset.CommoditiesRow row = seed_Storage_Dataset.Commodities[0];

                        row.Commodity  = this.txtCommodity.Text;
                        NewName = this.txtCommodity.Text;

                        this.commoditiesTableAdapter.Update(seed_Storage_Dataset);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }

                else

                {
                    if (commoditiesTableAdapter.FillByCommodity(this.seed_Storage_Dataset.Commodities, this.txtCommodity.Text) > 0)
                    {
                        Alert.Show("Commodity " + this.txtCommodity.Text + " Already Exists");

                    }
                    else
                    {
                        Seed_Storage_Dataset.CommoditiesRow  row = seed_Storage_Dataset.Commodities.NewCommoditiesRow();
                        row.UID = Guid.NewGuid();
                        row.Commodity = this.txtCommodity.Text;
                        row.Active = true;
                        row.Pounds_Per_Bushel = 60;
                        this.seed_Storage_Dataset.Commodities.AddCommoditiesRow(row);
                        NewName = this.txtCommodity.Text;
                        this.commoditiesTableAdapter.Update(seed_Storage_Dataset);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }


                }
            }
        }

    
        private void EditAddCommodities_Load(object sender, EventArgs e)
        {
       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
