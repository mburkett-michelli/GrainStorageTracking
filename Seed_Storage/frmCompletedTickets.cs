using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scale_Connection;

namespace Seed_Storage
{
    public partial class frmCompletedTickets : Form
    {
        public Seed_Storage_Dataset.vwTicket_InformationRow SelectedRow;
        public enum enumSelectionMode { Weigh_Out,Edit,Cancel}
        public enumSelectionMode SelectionMode;
        public bool Loading = true;
        private SMA_Command_LIB.SMA _SMA;
        private Scale_Connection.Serial_Connection _SerialScale;

        public frmCompletedTickets()
        {
            InitializeComponent();
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now.AddDays(-1);
            SelectionMode = enumSelectionMode.Cancel;
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now;
            this.cboLoadtype.SelectedIndex = 0;
            
        }

        public frmCompletedTickets(SMA_Command_LIB.SMA SMA)
        {
            InitializeComponent();
            _SMA = SMA;
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now.AddDays(-1);
            SelectionMode = enumSelectionMode.Cancel;
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now;
            this.cboLoadtype.SelectedIndex = 0;

        }

        public frmCompletedTickets(Scale_Connection.Serial_Connection SerialScale)
        {
            InitializeComponent();
            _SerialScale = SerialScale;
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now.AddDays(-1);
            SelectionMode = enumSelectionMode.Cancel;
            this.dtStart.Value = DateTime.Now;
            this.dtEnd.Value = DateTime.Now;
            this.cboLoadtype.SelectedIndex = 0;

        }

        private void frmCompletedTickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seed_StorageDataSet.vwDistinctCustomers' table. You can move, or remove it, as needed.
            this.vwDistinctCustomersTableAdapter.FillByDistinctCustomers(this.seed_StorageDataSet.vwDistinctCustomers);
            // TODO: This line of code loads data into the 'seed_StorageDataSet.GTNCustomers' table. You can move, or remove it, as needed.
            this.gTNCustomersTableAdapter.Fill(this.seed_StorageDataSet.GTNCustomers);
            Loading = false;
            LoadData();
        }

        private void inbound_TicketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SelectedRow = (Seed_Storage_Dataset.vwTicket_InformationRow)(DataRow)((DataRowView)this.TicketsBindingSource.Current).Row;
                
