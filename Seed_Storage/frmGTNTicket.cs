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
using Scale_Connection;

namespace Seed_Storage
{
    public partial class frmGTNTicket : Form
    {
        delegate void SetTextCallback();
        public SMA_Command_LIB.SMA SmaScale;
        public Scale_Connection.Serial_Connection SerialScale;
        
        public Seed_Storage.Seed_Storage_Dataset.vwTicket_InformationRow vwTicket_InformationRow;

        private string OriginalValue = string.Empty;
                
        private bool ManualWeight;
        int CurrentWeight;

        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        public string InboundCameraString;
        public string OutboundCameraString;


        public enum enumEditMode { New,EditInbound,Finish,EditOutbound};
        public Seed_Storage_Dataset.GTN_TicketRow  GTN_TicketRow;

        public enumEditMode EditMode;

        public frmGTNTicket(SMA_Command_LIB.SMA  CurrentScale)
        {
            InitializeComponent();
            EditMode = enumEditMode.New;
            //.Toolbar = false;

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            SmaScale = CurrentScale;
            SmaScale.ScaleDataRecieved += SmaScale_ScaleDataRecieved;
            this.tmrInbound.Start();
            SetCameras();
            ManualWeight = false;
            UpdateLists();
            this.driverComboBox.SelectedIndex =-1;
            this.CustomerComboBox.SelectedIndex = 0;
            this.btnDelete.Visible = false;
            this.button1.Text = "Create Ticket";


        }

        public frmGTNTicket(Serial_Connection CurrentScale)
        {
            InitializeComponent();
            EditMode = enumEditMode.New;
            //.Toolbar = false;

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            SerialScale = CurrentScale;
            SerialScale.StatusChanged += SerialScale_StatusChanged;
            this.tmrInbound.Start();
            SetCameras();
            ManualWeight = false;
            UpdateLists();
            this.driverComboBox.SelectedIndex = -1;
            this.CustomerComboBox.SelectedIndex = 0;
            this.btnDelete.Visible = false;
            this.button1.Text = "Create Ticket";


        }

        /// <summary>
        /// Edit Or Finish a ticket
        /// </summary>
        /// <param name="Ticket">Ticket Number</param>
        /// <param name="CurrentScale">Pass the SMA Scale</param>
        /// <param name="Mode">EditInbound,Finish,EditOutbound DONT USE NEW</param>
        public frmGTNTicket(int Ticket,SMA_Command_LIB.SMA CurrentScale,enumEditMode Mode)
        {
            InitializeComponent();
            EditMode = Mode;
            //axVLCPlugin21.Toolbar = false;

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

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

                SetupMainForm(Ticket);

            }

            
                UpdateWeight();
        }

        /// <summary>
        /// Edit Or Finish a ticket
        /// </summary>
        /// <param name="Ticket">Ticket Number</param>
        /// <param name="CurrentScale">Pass the SMA Scale</param>
        /// <param name="Mode">EditInbound,Finish,EditOutbound DONT USE NEW</param>
        public frmGTNTicket(int Ticket, Serial_Connection CurrentScale, enumEditMode Mode)
        {
            InitializeComponent();
            EditMode = Mode;
            //axVLCPlugin21.Toolbar = false;

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

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

                SetupMainForm(Ticket);

            }


