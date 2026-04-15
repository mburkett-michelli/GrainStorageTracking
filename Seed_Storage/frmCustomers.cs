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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.seed_Storage_Dataset);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            
            this.customersTableAdapter.Fill(this.seed_Storage_Dataset.Customers);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.seed_Storage_Dataset);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Alert.Show("Error Saving Customers " + ex.Message);
            }
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Customer.Index)
            {
                Seed_Storage_Dataset.CustomersRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.CustomersRow)(DataRow)((DataRowView)this.customersBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    using (frmEditAddCustomer frm = new frmEditAddCustomer(SelectedRow))
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            this.customersTableAdapter.Fill(this.seed_Storage_Dataset.Customers);
                            this.customersBindingSource.Position = this.customersBindingSource.Find("Customer", frm.NewName);
                        }

                }
            }
            if (e.ColumnIndex == btnDelete.Index)
            {
                Seed_Storage_Dataset.CustomersRow SelectedRow;
                SelectedRow = (Seed_Storage_Dataset.CustomersRow)(DataRow)((DataRowView)this.customersBindingSource.Current).Row;
                if (SelectedRow != null)
                {
                    if (Alert.Show("Delete " + SelectedRow.Customer + " ?", frmAlert.enumButtonStyle.YesNo) == DialogResult.Yes)
                    {
                        this.customersBindingSource.RemoveCurrent();
                        this.customersTableAdapter.Update(this.seed_Storage_Dataset);
                        this.customersTableAdapter.Fill(this.seed_Storage_Dataset.Customers);
                        
                    }      

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmEditAddCustomer frm = new frmEditAddCustomer(null))
            {
                if(frm.ShowDialog()== DialogResult.OK)
                {
                    this.customersTableAdapter.Fill(this.seed_Storage_Dataset.Customers);
                    this.customersBindingSource.Position = this.customersBindingSource.Find("Customer", frm.NewName);

                }
            }
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}