                if (e.ColumnIndex == this.btnEdit.Index)
                {
                    if (SelectedRow != null)
                    {

                        if (SelectedRow.Load_Type == "Outbound")
                        {
                            frmShipping.enumEditMode EditMode = frmShipping.enumEditMode.EditOutbound;

                            if (Properties.Settings.Default.ConnectionType == "SMA")
                            {
                                using (frmShipping ShippingForm = new frmShipping(SelectedRow.Ticket, _SMA, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    ShippingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            else
                            {
                                using (frmShipping ShippingForm = new frmShipping(SelectedRow.Ticket, _SerialScale, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    ShippingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            
                        }
                        if (SelectedRow.Load_Type == "Inbound")
                        {
                            frmRecieving.enumEditMode EditMode = frmRecieving.enumEditMode.EditOutbound;
                            
                            if (Properties.Settings.Default.ConnectionType == "SMA")
                            {
                                using (frmRecieving RecievingForm = new frmRecieving(SelectedRow.Ticket, _SMA, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    RecievingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            else
                            {
                                using (frmRecieving RecievingForm = new frmRecieving(SelectedRow.Ticket, _SerialScale, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    RecievingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            
                        }

                        if (SelectedRow.Load_Type == "Other")
                        {
                            frmGTNTicket.enumEditMode EditMode = frmGTNTicket.enumEditMode.EditOutbound;

                            if (Properties.Settings.Default.ConnectionType == "SMA")
                            {
                                using (frmGTNTicket GTNTicketForm = new frmGTNTicket(SelectedRow.Ticket, _SMA, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    GTNTicketForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            else
                            {
                                using (frmGTNTicket GTNTicketForm = new frmGTNTicket(SelectedRow.Ticket, _SerialScale, EditMode))
                                {

                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    GTNTicketForm.ShowDialog();
                                    this.Show();
                                }
                            }
                            
                        }

                        LoadData();

                    }
                }
                //else if (e.ColumnIndex== this.Picture.Index )
                //{
                //    using (frmTicketDetails frm = new frmTicketDetails(SelectedRow.Ticket ))
                //    {
                //        frm.ShowDialog();

                //    }

                //}
                else if (e.ColumnIndex == btnDelete.Index )
                {
                    using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                    {
                        if (Alert.Show("Delete Ticket "+SelectedRow.Ticket.ToString()+" ?", frmAlert.enumButtonStyle.YesNo )== DialogResult.Yes  )
                        {
                            Q.DeleteTicket(SelectedRow.Ticket);
                            LoadData();
                        }
                        

                    }

                }
                else if (e.ColumnIndex ==btnReprint.Index   )
                {
                    if (SelectedRow.Load_Type == "Outbound")
                    {
                        Printing.PrintShippingTicket(SelectedRow.Ticket, 1);
                    }
                    else if (SelectedRow.Load_Type == "Inbound")
                    {
                        Printing.PrintRecievingTicket(SelectedRow.Ticket, 1);
                    }
                    else
                    {
                        Printing.PrintGTNTicket(SelectedRow.Ticket, 1);
                    }
                }
            }
        }


        private void LoadData()
        {
            DateTime StartDate = Convert.ToDateTime(this.dtStart.Value.ToShortDateString() + " 12:00:00 AM");
            DateTime EndDate = Convert.ToDateTime(this.dtEnd.Value.ToShortDateString() + " 12:00:00 AM");
            
            string selectedCustomer;
            if (this.cboCustomer.SelectedIndex < 1)
            {
                selectedCustomer = null;
            }
            else
            {
                selectedCustomer = this.cboCustomer.Text;
            }

            string selectedLoadType;
            if (this.cboLoadtype.SelectedIndex < 1)
            {
                selectedLoadType = null;
            }
            else
            {
                selectedLoadType = this.cboLoadtype.Text;
            }

            this.vwTicket_InformationTableAdapter.FillByDateLoadTypeCustomer(this.seed_StorageDataSet.vwTicket_Information, StartDate, EndDate, selectedLoadType, selectedCustomer);

            //if (this.cboLoadtype.SelectedIndex<1)
            //{
            //    //this.vwTicket_InformationTableAdapter.FillByStartDateEndDateLoadType(this.seed_StorageDataSet.vwTicket_Information, StartDate, EndDate, null);
            //    this.vwTicket_InformationTableAdapter.FillByDateLoadTypeCustomer(this.seed_StorageDataSet.vwTicket_Information, StartDate, EndDate, null, selectedCustomer);
            //}
            //else
            //{
            //    //this.vwTicket_InformationTableAdapter.FillByStartDateEndDateLoadType(this.seed_StorageDataSet.vwTicket_Information, StartDate, EndDate, this.cboLoadtype.Text );
            //    this.vwTicket_InformationTableAdapter.FillByDateLoadTypeCustomer(this.seed_StorageDataSet.vwTicket_Information, StartDate, EndDate, this.cboLoadtype.Text, this.cboCustomer.Text);
            //}


            SelectionMode = enumSelectionMode.Cancel;
            
            //int Index = 0;
            //foreach (Seed_Storage_Dataset.vwTicket_InformationRow  Row in this.seed_StorageDataSet.vwTicket_Information)
            //{
            //    if (!Row.IsInbound_PictureNull())
            //    {
            //        DataGridViewImageCell Picture = (DataGridViewImageCell)this.inbound_TicketsDataGridView.Rows[Index].Cells[this.Picture.Index];
            //        Picture.Value = Image.FromFile(Row.Inbound_Picture);
            //    }
            //    Index += 1;
            //}



    }

    private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                LoadData();
            }
        }

        private void cboLoadtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                LoadData();
            }

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                LoadData();
            }

        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                LoadData();
            }
        }
    }
}
