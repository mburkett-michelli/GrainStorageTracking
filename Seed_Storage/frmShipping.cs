using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SMA_Command_LIB;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using AxAXVLC;
using Scale_Connection;

namespace Seed_Storage
{
    public partial class frmShipping : Form
    {
        delegate void SetTextCallback();
        public SMA_Command_LIB.SMA SmaScale;
        public Scale_Connection.Serial_Connection SerialScale;

        public int CurrentWeight;

        public Seed_Storage.Seed_Storage_Dataset.vwTicket_InformationRow vwTicket_InformationRow;

        private bool ManualWeight;
        
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        public string InboundCameraString;
        public string OutboundCameraString;

        public enum enumEditMode { New,EditInbound,Finish,EditOutbound};
        public Seed_Storage_Dataset.ShippingRow ShippingRow;

        public enumEditMode EditMode;

        public frmShipping(Scale_Connection.Serial_Connection CurrentScale)
        {
            InitializeComponent();
            EditMode = enumEditMode.New;

            SerialScale = CurrentScale;
            SerialScale.StatusChanged += SerialScale_StatusChanged;
            this.tmrInbound.Start();
            SetCameras();
            ManualWeight = false;
            UpdateLists();
            this.driverComboBox.SelectedIndex = -1;
            this.growerComboBox.SelectedIndex = -1;
            this.binComboBox.SelectedIndex = 0;
            this.btnDelete.Visible = false;
            this.btn_Ok.Text = "Create Shipping Ticket";
        }

        

        public frmShipping(SMA_Command_LIB.SMA  CurrentScale)
        {
            InitializeComponent();
            EditMode = enumEditMode.New;
            
            SmaScale = CurrentScale;
            SmaScale.ScaleDataRecieved += SmaScale_ScaleDataRecieved;
            this.tmrInbound.Start();
            SetCameras();
            ManualWeight = false;
            UpdateLists();
            this.driverComboBox.SelectedIndex = -1;
            this.growerComboBox.SelectedIndex = -1;
            this.binComboBox.SelectedIndex = 0;
            this.btnDelete.Visible = false;
            this.btn_Ok.Text = "Create Shipping Ticket";
        }



        /// <summary>
        /// Edit Or Finish a ticket
        /// </summary>
        /// <param name="Ticket">Ticket Number</param>
        /// <param name="CurrentScale">Pass the SMA Scale</param>
        /// <param name="Mode">EditInbound,Finish,EditOutbound DONT USE NEW</param>
        public frmShipping(int Ticket,SMA_Command_LIB.SMA CurrentScale,enumEditMode Mode)
        {
            InitializeComponent();
            EditMode = Mode;
            //axVLCPlugin21.Toolbar = false;

            SmaScale = CurrentScale;
            SmaScale.ScaleDataRecieved += SmaScale_ScaleDataRecieved;
            this.btnDelete.Visible = true;
            
            UpdateLists();
            if (EditMode == enumEditMode.New)
            {
                Alert.Show("Cannot Edit A New Ticket");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                {
                    if (vwTicket_InformationTableAdapter.FillByTicket(this.Seed_Storage_Dataset.vwTicket_Information, Ticket) == 0)
                    {
                        Alert.Show("Cannot Find Ticket " + Ticket.ToString());
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();

                    }
                    else
                    {

                        SetupMainForm(Ticket);
                         
                    }

                }

            }

                UpdateWeight();
        }

        /// <summary>
        /// Edit Or Finish a ticket
        /// </summary>
        /// <param name="Ticket">Ticket Number</param>
        /// <param name="CurrentScale">Pass the Serial Scale</param>
        /// <param name="Mode">EditInbound,Finish,EditOutbound DONT USE NEW</param>
        public frmShipping(int Ticket, Scale_Connection.Serial_Connection CurrentScale , enumEditMode Mode)
        {
            InitializeComponent();
            EditMode = Mode;
            //axVLCPlugin21.Toolbar = false;

            SerialScale = CurrentScale;
            SerialScale.StatusChanged += SerialScale_StatusChanged;
            this.btnDelete.Visible = true;

            UpdateLists();
            if (EditMode == enumEditMode.New)
            {
                Alert.Show("Cannot Edit A New Ticket");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                using (Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter = new Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter())
                {
                    if (vwTicket_InformationTableAdapter.FillByTicket(this.Seed_Storage_Dataset.vwTicket_Information, Ticket) == 0)
                    {
                        Alert.Show("Cannot Find Ticket " + Ticket.ToString());
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();

                    }
                    else
                    {

                        SetupMainForm(Ticket);

                    }

                }

            }

            UpdateWeight();
        }

