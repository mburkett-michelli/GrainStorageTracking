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
    public partial class FrmFinishTicket : Form
    {
        public Seed_Storage_Dataset.vw_Inbound_TicketsRow SelectedRow;
        public enum enumSelectionMode { Weigh_Out,Edit,Cancel}
        public enumSelectionMode SelectionMode;

        public FrmFinishTicket()
        {
            InitializeComponent();
        }

        private void FrmFinishTicket_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void GetData()
        {
            if (Properties.Settings.Default.UseInboundCamera == false) 
            { 
                inbound_TicketsDataGridView.Columns.Remove(Picture);
            }
            SelectionMode = enumSelectionMode.Cancel;
            this.vw_Inbound_TicketsTableAdapter.Fill(this.seed_StorageDataSet.vw_Inbound_Tickets);
            int Index = 0;
            foreach (Seed_Storage_Dataset.vw_Inbound_TicketsRow Row in this.seed_StorageDataSet.vw_Inbound_Tickets)
            {
                if (!Row.IsInbound_PictureNull())
                {
                    DataGridViewImageCell Picture = (DataGridViewImageCell)this.inbound_TicketsDataGridView.Rows[Index].Cells[this.Picture.Index];
                    //Picture.Value = Image.FromFile(Row.Inbound_Picture);
                }
                Index += 1;
            }

        }


        private void inbound_TicketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex> -1)
            {

                SelectedRow = (Seed_Storage_Dataset.vw_Inbound_TicketsRow)(DataRow)((DataRowView)this.inbound_TicketsBindingSource.Current).Row;
                if (e.ColumnIndex == this.btnWeighOut.Index)
                {
                    if (SelectedRow != null)
                    {
                        this.SelectionMode = enumSelectionMode.Weigh_Out;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                        
                    }
                }
                else if (e.ColumnIndex == this.btnEdit.Index)
                {
                    if (SelectedRow != null)
                    {
                        this.SelectionMode = enumSelectionMode.Edit;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                        
                    }
                }
                else if (e.ColumnIndex== this.Picture.Index )
                {
                    using (frmTicketDetails frm = new frmTicketDetails(SelectedRow.Ticket ))
                    {
                        frm.ShowDialog();

                    }

                }
                else if (e.ColumnIndex == btnDelete.Index )
                {
                    using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                    {
                        if (Alert.Show("Delete Ticket "+SelectedRow.Ticket.ToString()+" ?", frmAlert.enumButtonStyle.YesNo )== DialogResult.Yes  )
                        {
                            Q.DeleteTicket(SelectedRow.Ticket);
                            GetData();
                        }
                        

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void inbound_TicketsDataGridView_Paint(object sender, PaintEventArgs e)
        {
       

            
        }

        private void inbound_TicketsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
          
        }

        private void inbound_TicketsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
    }
}
