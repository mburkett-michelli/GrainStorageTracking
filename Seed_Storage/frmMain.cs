using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using Scale_Connection;


namespace Seed_Storage
{
    public partial class Form1 : Form
    {
        
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        public bool Streaming = false;
        
        public string InboundCameraString;
        public string OutboundCameraString;
        public int ScaleWeight;

        public string connectionType = "SMA";
        public string serialPort = "COM4";
        public int serialInterval = 1000;

        delegate void SetTextCallback();

        SMA_Command_LIB.SMA SMA;

        public Scale_Connection.Serial_Connection SerialScale;
        

        public Form1()
        {
           

            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            GetSetup();
            
            this.Text = "Grain Inventory Tracking vers" + Application.ProductVersion.ToString();
        }

        private void SerialScale_StatusChanged()
        {
            GetData();
        }


        private void GetSetup()
        {

            connectionType = Properties.Settings.Default.ConnectionType;

            if (connectionType == "Serial")
            {
                serialPort = Properties.Settings.Default.SerialComPort;                
            }
            else
            {
                connectionType = "SMA";
            }

            using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
            {
                using (Seed_Storage_Dataset Seed_Storage_Dataset = new Seed_Storage_Dataset())
                {

                    System_SetupTableAdapter.Fill(Seed_Storage_Dataset.System_Setup);
                    Seed_Storage_Dataset.System_SetupRow row = Seed_Storage_Dataset.System_Setup[0];
                    try
                    {

                        if (connectionType == "SMA")
                        {
                            SMA = new SMA_Command_LIB.SMA(row.Scale_IP_Address, row.Scale_Port);
                            SMA.ScaleConnected += this.ScaleConnected;
                            SMA.ScaleConnecting += this.ScaleConnecting;
                            SMA.ScaleDataRecieved += this.ScaleDataRecieved;
                            SMA.Connect(row.Update_Rate);
                        }
                        else
                        {
                            serialInterval = Properties.Settings.Default.SerialInterval;
                            if (serialInterval < 800)
                            {
                                serialInterval = 800;
                            }
                                    
                            tmrUpdate.Interval = serialInterval;
                            int scaleInterval = serialInterval / 2;
                            SerialScale = new Serial_Connection(serialPort, "Condec", scaleInterval, false);
                            SerialScale.StatusChanged += SerialScale_StatusChanged;
                            SerialScale.Connect();
                            tmrUpdate.Enabled = true;
                        }

                        try
                        {
                            if (Properties.Settings.Default.UseInboundCamera)
                            {
                                InboundCameraString = "rtsp://admin:" + row.Inbound_Camera_Admin_Pass + "@" + row.Inbound_Camera_IP_Address + "/h264/ch1/main/av_stream";

                                videoInbound.MediaPlayer = _mediaPlayer;

                                videoInbound.Visible = true;
                                var inboundMedia = new Media(_libVLC, InboundCameraString);
                                videoInbound.MediaPlayer.Play(inboundMedia);
                                //this.axVLCPlugin21.Visible = true;
                                //this.axVLCPlugin21.playlist.stop();
                                //this.axVLCPlugin21.playlist.items.clear();
                                //axVLCPlugin21.Toolbar = false;
                                //this.axVLCPlugin21.playlist.add("rtsp://admin:" + row.Inbound_Camera_Admin_Pass + "@" + row.Inbound_Camera_IP_Address + "/h264/ch1/main/av_stream");

                                //this.axVLCPlugin21.playlist.play();
                            }
                            else
                            {
                                videoInbound.Visible = false;
                                //this.axVLCPlugin21.Visible = false;
                            }

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show("Error accessing Inbound camera " + ex1.Message);
                        }
                        try
                        {
                            if (Properties.Settings.Default.UseOutboundCamera)
                            {
                                OutboundCameraString = "rtsp://admin:" + row.Outbound_Camera_Admin_Pass + "@" + row.Outbound_Camera_IP_Address + "/h264/ch1/main/av_stream";

                                videoOutbound.MediaPlayer = _mediaPlayer;
                                videoOutbound.Visible = true;
                                var outboundMedia = new Media(_libVLC, OutboundCameraString);
                                videoOutbound.MediaPlayer.Play(outboundMedia);

                                //this.axVLCPlugin22.Visible = true;
                                //this.axVLCPlugin22.playlist.stop();
                                //this.axVLCPlugin22.playlist.items.clear();
                                //axVLCPlugin22.Toolbar = false;
                                //this.axVLCPlugin22.playlist.add("rtsp://admin:" + row.Outbound_Camera_Admin_Pass + "@" + row.Outbound_Camera_IP_Address + "/h264/ch1/main/av_stream");

                                //this.axVLCPlugin22.playlist.play();
                            }
                            else
                            {
                                videoOutbound.Visible = false;
                                //this.axVLCPlugin22.Visible = false;
                            }

                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show("Error accessing Outbound camera " + ex2.Message);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error With System Setup " + ex.Message);

                    }
                }
            }

        }


        private void ScaleConnected(object sender, EventArgs e)
        {
            SetText();
        }


        private void ScaleConnecting(object sender, EventArgs e)
        {
            SetText();
        }


        private void ScaleDataRecieved(object sender, EventArgs e)
        {
            SetText();
        }


        private void SetText()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblMotion.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { });
            }
            else
            {
                GetData();
            }
        }

        private void GetData()
        {
            if (this.lblMotion.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { });
            }
            else
            {

                if (connectionType == "SMA")
                {
                    if (SMA.IsRunning)
                    {

                        this.lblMotion.Visible = true;
                        if (this.SMA.CurrentScaleData.CurrentStatus != SMA_Command_LIB.SMA.ScaleData.enumStatus.OK)
                        {
                            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            this.lblMotion.BackColor = System.Drawing.Color.Red;
                            this.lblMotion.ForeColor = System.Drawing.Color.White;
                            this.lblMotion.Text = this.SMA.ConnectionStatusString;
                        }
                        else
                        {
                            this.lblConnectionStatus.Text = this.SMA.CurrentScaleData.CurrentStatusChar;

                            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            if (this.SMA.CurrentScaleData.Motion)
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

                        ScaleWeight = this.SMA.CurrentScaleData.CurWeight;

                    }
                    else
                    {
                        ScaleWeight = 0;
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblMotion.BackColor = System.Drawing.Color.Red;
                        this.lblMotion.ForeColor = System.Drawing.Color.White;
                        this.lblMotion.Text = "Not Connected";
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

                            if (SerialScale.Motion == true)
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
                        else
                        {
                            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            if (SerialScale.Motion)
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

                        ScaleWeight = Convert.ToInt32(SerialScale.Weight);

                    }
                    else
                    {
                        ScaleWeight = 0;
                        this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.lblMotion.BackColor = System.Drawing.Color.Red;
                        this.lblMotion.ForeColor = System.Drawing.Color.White;
                        this.lblMotion.Text = "Not Connected";
                    }
                }

                this.lblScaleWeight.Text = string.Format("{0:N0} lbs.", ScaleWeight);


                if (ScaleWeight > 2000 && !Streaming)
                {
                    if (Properties.Settings.Default.UseInboundCamera)
                    {
                        Streaming = true;

                        var inboundMedia = new Media(_libVLC, InboundCameraString);
                        videoInbound.MediaPlayer.Play(inboundMedia);
                        videoInbound.Visible = true;

                        var outboundMedia = new Media(_libVLC, OutboundCameraString);
                        videoOutbound.MediaPlayer.Play(outboundMedia);
                        videoOutbound.Visible = true;

                        //this.axVLCPlugin21.playlist.play();
                        //this.axVLCPlugin22.playlist.play();
                    }


                }
                else if (ScaleWeight <= 2000 && Streaming)
                {
                    if (Properties.Settings.Default.UseOutboundCamera)
                    {
                        Streaming = false;

                        videoInbound.MediaPlayer.Stop();
                        videoOutbound.MediaPlayer.Stop();

                        //this.axVLCPlugin21.playlist.stop();
                        //this.axVLCPlugin22.playlist.stop();
                    }

                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Wait.ShowWait("Creating Ticket");
            
            if (Properties.Settings.Default.ConnectionType == "SMA")
            {
                using (frmShipping frm = new frmShipping(this.SMA))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
            else
            {
                using (frmShipping frm = new frmShipping(this.SerialScale))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
            
        }

 
        private void button3_Click(object sender, EventArgs e)
        {
            using (FrmFinishTicket frm = new FrmFinishTicket())
            {
               if  (frm.ShowDialog()== System.Windows.Forms.DialogResult.OK)
               {
                    if (frm.SelectedRow.Load_Type == "Outbound")
                    {
                        frmShipping.enumEditMode EditMode = frmShipping.enumEditMode.Finish ;
                        if (frm.SelectionMode== FrmFinishTicket.enumSelectionMode.Edit )
                        {
                            EditMode = frmShipping.enumEditMode.EditInbound; 
                        }
                        if (Properties.Settings.Default.ConnectionType == "SMA")
                        {
                            using (frmShipping ShippingForm = new frmShipping(frm.SelectedRow.Ticket, SMA, EditMode))
                            {

                                if (ShippingForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    ShippingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        else
                        {
                            using (frmShipping ShippingForm = new frmShipping(frm.SelectedRow.Ticket, SerialScale, EditMode))
                            {

                                if (ShippingForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    ShippingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        
                    }
                    if (frm.SelectedRow.Load_Type == "Inbound")
                    {
                        frmRecieving.enumEditMode EditMode = frmRecieving.enumEditMode.Finish;
                        if (frm.SelectionMode == FrmFinishTicket.enumSelectionMode.Edit)
                        {
                            EditMode = frmRecieving.enumEditMode.EditInbound;
                        }
                        if (Properties.Settings.Default.ConnectionType == "SMA")
                        {
                            using (frmRecieving RecievingForm = new frmRecieving(frm.SelectedRow.Ticket, SMA, EditMode))
                            {
                                if (RecievingForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    RecievingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        else
                        {
                            using (frmRecieving RecievingForm = new frmRecieving(frm.SelectedRow.Ticket, SerialScale, EditMode))
                            {
                                if (RecievingForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    RecievingForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        
                    }
                    if (frm.SelectedRow.Load_Type == "Other")
                    {
                        frmGTNTicket.enumEditMode EditMode = frmGTNTicket.enumEditMode.Finish;
                        if (frm.SelectionMode == FrmFinishTicket.enumSelectionMode.Edit)
                        {
                            EditMode = frmGTNTicket.enumEditMode.EditInbound;
                        }
                        if (Properties.Settings.Default.ConnectionType == "SMA")
                        {
                            using (frmGTNTicket GTNTicketForm = new frmGTNTicket(frm.SelectedRow.Ticket, SMA, EditMode))
                            {
                                if (GTNTicketForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    GTNTicketForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        else
                        {
                            using (frmGTNTicket GTNTicketForm = new frmGTNTicket(frm.SelectedRow.Ticket, SerialScale, EditMode))
                            {
                                if (GTNTicketForm.DialogResult != DialogResult.Cancel)
                                {
                                    Wait.ShowWait("Opening Ticket");
                                    Application.DoEvents();
                                    this.Hide();
                                    GTNTicketForm.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                        
                    }

                }
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPassword frm = new frmPassword())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (frmSetupOptions frmSetup = new frmSetupOptions())
                    {
                        this.Hide();
                        frmSetup.ShowDialog();
                        if (Program.Restart == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.Show();
                        }
                        
                    }
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ConnectionType == "SMA")
                {
                    
                    this.SMA.Stop();
                    this.SMA.Disconnect();
                    
                }
                else
                {
                    this.SerialScale.CloseConnection();
                }
                Dispose();
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encountered closing connection = " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wait.ShowWait("Creating Ticket");

            if (Properties.Settings.Default.ConnectionType == "SMA")
            {
                using (frmRecieving frm = new frmRecieving(this.SMA))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
            else
            {
                using (frmRecieving frm = new frmRecieving(this.SerialScale))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wait.ShowWait("Creating Ticket");

            if (Properties.Settings.Default.ConnectionType == "SMA")
            {
                using (frmGTNTicket frm = new frmGTNTicket(this.SMA))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
            else
            {
                using (frmGTNTicket frm = new frmGTNTicket(this.SerialScale))
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ConnectionType == "SMA")
            {
                using (frmCompletedTickets frm = new frmCompletedTickets(SMA))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //if (frm.SelectedRow.Load_Type == "Outbound")
                        //{
                        //    frmShipping.enumEditMode EditMode = frmShipping.enumEditMode.EditOutbound;

                        //    using (frmShipping ShippingForm = new frmShipping(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        ShippingForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}
                        //if (frm.SelectedRow.Load_Type == "Inbound")
                        //{
                        //    frmRecieving.enumEditMode EditMode = frmRecieving.enumEditMode.EditOutbound ;
                        //    using (frmRecieving RecievingForm = new frmRecieving(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        RecievingForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}
                        //if (frm.SelectedRow.Load_Type == "Other")
                        //{
                        //    frmGTNTicket.enumEditMode EditMode = frmGTNTicket.enumEditMode.EditOutbound;
                        //    using (frmGTNTicket GTNTicketForm = new frmGTNTicket(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        GTNTicketForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}

                    }
                }
            }
            else
            {
                using (frmCompletedTickets frm = new frmCompletedTickets(SerialScale))
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //if (frm.SelectedRow.Load_Type == "Outbound")
                        //{
                        //    frmShipping.enumEditMode EditMode = frmShipping.enumEditMode.EditOutbound;

                        //    using (frmShipping ShippingForm = new frmShipping(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        ShippingForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}
                        //if (frm.SelectedRow.Load_Type == "Inbound")
                        //{
                        //    frmRecieving.enumEditMode EditMode = frmRecieving.enumEditMode.EditOutbound ;
                        //    using (frmRecieving RecievingForm = new frmRecieving(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        RecievingForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}
                        //if (frm.SelectedRow.Load_Type == "Other")
                        //{
                        //    frmGTNTicket.enumEditMode EditMode = frmGTNTicket.enumEditMode.EditOutbound;
                        //    using (frmGTNTicket GTNTicketForm = new frmGTNTicket(frm.SelectedRow.Ticket, SMA, EditMode))
                        //    {

                        //        Wait.ShowWait("Opening Ticket");
                        //        Application.DoEvents();
                        //        this.Hide();
                        //        GTNTicketForm.ShowDialog();
                        //        this.Show();
                        //    }
                        //}

                    }
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (frmBinInventory frm = new frmBinInventory())
            {
                frm.ShowDialog();
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            GetData();
        }

        
    }
}
