namespace Seed_Storage
{
    partial class frmGTNTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label driverLabel;
            System.Windows.Forms.Label time_InLabel;
            System.Windows.Forms.Label time_OutLabel;
            System.Windows.Forms.Label in_WeightLabel;
            System.Windows.Forms.Label out_WeightLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label binLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.growersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time_InLabel1 = new System.Windows.Forms.Label();
            this.time_OutLabel1 = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMotion = new System.Windows.Forms.Label();
            this.lblScaleWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picOutbound = new System.Windows.Forms.PictureBox();
            this.tmrInbound = new System.Windows.Forms.Timer(this.components);
            this.tmrOutbound = new System.Windows.Forms.Timer(this.components);
            this.pnlTimeOut = new System.Windows.Forms.Panel();
            this.varietiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varietiesTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter();
            this.binListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.in_WeightLabel1 = new System.Windows.Forms.Label();
            this.out_WeightLabel1 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblTare = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblBushels = new System.Windows.Forms.Label();
            this.pnlGTN = new System.Windows.Forms.Panel();
            this.lnkEditOutbound = new System.Windows.Forms.LinkLabel();
            this.lnkEditInbound = new System.Windows.Forms.LinkLabel();
            this.Truck_IDtextbox = new System.Windows.Forms.TextBox();
            this.driversTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.DriversTableAdapter();
            this.customer_ListTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.Customer_ListTableAdapter();
            this.binListTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.BinListTableAdapter();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.btnManualWeight = new System.Windows.Forms.Button();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.picInbound = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.gTNCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gTNCustomersTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.GTNCustomersTableAdapter();
            this.ckDriverOn = new System.Windows.Forms.CheckBox();
            this.videoInbound = new LibVLCSharp.WinForms.VideoView();
            this.videoOutbound = new LibVLCSharp.WinForms.VideoView();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            time_InLabel = new System.Windows.Forms.Label();
            time_OutLabel = new System.Windows.Forms.Label();
            in_WeightLabel = new System.Windows.Forms.Label();
            out_WeightLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            binLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutbound)).BeginInit();
            this.pnlTimeOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binListBindingSource)).BeginInit();
            this.pnlGTN.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTNCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).BeginInit();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            driverLabel.AutoSize = true;
            driverLabel.Location = new System.Drawing.Point(56, 182);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(88, 29);
            driverLabel.TabIndex = 3;
            driverLabel.Text = "Driver:";
            // 
            // time_InLabel
            // 
            time_InLabel.Location = new System.Drawing.Point(593, 36);
            time_InLabel.Name = "time_InLabel";
            time_InLabel.Size = new System.Drawing.Size(130, 29);
            time_InLabel.TabIndex = 7;
            time_InLabel.Text = "Time In:";
            time_InLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // time_OutLabel
            // 
            time_OutLabel.Location = new System.Drawing.Point(11, 6);
            time_OutLabel.Name = "time_OutLabel";
            time_OutLabel.Size = new System.Drawing.Size(130, 29);
            time_OutLabel.TabIndex = 9;
            time_OutLabel.Text = "Time Out:";
            time_OutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // in_WeightLabel
            // 
            in_WeightLabel.Location = new System.Drawing.Point(32, 17);
            in_WeightLabel.Name = "in_WeightLabel";
            in_WeightLabel.Size = new System.Drawing.Size(151, 29);
            in_WeightLabel.TabIndex = 26;
            in_WeightLabel.Text = "In Weight:";
            in_WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_WeightLabel
            // 
            out_WeightLabel.Location = new System.Drawing.Point(32, 49);
            out_WeightLabel.Name = "out_WeightLabel";
            out_WeightLabel.Size = new System.Drawing.Size(151, 29);
            out_WeightLabel.TabIndex = 27;
            out_WeightLabel.Text = "Out Weight:";
            out_WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(32, 102);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(151, 29);
            label5.TabIndex = 29;
            label5.Text = "Gross:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(32, 133);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(151, 29);
            label7.TabIndex = 31;
            label7.Text = "Tare:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(32, 178);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(151, 29);
            label9.TabIndex = 33;
            label9.Text = "Net:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(32, 209);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(151, 29);
            label11.TabIndex = 35;
            label11.Text = "Bushels:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label11.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 29);
            label1.TabIndex = 38;
            label1.Text = "Truck ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-2, 284);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 29);
            label3.TabIndex = 42;
            label3.Text = "Comments:";
            // 
            // binLabel
            // 
            binLabel.AutoSize = true;
            binLabel.Location = new System.Drawing.Point(11, 232);
            binLabel.Name = "binLabel";
            binLabel.Size = new System.Drawing.Size(131, 29);
            binLabel.TabIndex = 25;
            binLabel.Text = "Customer:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(246, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // driverComboBox
            // 
            this.driverComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.driverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.driverComboBox.DataSource = this.driversBindingSource;
            this.driverComboBox.DisplayMember = "Driver";
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(151, 179);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(432, 37);
            this.driverComboBox.TabIndex = 1;
            this.driverComboBox.ValueMember = "Driver";
            this.driverComboBox.Enter += new System.EventHandler(this.ComboBox_Enter);
            this.driverComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.driverComboBox.Leave += new System.EventHandler(this.driverComboBox_Leave);
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // Seed_Storage_Dataset
            // 
            this.Seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.Seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1092, 29);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "GTN Ticket";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinsTableAdapter = null;
            this.tableAdapterManager.CommoditiesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.GrowersTableAdapter = null;
            this.tableAdapterManager.GTN_TicketTableAdapter = null;
            this.tableAdapterManager.HeadersTableAdapter = null;
            this.tableAdapterManager.RecievingTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.System_SetupTableAdapter = null;
            this.tableAdapterManager.Ticket_WeightsTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarietiesTableAdapter = null;
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataMember = "Customer_List";
            this.customerListBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // growersBindingSource
            // 
            this.growersBindingSource.DataMember = "Growers";
            this.growersBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // time_InLabel1
            // 
            this.time_InLabel1.Location = new System.Drawing.Point(728, 36);
            this.time_InLabel1.Name = "time_InLabel1";
            this.time_InLabel1.Size = new System.Drawing.Size(280, 29);
            this.time_InLabel1.TabIndex = 8;
            this.time_InLabel1.Text = "TimeIn";
            // 
            // time_OutLabel1
            // 
            this.time_OutLabel1.Location = new System.Drawing.Point(146, 6);
            this.time_OutLabel1.Name = "time_OutLabel1";
            this.time_OutLabel1.Size = new System.Drawing.Size(333, 29);
            this.time_OutLabel1.TabIndex = 10;
            this.time_OutLabel1.Text = "TimeOut";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 1000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMotion);
            this.panel1.Controls.Add(this.lblScaleWeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(161, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 82);
            this.panel1.TabIndex = 16;
            // 
            // lblMotion
            // 
            this.lblMotion.BackColor = System.Drawing.Color.Red;
            this.lblMotion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.ForeColor = System.Drawing.Color.White;
            this.lblMotion.Location = new System.Drawing.Point(0, 55);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(203, 25);
            this.lblMotion.TabIndex = 2;
            this.lblMotion.Text = "MOTION";
            this.lblMotion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMotion.Visible = false;
            // 
            // lblScaleWeight
            // 
            this.lblScaleWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScaleWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaleWeight.Location = new System.Drawing.Point(0, 23);
            this.lblScaleWeight.Name = "lblScaleWeight";
            this.lblScaleWeight.Size = new System.Drawing.Size(203, 33);
            this.lblScaleWeight.TabIndex = 1;
            this.lblScaleWeight.Text = "0";
            this.lblScaleWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picOutbound
            // 
            this.picOutbound.Location = new System.Drawing.Point(623, 453);
            this.picOutbound.Name = "picOutbound";
            this.picOutbound.Size = new System.Drawing.Size(409, 239);
            this.picOutbound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutbound.TabIndex = 20;
            this.picOutbound.TabStop = false;
            this.picOutbound.Click += new System.EventHandler(this.picOutbound_Click);
            // 
            // tmrInbound
            // 
            this.tmrInbound.Interval = 1000;
            this.tmrInbound.Tick += new System.EventHandler(this.tmrInbound_Tick);
            // 
            // tmrOutbound
            // 
            this.tmrOutbound.Interval = 1000;
            this.tmrOutbound.Tick += new System.EventHandler(this.tmrOutbound_Tick);
            // 
            // pnlTimeOut
            // 
            this.pnlTimeOut.Controls.Add(time_OutLabel);
            this.pnlTimeOut.Controls.Add(this.time_OutLabel1);
            this.pnlTimeOut.Location = new System.Drawing.Point(582, 82);
            this.pnlTimeOut.Name = "pnlTimeOut";
            this.pnlTimeOut.Size = new System.Drawing.Size(492, 45);
            this.pnlTimeOut.TabIndex = 22;
            this.pnlTimeOut.Visible = false;
            // 
            // varietiesBindingSource
            // 
            this.varietiesBindingSource.DataMember = "Varieties";
            this.varietiesBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // varietiesTableAdapter
            // 
            this.varietiesTableAdapter.ClearBeforeFill = true;
            // 
            // binListBindingSource
            // 
            this.binListBindingSource.DataMember = "BinList";
            this.binListBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // in_WeightLabel1
            // 
            this.in_WeightLabel1.Location = new System.Drawing.Point(179, 16);
            this.in_WeightLabel1.Name = "in_WeightLabel1";
            this.in_WeightLabel1.Size = new System.Drawing.Size(149, 32);
            this.in_WeightLabel1.TabIndex = 27;
            this.in_WeightLabel1.Text = "120,000 lbs";
            this.in_WeightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_WeightLabel1
            // 
            this.out_WeightLabel1.Location = new System.Drawing.Point(179, 48);
            this.out_WeightLabel1.Name = "out_WeightLabel1";
            this.out_WeightLabel1.Size = new System.Drawing.Size(149, 32);
            this.out_WeightLabel1.TabIndex = 28;
            this.out_WeightLabel1.Text = "120,000 lbs";
            this.out_WeightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGross
            // 
            this.lblGross.Location = new System.Drawing.Point(179, 101);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(149, 32);
            this.lblGross.TabIndex = 30;
            this.lblGross.Text = "120,000 lbs";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTare
            // 
            this.lblTare.Location = new System.Drawing.Point(179, 132);
            this.lblTare.Name = "lblTare";
            this.lblTare.Size = new System.Drawing.Size(149, 32);
            this.lblTare.TabIndex = 32;
            this.lblTare.Text = "120,000 lbs";
            this.lblTare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNet
            // 
            this.lblNet.ForeColor = System.Drawing.Color.Blue;
            this.lblNet.Location = new System.Drawing.Point(179, 177);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(149, 32);
            this.lblNet.TabIndex = 34;
            this.lblNet.Text = "120,000 lbs";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBushels
            // 
            this.lblBushels.ForeColor = System.Drawing.Color.Magenta;
            this.lblBushels.Location = new System.Drawing.Point(179, 208);
            this.lblBushels.Name = "lblBushels";
            this.lblBushels.Size = new System.Drawing.Size(149, 32);
            this.lblBushels.TabIndex = 36;
            this.lblBushels.Text = "120,000 lbs";
            this.lblBushels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBushels.Visible = false;
            // 
            // pnlGTN
            // 
            this.pnlGTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGTN.Controls.Add(this.lnkEditOutbound);
            this.pnlGTN.Controls.Add(this.lnkEditInbound);
            this.pnlGTN.Controls.Add(label11);
            this.pnlGTN.Controls.Add(this.lblBushels);
            this.pnlGTN.Controls.Add(label9);
            this.pnlGTN.Controls.Add(this.lblNet);
            this.pnlGTN.Controls.Add(label7);
            this.pnlGTN.Controls.Add(this.lblTare);
            this.pnlGTN.Controls.Add(label5);
            this.pnlGTN.Controls.Add(this.lblGross);
            this.pnlGTN.Controls.Add(out_WeightLabel);
            this.pnlGTN.Controls.Add(this.out_WeightLabel1);
            this.pnlGTN.Controls.Add(in_WeightLabel);
            this.pnlGTN.Controls.Add(this.in_WeightLabel1);
            this.pnlGTN.Location = new System.Drawing.Point(79, 453);
            this.pnlGTN.Name = "pnlGTN";
            this.pnlGTN.Size = new System.Drawing.Size(468, 263);
            this.pnlGTN.TabIndex = 37;
            this.pnlGTN.Visible = false;
            // 
            // lnkEditOutbound
            // 
            this.lnkEditOutbound.AutoSize = true;
            this.lnkEditOutbound.Location = new System.Drawing.Point(372, 49);
            this.lnkEditOutbound.Name = "lnkEditOutbound";
            this.lnkEditOutbound.Size = new System.Drawing.Size(59, 29);
            this.lnkEditOutbound.TabIndex = 38;
            this.lnkEditOutbound.TabStop = true;
            this.lnkEditOutbound.Text = "Edit";
            this.lnkEditOutbound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditOutbound_LinkClicked);
            // 
            // lnkEditInbound
            // 
            this.lnkEditInbound.AutoSize = true;
            this.lnkEditInbound.Location = new System.Drawing.Point(372, 16);
            this.lnkEditInbound.Name = "lnkEditInbound";
            this.lnkEditInbound.Size = new System.Drawing.Size(59, 29);
            this.lnkEditInbound.TabIndex = 37;
            this.lnkEditInbound.TabStop = true;
            this.lnkEditInbound.Text = "Edit";
            this.lnkEditInbound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditInbound_LinkClicked);
            // 
            // Truck_IDtextbox
            // 
            this.Truck_IDtextbox.AcceptsReturn = true;
            this.Truck_IDtextbox.Location = new System.Drawing.Point(151, 129);
            this.Truck_IDtextbox.Name = "Truck_IDtextbox";
            this.Truck_IDtextbox.Size = new System.Drawing.Size(246, 35);
            this.Truck_IDtextbox.TabIndex = 0;
            this.Truck_IDtextbox.Enter += new System.EventHandler(this.textbox_Enter);
            this.Truck_IDtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.Truck_IDtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Truck_IDtextbox_KeyPress);
            this.Truck_IDtextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.Truck_IDtextbox.Layout += new System.Windows.Forms.LayoutEventHandler(this.textbox_Layout);
            this.Truck_IDtextbox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // customer_ListTableAdapter
            // 
            this.customer_ListTableAdapter.ClearBeforeFill = true;
            // 
            // binListTableAdapter
            // 
            this.binListTableAdapter.ClearBeforeFill = true;
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(151, 284);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(432, 130);
            this.rtbComment.TabIndex = 43;
            this.rtbComment.Text = "";
            // 
            // btnManualWeight
            // 
            this.btnManualWeight.Location = new System.Drawing.Point(2, 12);
            this.btnManualWeight.Name = "btnManualWeight";
            this.btnManualWeight.Size = new System.Drawing.Size(154, 80);
            this.btnManualWeight.TabIndex = 44;
            this.btnManualWeight.Text = "Manual Weight";
            this.btnManualWeight.UseVisualStyleBackColor = true;
            this.btnManualWeight.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlWeight
            // 
            this.pnlWeight.Controls.Add(this.lblConnectionStatus);
            this.pnlWeight.Controls.Add(this.btnManualWeight);
            this.pnlWeight.Controls.Add(this.panel1);
            this.pnlWeight.Location = new System.Drawing.Point(4, 0);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(431, 109);
            this.pnlWeight.TabIndex = 45;
            // 
            // picInbound
            // 
            this.picInbound.Location = new System.Drawing.Point(623, 175);
            this.picInbound.Name = "picInbound";
            this.picInbound.Size = new System.Drawing.Size(409, 239);
            this.picInbound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInbound.TabIndex = 46;
            this.picInbound.TabStop = false;
            this.picInbound.Click += new System.EventHandler(this.picInbound_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(457, 744);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 63);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerComboBox.DataSource = this.gTNCustomersBindingSource;
            this.CustomerComboBox.DisplayMember = "Customer";
            this.CustomerComboBox.ForeColor = System.Drawing.Color.Black;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(151, 228);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(432, 37);
            this.CustomerComboBox.TabIndex = 2;
            this.CustomerComboBox.ValueMember = "Customer";
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.binComboBox_SelectedIndexChanged);
            this.CustomerComboBox.Enter += new System.EventHandler(this.ComboBox_Enter);
            this.CustomerComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.CustomerComboBox.Leave += new System.EventHandler(this.binComboBox_Leave);
            this.CustomerComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.binComboBox_Validating);
            this.CustomerComboBox.Validated += new System.EventHandler(this.binComboBox_Validated);
            // 
            // gTNCustomersBindingSource
            // 
            this.gTNCustomersBindingSource.DataMember = "GTNCustomers";
            this.gTNCustomersBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // gTNCustomersTableAdapter
            // 
            this.gTNCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // ckDriverOn
            // 
            this.ckDriverOn.AutoSize = true;
            this.ckDriverOn.Location = new System.Drawing.Point(401, 131);
            this.ckDriverOn.Name = "ckDriverOn";
            this.ckDriverOn.Size = new System.Drawing.Size(209, 33);
            this.ckDriverOn.TabIndex = 53;
            this.ckDriverOn.Text = "Driver On Scale";
            this.ckDriverOn.UseVisualStyleBackColor = true;
            // 
            // videoInbound
            // 
            this.videoInbound.BackColor = System.Drawing.Color.Black;
            this.videoInbound.Location = new System.Drawing.Point(623, 175);
            this.videoInbound.MediaPlayer = null;
            this.videoInbound.Name = "videoInbound";
            this.videoInbound.Size = new System.Drawing.Size(409, 239);
            this.videoInbound.TabIndex = 54;
            this.videoInbound.Text = "videoView1";
            // 
            // videoOutbound
            // 
            this.videoOutbound.BackColor = System.Drawing.Color.Black;
            this.videoOutbound.Location = new System.Drawing.Point(623, 453);
            this.videoOutbound.MediaPlayer = null;
            this.videoOutbound.Name = "videoOutbound";
            this.videoOutbound.Size = new System.Drawing.Size(409, 239);
            this.videoOutbound.TabIndex = 55;
            this.videoOutbound.Text = "videoView2";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(371, 34);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(44, 36);
            this.lblConnectionStatus.TabIndex = 45;
            this.lblConnectionStatus.Text = "-";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGTNTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 819);
            this.Controls.Add(this.videoOutbound);
            this.Controls.Add(this.videoInbound);
            this.Controls.Add(this.ckDriverOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlWeight);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.Truck_IDtextbox);
            this.Controls.Add(this.pnlGTN);
            this.Controls.Add(binLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.pnlTimeOut);
            this.Controls.Add(this.picOutbound);
            this.Controls.Add(time_InLabel);
            this.Controls.Add(this.time_InLabel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(driverLabel);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picInbound);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmGTNTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmGTNTicket_Activated);
            this.Load += new System.EventHandler(this.GTN_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.growersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOutbound)).EndInit();
            this.pnlTimeOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binListBindingSource)).EndInit();
            this.pnlGTN.ResumeLayout(false);
            this.pnlGTN.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTNCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private  Seed_Storage_Dataset Seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource ticketBindingSource;
     
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.BindingSource growersBindingSource;
     
        private System.Windows.Forms.Label time_InLabel1;
        private System.Windows.Forms.Label time_OutLabel1;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.Label lblScaleWeight;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.PictureBox picOutbound;
        private System.Windows.Forms.Timer tmrInbound;
        private System.Windows.Forms.Timer tmrOutbound;
        private System.Windows.Forms.Panel pnlTimeOut;
        private System.Windows.Forms.BindingSource varietiesBindingSource;
        private Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter varietiesTableAdapter;
        private System.Windows.Forms.Label in_WeightLabel1;
        private System.Windows.Forms.Label out_WeightLabel1;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblTare;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblBushels;
        private System.Windows.Forms.Panel pnlGTN;
        private System.Windows.Forms.TextBox Truck_IDtextbox;
        private Seed_Storage_DatasetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private Seed_Storage_DatasetTableAdapters.Customer_ListTableAdapter customer_ListTableAdapter;
        private System.Windows.Forms.BindingSource binListBindingSource;
        private Seed_Storage_DatasetTableAdapters.BinListTableAdapter binListTableAdapter;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Button btnManualWeight;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.LinkLabel lnkEditOutbound;
        private System.Windows.Forms.LinkLabel lnkEditInbound;
        private System.Windows.Forms.PictureBox picInbound;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.BindingSource gTNCustomersBindingSource;
        private Seed_Storage_DatasetTableAdapters.GTNCustomersTableAdapter gTNCustomersTableAdapter;
        private System.Windows.Forms.CheckBox ckDriverOn;
        private LibVLCSharp.WinForms.VideoView videoInbound;
        private LibVLCSharp.WinForms.VideoView videoOutbound;
        private System.Windows.Forms.Label lblConnectionStatus;
    }
}