        private void SetupMainForm(int Ticket)
        {
            this.vwTicket_InformationRow = this.Seed_Storage_Dataset.vwTicket_Information[0];
            this.lblHeader.Text = string.Format(" Ticket {0}", this.vwTicket_InformationRow.ID);
            SetCameras();
            ManualWeight = true;
            using (Seed_Storage_DatasetTableAdapters.ShippingTableAdapter ShippingTableAdapter = new Seed_Storage_DatasetTableAdapters.ShippingTableAdapter())
            {
                if (ShippingTableAdapter.FillByTicket(this.Seed_Storage_Dataset.Shipping, Ticket) == 0)
                {
                    Alert.Show("Cannot Find Shipping Information For Ticket " + Ticket.ToString());
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();

                }
                else
                {
                    this.ShippingRow = this.Seed_Storage_Dataset.Shipping[0];
                    this.vwTicket_InformationRow = Seed_Storage_Dataset.vwTicket_Information[0];
                    this.pnlGTN.Visible = EditMode != enumEditMode.EditInbound;
                    this.Truck_IDtextbox.Text = vwTicket_InformationRow.Truck_ID;
                    this.growerComboBox.Text = ShippingRow.Customer;
                    this.driverComboBox.Text = this.vwTicket_InformationRow.Driver;
                    this.ckDriverOn.Checked = this.vwTicket_InformationRow.Driver_On;
                    this.time_InLabel1.Text = this.vwTicket_InformationRow.Time_In.ToShortDateString() + " " + this.vwTicket_InformationRow.Time_In.ToLongTimeString();
                    if (!this.ShippingRow.IsBinNull()) this.binComboBox.Text = this.ShippingRow.Bin;
                    if (!this.ShippingRow.IsBush_TicketNull()) this.txtBushTicket.Text = this.ShippingRow.Bush_Ticket;
                    if (!this.ShippingRow.IsLotNull()) this.lotTextBox.Text = this.ShippingRow.Lot;
                    if (!this.vwTicket_InformationRow.IsWeighMasterNull()) this.cboWeighmaster.Text = this.vwTicket_InformationRow.WeighMaster;
                    if (!this.vwTicket_InformationRow.IsCommentsNull()) this.rtbComment.Text = this.vwTicket_InformationRow.Comments;
                    if (!this.vwTicket_InformationRow.IsTime_OutNull()) this.time_OutLabel1.Text = this.vwTicket_InformationRow.Time_Out.ToShortDateString() + " " + this.vwTicket_InformationRow.Time_Out.ToLongTimeString();
                    this.pnlTimeOut.Visible = (EditMode != enumEditMode.EditInbound);
                    if (EditMode == enumEditMode.EditInbound)
                    {
                        this.btnManualWeight.Text = "Edit Weight";
                        this.CurrentWeight = (int)vwTicket_InformationRow.In_Weight;
                        this.lblMotion.Visible = false;
                        this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", this.CurrentWeight);
                        this.btn_Ok.Text = "Save Changes";
                    }
                    else if (EditMode == enumEditMode.EditOutbound)
                    {

                        pnlWeight.Visible = false;
                        this.btn_Ok.Text = "Save Changes";
                    }
                    else if (EditMode == enumEditMode.Finish)
                    {

                        this.time_OutLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                        this.tmrOutbound.Enabled = true;
                        this.lnkEditOutbound.Visible = false;
                        ManualWeight = false;
                        this.btn_Ok.Text = "PRINT Shipping Ticket";
                    }

                }

            }
        }

