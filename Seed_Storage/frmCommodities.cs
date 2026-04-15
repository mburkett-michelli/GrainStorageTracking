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
    public partial class frmCommodities : Form
    {
        public frmCommodities()
        {
            InitializeComponent();
        }

        private void Commodities_Load(object sender, EventArgs e)
        {
            
            this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmEditAddCommodities frm = new frmEditAddCommodities(null))
            {
                frm.ShowDialog();
                this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
                this.commoditiesBindingSource.Position= this.commoditiesBindingSource.Find("Commodity", frm.NewName);

            }

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == commodity.Index)
            {
                Seed_Storage_Dataset.CommoditiesRow  SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.CommoditiesRow)(DataRow)((DataRowView)this.commoditiesBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    using (frmEditAddCommodities  frm = new frmEditAddCommodities(SelectedRow))
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
                            this.commoditiesBindingSource.Position = this.commoditiesBindingSource.Find("Commodity", frm.NewName);
                        }

                }
            }
            if (e.ColumnIndex == btnDelete.Index)
            {
                Seed_Storage_Dataset.CommoditiesRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.CommoditiesRow)(DataRow)((DataRowView)this.commoditiesBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    using (Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter VarietiesTableAdapter = new Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter())
                    {
                        if (VarietiesTableAdapter.FillByCommodity(seed_Storage_Dataset.Varieties, SelectedRow.Commodity) > 0)
                        {
                            Alert.Show("You Cannot Delete A Commodity With Varieties Assigned To It");
                        }
                        else
                        {
                            if (Alert.Show("Delete " + SelectedRow.Commodity + " ?", frmAlert.enumButtonStyle.YesNo) == DialogResult.Yes)
                            {
                                try
                                {
                                    this.commoditiesBindingSource.RemoveCurrent();
                                    this.commoditiesTableAdapter.Update(this.seed_Storage_Dataset);
                                    this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
                                }
                                catch (Exception ex)
                                {
                                    Alert.Show("Error Deleting Commodity " + ex.Message);
                                }
                            }
                        }

                    }

                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.commoditiesBindingSource.EndEdit();
                this.Validate();
                this.commoditiesTableAdapter.Update(this.seed_Storage_Dataset);
                this.DialogResult = DialogResult.OK;
               

            }
            catch(Exception ex)
            {
                Alert.Show("Error Saving Commodities " + ex.Message);
            }
           
            finally
            {

                this.Close();
            }
        }
    }
}
