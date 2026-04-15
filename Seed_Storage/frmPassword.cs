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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckPassword()
        {
            using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter  = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
            {
                using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
                {
                    System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                    Seed_Storage_Dataset.System_SetupRow row = Seed_Storage_Dataset.System_Setup[0];
                    if(row.Setup_Password==this.textBox1.Text )
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Valid");

                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter )
            {
                e.SuppressKeyPress= true ; 
                CheckPassword();
            }
        }
    }
}
