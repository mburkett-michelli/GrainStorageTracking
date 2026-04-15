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
    public partial class Headers : Form
    {
        public Headers()
        {
            InitializeComponent();
        }

        private void headersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Headers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seed_Storage_Dataset.Headers' table. You can move, or remove it, as needed.
            this.headersTableAdapter.Fill(this.seed_Storage_Dataset.Headers);

        }

        private void Headers_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.headersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.seed_Storage_Dataset);

            }
            catch 
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
