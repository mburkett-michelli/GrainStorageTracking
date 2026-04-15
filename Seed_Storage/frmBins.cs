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
    public partial class frmBins : Form
    {
        public frmBins()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            this.seed_Storage_Dataset.EnforceConstraints = false;
            this.binsTableAdapter.Fill(this.seed_Storage_Dataset.Bins);

        }

        private void binsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void binsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.binsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seed_Storage_Dataset);

        }

        private void Bins_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public bool SaveData()
        {
            try
            {
                this.Validate();
                this.binsBindingSource.EndEdit();
                this.binsTableAdapter.Update(this.seed_Storage_Dataset);
                return true;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Saving Data " + ex.Message);
                return false;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int Position = this.binsBindingSource.Position;
            string BinName = "";
            NEW_BIN_DESCRIPTION:
            using (frmInputBox frm = new frmInputBox("Enter Bin Description", BinName, false))
            {
                if (frm.ShowDialog()== DialogResult.OK )
                {
                    using (Seed_Storage_DatasetTableAdapters.BinsTableAdapter BinsTableAdapter = new Seed_Storage_DatasetTableAdapters.BinsTableAdapter())
                    using (Seed_Storage_Dataset.BinsDataTable Bins = new Seed_Storage_Dataset.BinsDataTable())
                    {
                        BinName = frm.Input;
                        if (BinsTableAdapter.FillByDescription(Bins, BinName ) > 0)
                        {
                            MessageBox.Show("Bin " + BinName + " Already Exists", "Opps");
                            goto NEW_BIN_DESCRIPTION;

                        }
                        else
                        {
                            try
                            {
                                Seed_Storage_Dataset.BinsRow row = this.seed_Storage_Dataset.Bins.NewBinsRow();
                                row.Capacity = 0;
                                row.UID = Guid.NewGuid();
                                row.Use_For_Inbound_Loads = true;
                                row.Bin = BinName;
                                this.seed_Storage_Dataset.Bins.AddBinsRow(row);
                                this.binsTableAdapter.Update(this.seed_Storage_Dataset);
                                this.binsBindingSource.Position = this.binsBindingSource.Find("Description", BinName);

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Error Saving Bin " + BinName + " "+ex.Message , "Opps");
                            }

                        }

                    }

                }

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                Seed_Storage_Dataset.BinsRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.BinsRow)(DataRow)((DataRowView)this.binsBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    if (MessageBox.Show("Delete Bin "+ SelectedRow.Bin , "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SelectedRow.Delete();
                        this.binsTableAdapter.Update(this.seed_Storage_Dataset);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting Bin " + ex.Message, "Opps");

            }
        }

        private void binsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnVariety.Index)
            {
                Seed_Storage_Dataset.BinsRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.BinsRow)(DataRow)((DataRowView)this.binsBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    using (frmSelectVarieties frm = new frmSelectVarieties(true))
                        if (frm.ShowDialog()== DialogResult.OK)
                        {
                            using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                            {
                                string Bin = SelectedRow.Bin;
                                Q.UpdateBinVariety(Bin, frm.VarietiesRow.Variety);
                                this.binsTableAdapter.Fill(this.seed_Storage_Dataset.Bins);
                                this.binsBindingSource.Position = this.binsBindingSource.Find("Bin", Bin);
                            }
                        }

                }
            }
            else if (e.ColumnIndex == this.btnBin.Index)
            {
                Seed_Storage_Dataset.BinsRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.BinsRow)(DataRow)((DataRowView)this.binsBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    using (frmEditBin  frm = new frmEditBin(SelectedRow ))
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                           
                                string Bin = frm.NewName ;
                                this.binsTableAdapter.Fill(this.seed_Storage_Dataset.Bins);
                                this.binsBindingSource.Position = this.binsBindingSource.Find("Bin", Bin);
                           
                        }

                }
            }

            else if (e.ColumnIndex == btnDelete.Index  )
            {
                Seed_Storage_Dataset.BinsRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.BinsRow)(DataRow)((DataRowView)this.binsBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    if (Alert.Show("Are You Sure You Want To Delete Bin "+SelectedRow.Bin, frmAlert.enumButtonStyle.YesNo )== DialogResult.Yes )
                    {
                        using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                        {
                            string Bin = SelectedRow.Bin ;
                            this.binsBindingSource.RemoveCurrent();
                            this.binsTableAdapter.Update(this.seed_Storage_Dataset );

                            this.binsTableAdapter.Fill(this.seed_Storage_Dataset.Bins);

                            
                        }


                    }

                }
            }
        }

        private void binsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (frmAddNewBin frm = new frmAddNewBin())
            {
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    string Bin = frm.NewName;
                    this.binsTableAdapter.Fill(this.seed_Storage_Dataset.Bins);
                    this.binsBindingSource.Position = this.binsBindingSource.Find("Bin", Bin);
                }


            }
        }

        private void binsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.binsBindingSource.CancelEdit();
        }
    }
}
