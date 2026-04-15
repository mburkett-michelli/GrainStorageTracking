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
    public partial class frmEditAddCustomer : Form
    {
        
        Seed_Storage_Dataset.CustomersRow CustomerRow;
        public string NewName;
        public frmEditAddCustomer( Seed_Storage_Dataset.CustomersRow SelectedCustomerRow )
        {
            InitializeComponent();
            CustomerRow = SelectedCustomerRow;
            if (CustomerRow != null)
            {
                this.txtCustomer.Text = CustomerRow.Customer;
                this.lblPrompt.Text = "Edit " + CustomerRow.Customer;
            }

         
            else
            {
                this.lblPrompt.Text = "Add New Customer";
            }
        }

       
        
        private void frmEditAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCustomer.Text))
            {
                Alert.Show("Customer Name Cannot Be Empty");
            }
            else
            {
                if (this.CustomerRow != null)
                {

                    if (customersTableAdapter.FillByChangingExistingName(this.seed_Storage_Dataset.Customers, CustomerRow.UID, this.txtCustomer.Text) > 0)
                    {
                        Alert.Show("Customer " + this.txtCustomer.Text + " Already Exists");

                    }

                    else
                    {
                        Seed_Storage_Dataset.CustomersRow row = seed_Storage_Dataset.Customers[0];

                        row.Customer = this.txtCustomer.Text;
                        NewName = this.txtCustomer.Text;
                        this.customersTableAdapter.Update(seed_Storage_Dataset);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }

                else

                {
                    if (customersTableAdapter.FillByCustomer(this.seed_Storage_Dataset.Customers, this.txtCustomer.Text) > 0)
                    {
                        Alert.Show("Customer " + this.txtCustomer.Text + " Already Exists");

                    }
                    else
                    {
                        Seed_Storage_Dataset.CustomersRow row = seed_Storage_Dataset.Customers.NewCustomersRow();
                        row.UID = Guid.NewGuid();
                        row.Customer = this.txtCustomer.Text;
                        row.Active = true;
                        this.seed_Storage_Dataset.Customers.AddCustomersRow(row);
                        NewName = this.txtCustomer.Text;
                        this.customersTableAdapter.Update(seed_Storage_Dataset);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }


                }
            }
        }
    }
}
