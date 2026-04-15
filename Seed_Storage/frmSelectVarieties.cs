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
    public partial class frmSelectVarieties : Form
    {
        bool allowSelection;
        DialogResult OKDialogResult;
        public Seed_Storage_Dataset.VarietiesRow VarietiesRow;
        public frmSelectVarieties( bool AllowSelection )
        {
            InitializeComponent();

            allowSelection = AllowSelection;
            if (allowSelection)
            { 
                this.btnOk.Text = "Cancel";
                OKDialogResult = DialogResult.Cancel;
                
            }
            else
            {
                
                OKDialogResult = DialogResult.OK;
            }

        }


        private void frmSelectVarieties_Load(object sender, EventArgs e)
        {
            
            this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
            this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
            this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmInputBox frm = new frmInputBox("New Variety Name", "", false))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Seed_Storage_Dataset.CommoditiesRow CommodityRow = (Seed_Storage_Dataset.CommoditiesRow)(DataRow)((DataRowView)this.commoditiesBindingSource.Current).Row;

                        using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                        {
                            Q.CreateNewVariety(this.comboBox1.Text, frm.Input,CommodityRow.Pounds_Per_Bushel );
                            this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
                            this.varietiesBindingSource.Position = this.varietiesBindingSource.Find("Variety", frm.Input);

                        }

                    }
                    catch (Exception ex)
                    {
                        Alert.Show("Error Saving Variety " + ex.Message, frmAlert.enumButtonStyle.OkOnly);

                    }
                }
            }
        }

        private void varietiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == Variety.Index && allowSelection )
            {

                VarietiesRow = (Seed_Storage_Dataset.VarietiesRow)(DataRow)((DataRowView)this.varietiesBindingSource.Current).Row;
                if (VarietiesRow != null)
                {
                    this.DialogResult = DialogResult.OK ;
                    this.Close();
                }
            }
            else if (e.ColumnIndex == Variety.Index &&  ! allowSelection)
            {

                VarietiesRow = (Seed_Storage_Dataset.VarietiesRow)(DataRow)((DataRowView)this.varietiesBindingSource.Current).Row;
                if (VarietiesRow != null)
                {
                    using (frmEditVariety frm = new frmEditVariety(VarietiesRow))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
                            this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
                            this.varietiesBindingSource.Position = this.varietiesBindingSource.Find("Variety", frm.NewName);
                        }
                    }
                }
            }


            else if (e.ColumnIndex == btnDelete.Index  )
            {
                VarietiesRow = (Seed_Storage_Dataset.VarietiesRow)(DataRow)((DataRowView)this.varietiesBindingSource.Current).Row;
                if (VarietiesRow != null)
                {
                    using (Seed_Storage_DatasetTableAdapters.BinsTableAdapter BinsTableAdapter = new Seed_Storage_DatasetTableAdapters.BinsTableAdapter())
                    {
                        if (BinsTableAdapter.FillByVariety(seed_Storage_Dataset.Bins, VarietiesRow.Variety) > 0)
                        {
                            Alert.Show("You Cannot Remove A Variety Being Used By A Bin");

                        }
                        else
                        {
                            if (Alert.Show("Delete " + VarietiesRow.Variety, frmAlert.enumButtonStyle.YesNo) == DialogResult.Yes)
                            {
                                try
                                {
                                    this.varietiesBindingSource.RemoveCurrent();
                                    this.varietiesTableAdapter.Update(this.seed_Storage_Dataset);
                                    this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
                                    this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
                                }
                                catch (Exception ex)
                                {
                                    Alert.Show("Error Deleting Variety " + ex.Message);

                                }
                            }
                        }
                    }
                }
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.varietiesBindingSource.EndEdit();
            this.varietiesTableAdapter.Update(this.seed_Storage_Dataset);
            this.DialogResult = OKDialogResult;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmCommodities frm = new frmCommodities())
            {
                frm.ShowDialog();

                this.commoditiesTableAdapter.Fill(this.seed_Storage_Dataset.Commodities);
                this.varietiesTableAdapter.Fill(this.seed_Storage_Dataset.Varieties);
                this.varietiesBindingSource.Filter = "Commodity='" + comboBox1.Text + "'";
            }
        }

        private void varietiesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.varietiesBindingSource.CancelEdit();
        }
    }
}
