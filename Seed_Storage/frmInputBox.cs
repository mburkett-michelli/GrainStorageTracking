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
    public partial class frmInputBox : Form
    {
        private bool AcceptBlank = false;

        public string Input;

        private  frmInputBox()
        {
            InitializeComponent();
        }

        public frmInputBox(string Prompt,string DefaultValue,bool AllowBlank= false )
        {
            InitializeComponent();
            this.AcceptBlank = AllowBlank;
            this.button1.Visible = AllowBlank;
            this.lblPrompt.Text = Prompt;
            this.txtInput.Text = DefaultValue;
            this.txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            this.button1.Visible = this.txtInput.Text.Length > 0 || AcceptBlank;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Input = this.txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
