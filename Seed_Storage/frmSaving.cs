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
    public partial class frmSaving : Form
    {
        public frmSaving()
        {
            InitializeComponent();
        }

        public void SetPrompt(string Prompt)
        {
            this.label1.Text = Prompt;
        }
    }
}
