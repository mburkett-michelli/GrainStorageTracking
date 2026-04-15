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
    public partial class frmTicketDetails : Form
    {
        public frmTicketDetails(int Ticket)
        {
            InitializeComponent();
            this.vwTicket_InformationTableAdapter.FillByTicket (this.seed_Storage_Dataset.vwTicket_Information,Ticket);
            Seed_Storage_Dataset.vwTicket_InformationRow Row = this.seed_Storage_Dataset.vwTicket_Information[0];
                if (!Row.IsInbound_PictureNull()) this.picturePictureBox.Image = Image.FromFile(Row.Inbound_Picture);
        }

        private void frmTicketDetails_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
