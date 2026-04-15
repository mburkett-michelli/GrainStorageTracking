using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Windows.Forms;



namespace Seed_Storage
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private bool Save_Data()
        {
            try {
                this.Validate();
                this.system_SetupBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.seed_Storage_Dataset);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Saving Setup " + ex.Message);
                return false;
                
            }
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            
            this.system_SetupTableAdapter.Fill(this.seed_Storage_Dataset.System_Setup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.outbound_Camera_IP_AddressTextBox.Text = this.outbound_Camera_IP_AddressTextBox.Text.Trim();
                this.outbound_Camera_Admin_PassTextBox.Text = this.outbound_Camera_Admin_PassTextBox.Text.Trim();
                this.inbound_Camera_Admin_PassTextBox.Text = this.inbound_Camera_Admin_PassTextBox.Text.Trim();
                this.inbound_Camera_IP_AddressTextBox.Text = this.inbound_Camera_IP_AddressTextBox.Text.Trim();
                this.setup_PasswordTextBox.Text = this.setup_PasswordTextBox.Text.Trim();
                this.scale_IP_AddressTextBox.Text = this.scale_IP_AddressTextBox.Text.Trim();
                this.scale_PortTextBox.Text = this.scale_PortTextBox.Text.Trim();
                this.update_RateTextBox.Text = this.update_RateTextBox.Text.Trim();
                this.system_SetupBindingSource.EndEdit();
                int ScalePort;
                //if (!Seed_Storage.validation.IsValidIPAddress(this.inbound_Camera_IP_AddressTextBox.Text))
                //{ MessageBox.Show("Inbound Camera Ip Address Is Invalid", "Error"); }
                //else if (!Seed_Storage.validation.IsValidIPAddress(this.outbound_Camera_IP_AddressTextBox.Text))
                //{ MessageBox.Show("Outbound Camera Ip Address Is Invalid", "Error"); }
                if (!Seed_Storage.validation.IsValidIPAddress(this.scale_IP_AddressTextBox.Text))
                { MessageBox.Show("Scale Ip Address Is Invalid", "Error"); }
                else if (!int.TryParse(this.scale_PortTextBox.Text,out ScalePort ))
                { MessageBox.Show("Scale Port Is Invalid", "Error"); }
                else if (!int.TryParse(this.update_RateTextBox.Text, out ScalePort))
                { MessageBox.Show("Update Rate Is Invalid", "Error"); }

                else
                {
                    this.system_SetupBindingSource.EndEdit();
                    this.system_SetupTableAdapter.Update(this.seed_Storage_Dataset);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Changes " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picture pic = new Picture();
            pic.SaveNoPicture(@"E:\Customers\Piquet Farms\Seed_Storage\No Image.png");

        }

        private void system_SetupBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbSetupTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (Headers frm= new Headers() )
            {

                frm.ShowDialog();
            }
        }
    }
}