            UpdateWeight();
        }

        private void SetupMainForm(int Ticket)
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
                    this.vwTicket_InformationRow = this.Seed_Storage_Dataset.vwTicket_Information[0];
                    this.lblHeader.Text = string.Format(" Ticket {0}", this.vwTicket_InformationRow.ID);
                    SetCameras();
                    ManualWeight = true;
                    using (Seed_Storage_DatasetTableAdapters.GTN_TicketTableAdapter GTN_TicketTableAdapter = new Seed_Storage_DatasetTableAdapters.GTN_TicketTableAdapter())
                    {
                        if (GTN_TicketTableAdapter.FillByTicket(this.Seed_Storage_Dataset.GTN_Ticket, Ticket) == 0)
                        {
                            Alert.Show("Cannot Find Information For Ticket " + Ticket.ToString());
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();

                        }
                        else
                        {
                            this.GTN_TicketRow = this.Seed_Storage_Dataset.GTN_Ticket[0];
                            this.vwTicket_InformationRow = Seed_Storage_Dataset.vwTicket_Information[0];
                            this.pnlGTN.Visible = EditMode != enumEditMode.EditInbound;
                            this.Truck_IDtextbox.Text = vwTicket_InformationRow.Truck_ID;

                            this.driverComboBox.Text = this.vwTicket_InformationRow.Driver;
                            this.time_InLabel1.Text = this.vwTicket_InformationRow.Time_In.ToShortDateString() + " " + this.vwTicket_InformationRow.Time_In.ToLongTimeString();
                            this.ckDriverOn.Checked = this.vwTicket_InformationRow.Driver_On;
                            if (!this.GTN_TicketRow.IsCustomerNull()) this.CustomerComboBox.Text = this.GTN_TicketRow.Customer;
                            this.ckDriverOn.Checked = this.vwTicket_InformationRow.Driver_On;
                            if (!this.vwTicket_InformationRow.IsCommentsNull()) this.rtbComment.Text = this.vwTicket_InformationRow.Comments;
                            if (!this.vwTicket_InformationRow.IsTime_OutNull()) this.time_OutLabel1.Text = this.vwTicket_InformationRow.Time_Out.ToShortDateString() + " " + this.vwTicket_InformationRow.Time_Out.ToLongTimeString();
                            this.pnlTimeOut.Visible = (EditMode != enumEditMode.EditInbound);
                            if (EditMode == enumEditMode.EditInbound)
                            {
                                this.btnManualWeight.Text = "Edit Weight";
                                this.CurrentWeight = (int)vwTicket_InformationRow.In_Weight;
                                this.lblMotion.Visible = false;
                                this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", this.CurrentWeight);
                                this.button1.Text = "Save Changes";
                            }
                            else if (EditMode == enumEditMode.EditOutbound)
                            {

                                pnlWeight.Visible = false;
                                this.button1.Text = "Save Changes";
                            }
                            else if (EditMode == enumEditMode.Finish)
                            {

                                this.time_OutLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                                this.tmrOutbound.Enabled = true;
                                this.lnkEditOutbound.Visible = false;
                                ManualWeight = false;
                                this.button1.Text = "PRINT TICKET";
                            }

                            UpdateWeight();

                        }

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
                            //this.axVLCPlugin22.Toolbar = false;
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


                        //                        byte[] OutboundImage = (byte[])vwTicket_InformationRow.Outbound_Picture;
                        //                      MemoryStream Oms = new MemoryStream(OutboundImage);
                        //                    this.picOutbound.Image = Image.FromStream(Oms);
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
            this.gTNCustomersTableAdapter.Fill(this.Seed_Storage_Dataset.GTNCustomers);
            this.driversTableAdapter.Fill(this.Seed_Storage_Dataset.Drivers);
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.seed_StorageDataSet);

        }

        private void GTN_Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Seed_Storage_Dataset.GTNCustomers' table. You can move, or remove it, as needed.

            


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
                    this.Truck_IDtextbox.Focus();
                    OK = false;
                }
                else
                {
                    int? Ticket = null;
                    if (this.vwTicket_InformationRow != null)
                    {
                        Ticket = vwTicket_InformationRow.Ticket;

                    }
                    if ((EditMode == enumEditMode.New || EditMode == enumEditMode.EditInbound ) && (validation.IsTruckInYard(this.Truck_IDtextbox.Text,Ticket )))
                    {
                        Alert.Show("There Is Already A Truck Named " + this.Truck_IDtextbox.Text + " In The Yard. Change The Truck ID");
                        OK = false;
                        this.Truck_IDtextbox.Focus();
                    }

                }
            }
            if (OK)
            {
                {
                    Wait.ShowWait("Saving Ticket");
                    if (this.vwTicket_InformationRow == null)
                    {

                        int Ticket = Tickets.CreateNewGTNTicket(this.CustomerComboBox.Text, this.driverComboBox.Text,this.Truck_IDtextbox.Text, this.CurrentWeight,this.ckDriverOn.Checked   , rtbComment.Text );
                    }
                    else
                    {
                        Tickets.UpdateGTNTicket(this.vwTicket_InformationRow.Ticket,this.CustomerComboBox.Text, this.driverComboBox.Text, this.Truck_IDtextbox.Text,this.ckDriverOn.Checked ,  rtbComment.Text);
                        if (EditMode== enumEditMode.Finish  )
                        {
                            Tickets.UpdateOutboundTicketWeight(vwTicket_InformationRow.Ticket, this.CurrentWeight);
                            Printing.PrintGTNTicket(vwTicket_InformationRow.Ticket, 1);
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
        }



        private void UpdateWeight()
        {
            UpdateGTN();
            if (this.EditMode == enumEditMode.EditOutbound || this.EditMode == enumEditMode.Finish)
            {
                if (this.EditMode == enumEditMode.EditOutbound)
                {
                    this.in_WeightLabel1.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.In_Weight);
                    this.out_WeightLabel1.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Out_Weight);
                    this.lblGross.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Gross);
                    this.lblTare.Text = string.Format("{0:N0}", this.vwTicket_InformationRow.Tare);
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

        private void SerialScale_StatusChanged()
        {
            if (!ManualWeight)
            {
                SetWeightText();
            }
        }


        private void SmaScale_ScaleDataRecieved(object sender, EventArgs e)
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
                if (SmaScale.IsRunning)
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
                if (SerialScale.Connected)
                {

                    this.lblMotion.Visible = true;
                    this.lblConnectionStatus.Text = SerialScale.ScaleStatusChar;

                    if (this.SerialScale.ScaleStatus != "" && this.SerialScale.ScaleStatus != "Motion")
                    {
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblMotion.BackColor = System.Drawing.Color.Red;
                        this.lblMotion.ForeColor = System.Drawing.Color.White;
                        this.lblMotion.Visible = false;
                        this.CurrentWeight = 0;
                        this.lblScaleWeight.Text = "------";
                        
                    }
                    else
                    {
                        this.CurrentWeight = Convert.ToInt32(SerialScale.Weight);
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        if (SerialScale.Motion==true)
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
        }

        private void frmGTNTicket_Activated(object sender, EventArgs e)
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

      

        private void textbox_Enter(object sender, EventArgs e)
        {
            
            TextBox tb = (TextBox)sender;
            OriginalValue = tb.Text;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBushTicket_Enter(object sender, EventArgs e)
        {

        }

        private void txtBushNetWeight_Leave(object sender, EventArgs e)
        {

        }
    }
}