        private void SetCameras( )
        {

            if (Properties.Settings.Default.UseInboundCamera == false)
            {
                videoInbound.Visible = false;
                //axVLCPlugin21.Visible = false;
            }
            if (Properties.Settings.Default.UseOutboundCamera == false)
            {
                videoOutbound.Visible = false;
                //axVLCPlugin22.Visible = false;
            }

            using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
            {
                using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
                    System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                Seed_Storage_Dataset.System_SetupRow row = Seed_Storage_Dataset.System_Setup[0];

                try
                {
                    if ( EditMode == enumEditMode.New)
                    {
                        //this.axVLCPlugin21.Visible = true;
                        this.videoInbound.Visible = true;
                        this.picInbound.Visible = false;

                        string Camera;
                        string Password;
                        Camera = row.Inbound_Camera_IP_Address;
                        Password = row.Inbound_Camera_Admin_Pass;
                             
                        
                        if (Properties.Settings.Default.UseInboundCamera)
                        {
                            InboundCameraString = "rtsp://admin:" + row.Inbound_Camera_Admin_Pass + "@" + row.Inbound_Camera_IP_Address + "/h264/ch1/main/av_stream";

                            videoInbound.MediaPlayer = _mediaPlayer;

                            videoInbound.Visible = true;
                            var inboundMedia = new Media(_libVLC, InboundCameraString);
                            videoInbound.MediaPlayer.Play(inboundMedia);
                            this.picInbound.Visible = false;
                            this.picOutbound.Visible = false;
                            //this.axVLCPlugin21.playlist.stop();
                            //this.axVLCPlugin21.playlist.items.clear();
                            //axVLCPlugin21.Toolbar = false;
                            //this.axVLCPlugin21.playlist.add("rtsp://admin:" + Password + "@" + Camera + "/h264/ch1/main/av_stream");

                            //this.axVLCPlugin21.playlist.play();
                        }
                        else
                        {
                            this.videoInbound.Visible = false;
                            this.picInbound.Visible = false;
                        }
                    }
                    else if (EditMode == enumEditMode.Finish )
                    {
                        //this.axVLCPlugin21.Visible = true;
                        this.videoInbound.Visible = false;
                        this.videoOutbound.Visible = true;
                        this.picInbound.Visible = true;
                        this.picOutbound.Visible = false;
                        string Camera;
                        string Password;
                        Camera = row.Outbound_Camera_IP_Address;
                        Password = row.Outbound_Camera_Admin_Pass;

                        if (Properties.Settings.Default.UseOutboundCamera)
                        {
                            OutboundCameraString = "rtsp://admin:" + row.Outbound_Camera_Admin_Pass + "@" + row.Outbound_Camera_IP_Address + "/h264/ch1/main/av_stream";

                            videoOutbound.MediaPlayer = _mediaPlayer;

                            var outboundMedia = new Media(_libVLC, OutboundCameraString);
                            videoOutbound.MediaPlayer.Play(outboundMedia);

                            //this.axVLCPlugin22.playlist.stop();
                            //this.axVLCPlugin22.playlist.items.clear();
                            //axVLCPlugin22.Toolbar = false;
                            //this.axVLCPlugin22.playlist.add("rtsp://admin:" + Password + "@" + Camera + "/h264/ch1/main/av_stream");
                            //this.axVLCPlugin22.Top = this.picOutbound.Top;
                            //this.picOutbound.Visible = false;
                            //this.axVLCPlugin22.playlist.play();

                        }
                        else
                        {
                            this.videoOutbound.Visible = false;
                        }
                        try
                        {
                            picInbound.Image = Image.FromFile(this.vwTicket_InformationRow.Inbound_Picture);//  Image.FromStream(Ims);
                        }
                        catch
                        {

                        }

                    }

                    else
                    {
                        this.videoInbound.Visible = false;
                        this.videoOutbound.Visible = false;
                        this.picInbound.Visible = true;
                        this.picOutbound.Visible = true;


                        try
                        {
                            picInbound.Image = Image.FromFile(this.vwTicket_InformationRow.Inbound_Picture);//  Image.FromStream(Ims);
                        }
                        catch
                        {

                        }

                        try
                        {
                            picOutbound.Image = Image.FromFile(this.vwTicket_InformationRow.Outbound_Picture);//  Image.FromStream(Ims);
                        }
                        catch
                        {

                        }
                                                
                        if (this.EditMode== enumEditMode.EditInbound )
                        {
                            this.picOutbound.Visible = false;
                            
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Setting Picture " + ex.Message);

                }
            }
        }

        public void UpdateLists()
        {
            
            
            this.binListTableAdapter.Fill(this.Seed_Storage_Dataset.BinList);
            this.varietiesTableAdapter.Fill(this.Seed_Storage_Dataset.Varieties);
            this.customer_ListTableAdapter.Fill(this.Seed_Storage_Dataset.Customer_List);
            this.driversTableAdapter.Fill(this.Seed_Storage_Dataset.Drivers);
            this.weighMastersTableAdapter.Fill(this.Seed_Storage_Dataset.WeighMasters);
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.seed_StorageDataSet);

        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Seed_Storage_Dataset.Shipping' table. You can move, or remove it, as needed.
            this.shippingTableAdapter.Fill(this.Seed_Storage_Dataset.Shipping);
            // TODO: This line of code loads data into the 'Seed_Storage_Dataset.WeighMasters' table. You can move, or remove it, as needed.

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

        }



        private void tmrInbound_Tick(object sender, EventArgs e)
        {
            this.time_InLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool OK = true;
            
            if ((EditMode == enumEditMode.New || EditMode == enumEditMode.Finish))
            {
                if (Properties.Settings.Default.ConnectionType == "SMA")
                {
                    if ((SmaScale.CurrentScaleData.CurrentStatus != SMA.ScaleData.enumStatus.OK) && this.ManualWeight == false)

                    {
                        Alert.Show("Scale Error");
                        OK = false;

                    }

                    else if (SmaScale.CurrentScaleData.Motion)
                    {
                        Alert.Show("Motion On Scale ");
                        OK = false;
                    }
                }
                else
                {
                    if ((SerialScale.ScaleStatus != "") && this.ManualWeight == false)

                    {
                        Alert.Show("Scale Error");
                        OK = false;
                    }

                    else if (SerialScale.Motion)
                    {
                        Alert.Show("Motion On Scale ");
                        OK = false;
                    }
                }
                
            }

            if (OK)
            {
                if (string.IsNullOrEmpty(this.Truck_IDtextbox.Text))
                {
                    Alert.Show("You Must Enter A Truck Id");
                    OK = false;
                    this.Truck_IDtextbox.Focus();
                }
                else
                {
                    int? Ticket = null;
                    if (this.vwTicket_InformationRow != null)
                    {
                        Ticket = vwTicket_InformationRow.Ticket;

                    }
                    if ((EditMode == enumEditMode.New || EditMode == enumEditMode.EditInbound) && (validation.IsTruckInYard(this.Truck_IDtextbox.Text, Ticket)))
                    {
                        Alert.Show("There Is Already A Truck Named " + this.Truck_IDtextbox.Text + " In The Yard. Change The Truck ID");
                        OK = false;
                        this.Truck_IDtextbox.Focus();
                    }

                }
            }
            if (OK)
            {
                if (string.IsNullOrEmpty(this.growerComboBox.Text))
                {
                    Alert.Show("You Must Select A Grower");
                    this.growerComboBox.Focus();
                }
                else if (this.binComboBox.SelectedIndex == -1)
                {
                    Alert.Show("You Must Select A Bin");
                    this.binComboBox.Focus();
                }
                else if (string.IsNullOrEmpty(this.lotTextBox.Text))
                {
                    Alert.Show("You Must Enter A Lot");
                    this.lotTextBox.Focus();
                }

                else
                {
                    Wait.ShowWait("Saving Ticket");
                    if (this.vwTicket_InformationRow == null)
                    {
                        int Ticket = Tickets.CreateNewShippingTicket(this.growerComboBox.Text, this.binComboBox.Text, this.lblVariety.Text, this.lotTextBox.Text, this.driverComboBox.Text,this.Truck_IDtextbox.Text, this.CurrentWeight,this.ckDriverOn.Checked  ,this.txtBushTicket.Text,rtbComment.Text,this.cboWeighmaster.Text   );
                    }
                    else
                    {
                        Tickets.UpdateShippingTicket(this.vwTicket_InformationRow.Ticket,this.growerComboBox.Text, this.binComboBox.Text, this.lblVariety.Text, this.lotTextBox.Text, this.driverComboBox.Text, this.Truck_IDtextbox.Text,this.ckDriverOn.Checked,this.txtBushTicket.Text, rtbComment.Text,this.cboWeighmaster.Text );
                        if (EditMode== enumEditMode.Finish  )
                        {
                            Tickets.UpdateOutboundTicketWeight(vwTicket_InformationRow.Ticket, this.CurrentWeight);
                            Printing.PrintShippingTicket(vwTicket_InformationRow.Ticket, 2);
                        }
                    }

                    Wait.Hide();
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    
                }
            }
        }


        private void tmrOutbound_Tick(object sender, EventArgs e)
        {
            this.time_OutLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();                        
        }

        private void UpdateGTN()
        {
                if (this.vwTicket_InformationRow != null)
                {
                    if (!this.vwTicket_InformationRow.IsOut_WeightNull())
                    {
                        if (this.vwTicket_InformationRow.In_Weight > this.vwTicket_InformationRow.Out_Weight)
                        {
                            this.vwTicket_InformationRow.Gross = this.vwTicket_InformationRow.In_Weight;
                            this.vwTicket_InformationRow.Tare = this.vwTicket_InformationRow.Out_Weight;
                        }
                        else
                        {
                            this.vwTicket_InformationRow.Gross = this.vwTicket_InformationRow.In_Weight;
                            this.vwTicket_InformationRow.Tare = this.vwTicket_InformationRow.Out_Weight;
                        }
                        this.vwTicket_InformationRow.Net = Math.Abs(this.vwTicket_InformationRow.Gross - this.vwTicket_InformationRow.Tare);
                    }
                }
        }



        private void UpdateWeight()
        {
            UpdateGTN();
            if (this.EditMode== enumEditMode.EditOutbound || this.EditMode == enumEditMode.Finish )
            {
                if (this.EditMode == enumEditMode.EditOutbound)
                {
                    this.in_WeightLabel1.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.In_Weight);
                    this.out_WeightLabel1.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Out_Weight);
                    if (this.vwTicket_InformationRow.Gross < this.vwTicket_InformationRow.Tare)
                    {
                        this.lblGross.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Tare);
                        this.lblTare.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Gross);
                    }
                    else
                    {
                        this.lblGross.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Gross);
                        this.lblTare.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Tare);
                    }
                    
                    this.lblNet.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Net);

                }
                else if (this.EditMode== enumEditMode.Finish )
                {
                    this.in_WeightLabel1.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.In_Weight);
                    this.out_WeightLabel1.Text = string.Format("{0:N0}", CurrentWeight );
                    int G;
                    int T;
                    int N;
                    if (CurrentWeight  > this.vwTicket_InformationRow.In_Weight)
                    {
                        G = CurrentWeight;
                        T = (int)this.vwTicket_InformationRow.In_Weight;
                    }
                    else
                    {
                        G = (int)this.vwTicket_InformationRow.In_Weight;
                        T = CurrentWeight;
                    }
                    N = Math.Abs(G - T);
                    this.lblGross.Text = string.Format("{0:N0}", G);
                    this.lblTare.Text = string.Format("{0:N0}", T);
                    this.lblNet.Text = string.Format("{0:N0}", N);
                }
            }
        }

        private void binComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.binComboBox.SelectedIndex == -1)
            {
                
                this.lblVariety.Text = "";
            }
            else
            {
                this.lblVariety.Text = this.binComboBox.SelectedValue.ToString();
            }
        }

        private void growerComboBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void binComboBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void binComboBox_Validated(object sender, EventArgs e)
        {
          
        }

        private void SmaScale_ScaleDataRecieved(object sender, EventArgs e)
        {
            if (!ManualWeight)
            {
                SetWeightText();
            }
        }

        private void SerialScale_StatusChanged()
        {
            if (!ManualWeight)
            {
                SetWeightText();
            }
        }

        private void SetWeightText()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblMotion.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetWeightText);
                this.Invoke(d, new object[] { });
            }
            else
            {
                GetData();
                UpdateWeight();
            }
        }

        private void GetData()
        {
            if (Properties.Settings.Default.ConnectionType == "SMA")
            {
                if (SmaScale.ConnectionStatus == SMA.enumConnectionStatus.Ok)
                {

                    this.lblMotion.Visible = true;

                    if (this.SmaScale.CurrentScaleData.CurrentStatus != SMA_Command_LIB.SMA.ScaleData.enumStatus.OK)
                    {
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblMotion.BackColor = System.Drawing.Color.Red;
                        this.lblMotion.ForeColor = System.Drawing.Color.White;
                        this.lblMotion.Text = this.SmaScale.ConnectionStatusString;
                        this.CurrentWeight = 0;
                        this.lblScaleWeight.Text = "------";
                        this.lblConnectionStatus.Text = "  ";

                    }
                    else
                    {
                        this.CurrentWeight = this.SmaScale.CurrentScaleData.CurWeight;
                        this.lblConnectionStatus.Text = SmaScale.CurrentScaleData.CurrentStatusChar;
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        if (this.SmaScale.CurrentScaleData.Motion)
                        {
                            this.lblMotion.BackColor = System.Drawing.Color.Blue;
                            this.lblMotion.ForeColor = System.Drawing.Color.White;
                            this.lblMotion.Text = "Motion";
                        }
                        else
                        {
                            this.lblMotion.Visible = false;

                        }

                    }
                    this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", this.CurrentWeight);


                }
                else
                {
                    this.CurrentWeight = 0;
                    this.lblScaleWeight.Text = "";
                    this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.lblMotion.BackColor = System.Drawing.Color.Red;
                    this.lblMotion.ForeColor = System.Drawing.Color.White;
                    this.lblMotion.Text = "Not Connected";
                    this.lblScaleWeight.Text = "------";
                    lblConnectionStatus.Text = "  ";
                }
            }
            else
            {
                if (SerialScale.Connected == true)
                {

                    this.lblMotion.Visible = true;
                    this.lblConnectionStatus.Text = SerialScale.ScaleStatusChar;

                    if (this.SerialScale.ScaleStatus != "" && this.SerialScale.ScaleStatus != "Motion")
                    {
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblMotion.BackColor = System.Drawing.Color.Red;
                        this.lblMotion.ForeColor = System.Drawing.Color.White;
                        this.lblMotion.Text = SerialScale.ScaleStatus;
                        this.CurrentWeight = 0;
                        this.lblScaleWeight.Text = "------";
                    }
                    else
                    {
                        this.CurrentWeight = (int)SerialScale.Weight;
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        if (this.SerialScale.ScaleStatus == "Motion")
                        {
                            this.lblMotion.BackColor = System.Drawing.Color.Blue;
                            this.lblMotion.ForeColor = System.Drawing.Color.White;
                            this.lblMotion.Text = "Motion";
                        }
                        else
                        {
                            this.lblMotion.Visible = false;

                        }

                    }
                    
                }
                else
                {
                    
                    this.CurrentWeight = 0;
                    this.lblScaleWeight.Text = "";
                    this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.lblMotion.BackColor = System.Drawing.Color.Red;
                    this.lblMotion.ForeColor = System.Drawing.Color.White;
                    this.lblMotion.Text = "Not Connected";
                    this.lblScaleWeight.Text = "------";
                    this.lblConnectionStatus.Text = "  ";

                }

                this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", this.CurrentWeight);

            }


        }

        private void frmShipping_Activated(object sender, EventArgs e)
        {
            Wait.Hide();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Truck_IDtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ctlbox_KeyUp(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void growerComboBox_Leave(object sender, EventArgs e)
        {
            if (this.growerComboBox.SelectedIndex == -1)
            {
                this.growerComboBox.Text = "";

            }
            ComboBox tb = (ComboBox)sender;
            tb.BackColor = Color.White;
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow; 
        }

        private void textbox_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            ComboBox  tb = (ComboBox)sender;
            tb.BackColor = Color.White;
        }

        private void ComboBox_Enter(object sender, EventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void driverComboBox_Leave(object sender, EventArgs e)
        {

            ComboBox tb = (ComboBox)sender;
            tb.BackColor = Color.White;
        }

        private void binComboBox_Leave(object sender, EventArgs e)
        {
            if (this.binComboBox.SelectedIndex == -1)
            {
                this.binComboBox.Text = "";

            }
            ComboBox tb = (ComboBox)sender;
            tb.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ManualWeight && (EditMode== enumEditMode.New || EditMode== enumEditMode.Finish ))
            {
                this.btnManualWeight.Text = "Manual Weight";
                this.ManualWeight = false;
                SetWeightText();
            }
            else
            {
                int Wt = this.SmaScale.CurrentScaleData.CurWeight;
                if (EditMode != enumEditMode.New && EditMode != enumEditMode.Finish) Wt = (int)vwTicket_InformationRow.In_Weight; 

                using (frmManualWeight frm = new frmManualWeight(Wt))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ManualWeight = true;
                        this.CurrentWeight = frm.Weight;
                        if (EditMode == enumEditMode.New || EditMode == enumEditMode.Finish)
                        {
                            this.btnManualWeight.Text = "Use Scale";
                            this.lblMotion.Visible = true;
                            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            this.lblMotion.BackColor = System.Drawing.Color.Yellow;
                            this.lblMotion.ForeColor = System.Drawing.Color.Black;
                            this.lblMotion.Text = "Manual";
                        }
                        else if (EditMode== enumEditMode.EditInbound  )
                        {
                            Tickets.UpdateInboundTicketWeight(vwTicket_InformationRow.Ticket, frm.Weight);

                        }


                        this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", this.CurrentWeight);
                        UpdateWeight();
                    }
                }
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            GetData();
        }

        private void picOutbound_Click(object sender, EventArgs e)
        {

        }

        private void picInbound_Click(object sender, EventArgs e)
        {
            using (frmTicketDetails frm = new frmTicketDetails(this.vwTicket_InformationRow.Ticket))
            {
                frm.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Alert.Show(string.Format("Delete Ticket {0} ?", this.vwTicket_InformationRow.Ticket), frmAlert.enumButtonStyle.YesNo) == DialogResult.Yes)
            {
                using (Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                {
                    try
                    {
                        Q.DeleteTicket(this.vwTicket_InformationRow.Ticket);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Alert.Show("Error Deleting Ticket " + ex.Message);

                    }
                    

                }

            }

        }

        private void lnkEditInbound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmManualWeight frm = new frmManualWeight((int)this.vwTicket_InformationRow.In_Weight))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ManualWeight = true;

                    this.vwTicket_InformationRow.In_Weight = frm.Weight;
                    {
                        Tickets.UpdateInboundTicketWeight(vwTicket_InformationRow.Ticket, frm.Weight);

                    }
                    UpdateWeight();
                }
            }
        }

        private void lnkEditOutbound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmManualWeight frm = new frmManualWeight((int)this.vwTicket_InformationRow.Out_Weight))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ManualWeight = true;

                    this.vwTicket_InformationRow.Out_Weight = frm.Weight;
                    {
                        Tickets.UpdateOutboundTicketWeight(vwTicket_InformationRow.Ticket, frm.Weight);

                    }
                    UpdateWeight();
                }
            }
        }

        private void growerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboWeighmaster_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblVariety_Click(object sender, EventArgs e)
        {

        }

        private void binLabel_Click(object sender, EventArgs e)
        {

        }

        private void lotLabel_Click(object sender, EventArgs e)
        {

        }

        private void lotTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void growerLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void driverLabel_Click(object sender, EventArgs e)
        {

        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
