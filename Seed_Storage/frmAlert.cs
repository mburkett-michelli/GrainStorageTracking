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
    public partial class frmAlert : Form
    {
        private DialogResult LeftButtonDR;
        private DialogResult RightButtonDR;

        public enum enumButtonStyle { OkOnly, OKCancel, YesNo }

        public frmAlert(string Prompt,enumButtonStyle ButtonStyle )
        {
            InitializeComponent();
            this.label1.Text = Prompt;
            switch (ButtonStyle)
            {
                case enumButtonStyle.OkOnly:
                    btnLeft.Visible = false;
                    RightButtonDR = DialogResult.OK;
                    btnRight.Text = "OK";

                    break;
                case enumButtonStyle.OKCancel:
                    LeftButtonDR = DialogResult.Cancel ;
                    RightButtonDR = DialogResult.OK ;
                    btnLeft.Text = "OK";
                    btnRight.Text = "Cancel";

                    break;
                case enumButtonStyle.YesNo:
                    LeftButtonDR = DialogResult.Yes ;
                    RightButtonDR = DialogResult.No ;
                    btnLeft.Text = "Yes";
                    btnRight.Text = "No";

                    break;
                default:
                    btnLeft.Visible = false;
                    RightButtonDR = DialogResult.OK;
                    btnRight.Text = "OK";

                    break;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.DialogResult = LeftButtonDR;
            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.DialogResult = RightButtonDR;
            this.Close();
        }
    }
}
