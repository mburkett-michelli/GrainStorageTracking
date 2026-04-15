namespace Seed_Storage
{
    partial class frmShipping
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
            System.Windows.Forms.Label growerLabel;
            System.Windows.Forms.Label time_InLabel;
            System.Windows.Forms.Label time_OutLabel;
            System.Windows.Forms.Label lotLabel;
            System.Windows.Forms.Label binLabel;
            System.Windows.Forms.Label in_WeightLabel;
            System.Windows.Forms.Label out_WeightLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            this.btn_Ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.growerComboBox = new System.Windows.Forms.ComboBox();
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
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.binComboBox = new System.Windows.Forms.ComboBox();
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
            this.lblVariety = new System.Windows.Forms.Label();
            this.driversTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.DriversTableAdapter();
            this.customer_ListTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.Customer_ListTableAdapter();
            this.binListTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.BinListTableAdapter();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.btnManualWeight = new System.Windows.Forms.Button();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.picInbound = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckDriverOn = new System.Windows.Forms.CheckBox();
            this.cboWeighmaster = new System.Windows.Forms.ComboBox();
            this.weighMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weighMastersTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.WeighMastersTableAdapter();
            this.txtBushTicket = new System.Windows.Forms.TextBox();
            this.shippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.ShippingTableAdapter();
            this.videoInbound = new LibVLCSharp.WinForms.VideoView();
            this.videoOutbound = new LibVLCSharp.WinForms.VideoView();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            driverLabel = new System.Windows.Forms.Label();
            growerLabel = new System.Windows.Forms.Label();
            time_InLabel = new System.Windows.Forms.Label();
            time_OutLabel = new System.Windows.Forms.Label();
            lotLabel = new System.Windows.Forms.Label();
            binLabel = new System.Windows.Forms.Label();
            in_WeightLabel = new System.Windows.Forms.Label();
            out_WeightLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.weighMastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).BeginInit();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            driverLabel.Location = new System.Drawing.Point(150, 254);
            driverLabel.Name = "driverLabel";
            driverLabel.Size = new System.Drawing.Size(105, 32);
            driverLabel.TabIndex = 3;
            driverLabel.Text = "Driver:";
            driverLabel.Click += new System.EventHandler(this.driverLabel_Click);
            // 
            // growerLabel
            // 
            growerLabel.Location = new System.Drawing.Point(134, 199);
            growerLabel.Name = "growerLabel";
            growerLabel.Size = new System.Drawing.Size(121, 32);
            growerLabel.TabIndex = 5;
            growerLabel.Text = "Grower:";
            growerLabel.Click += new System.EventHandler(this.growerLabel_Click);
            // 
            // time_InLabel
            // 
            time_InLabel.Location = new System.Drawing.Point(672, 40);
            time_InLabel.Name = "time_InLabel";
            time_InLabel.Size = new System.Drawing.Size(147, 32);
            time_InLabel.TabIndex = 7;
            time_InLabel.Text = "Time In:";
            time_InLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // time_OutLabel
            // 
            time_OutLabel.Location = new System.Drawing.Point(12, 7);
            time_OutLabel.Name = "time_OutLabel";
            time_OutLabel.Size = new System.Drawing.Size(147, 32);
            time_OutLabel.TabIndex = 9;
            time_OutLabel.Text = "Time Out:";
            time_OutLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lotLabel
            // 
            lotLabel.Location = new System.Drawing.Point(187, 417);
            lotLabel.Name = "lotLabel";
            lotLabel.Size = new System.Drawing.Size(68, 32);
            lotLabel.TabIndex = 24;
            lotLabel.Text = "Lot:";
            lotLabel.Click += new System.EventHandler(this.lotLabel_Click);
            // 
            // binLabel
            // 
            binLabel.Location = new System.Drawing.Point(185, 309);
            binLabel.Name = "binLabel";
            binLabel.Size = new System.Drawing.Size(70, 32);
            binLabel.TabIndex = 25;
            binLabel.Text = "Bin:";
            binLabel.Click += new System.EventHandler(this.binLabel_Click);
            // 
            // in_WeightLabel
            // 
            in_WeightLabel.Location = new System.Drawing.Point(36, 19);
            in_WeightLabel.Name = "in_WeightLabel";
            in_WeightLabel.Size = new System.Drawing.Size(171, 32);
            in_WeightLabel.TabIndex = 26;
            in_WeightLabel.Text = "In Weight:";
            in_WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_WeightLabel
            // 
            out_WeightLabel.Location = new System.Drawing.Point(36, 54);
            out_WeightLabel.Name = "out_WeightLabel";
            out_WeightLabel.Size = new System.Drawing.Size(171, 32);
            out_WeightLabel.TabIndex = 27;
            out_WeightLabel.Text = "Out Weight:";
            out_WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(35, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(171, 32);
            label5.TabIndex = 29;
            label5.Text = "Gross:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(35, 125);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(171, 32);
            label7.TabIndex = 31;
            label7.Text = "Tare:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(36, 161);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(171, 32);
            label9.TabIndex = 33;
            label9.Text = "Net:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(36, 196);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(171, 32);
            label11.TabIndex = 35;
            label11.Text = "Bushels:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label11.Visible = false;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(119, 144);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 32);
            label1.TabIndex = 38;
            label1.Text = "Truck ID:";
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(140, 363);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(115, 32);
            label8.TabIndex = 41;
            label8.Text = "Variety:";
            label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(756, 707);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(170, 32);
            label3.TabIndex = 42;
            label3.Text = "Comments:";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(56, 515);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(199, 32);
            label6.TabIndex = 57;
            label6.Text = "Weighmaster:";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(25, 464);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(230, 32);
            label4.TabIndex = 59;
            label4.Text = "Farm and Field:";
            label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Lime;
            this.btn_Ok.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(48, 821);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(189, 63);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "Create Shipping Ticket";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 821);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 63);
            this.button2.TabIndex = 8;
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
            this.driverComboBox.Location = new System.Drawing.Point(261, 246);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(489, 40);
            this.driverComboBox.TabIndex = 2;
            this.driverComboBox.ValueMember = "Driver";
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
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
            this.lblHeader.Size = new System.Drawing.Size(1238, 32);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Shipping Ticket";
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
            // growerComboBox
            // 
            this.growerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.growerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.growerComboBox.DataSource = this.customerListBindingSource;
            this.growerComboBox.DisplayMember = "Customer";
            this.growerComboBox.FormattingEnabled = true;
            this.growerComboBox.Location = new System.Drawing.Point(261, 191);
            this.growerComboBox.Name = "growerComboBox";
            this.growerComboBox.Size = new System.Drawing.Size(489, 40);
            this.growerComboBox.TabIndex = 1;
            this.growerComboBox.ValueMember = "Customer";
            this.growerComboBox.SelectedIndexChanged += new System.EventHandler(this.growerComboBox_SelectedIndexChanged);
            this.growerComboBox.Enter += new System.EventHandler(this.ComboBox_Enter);
            this.growerComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.growerComboBox.Leave += new System.EventHandler(this.growerComboBox_Leave);
            this.growerComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.growerComboBox_Validating);
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
            this.time_InLabel1.Location = new System.Drawing.Point(825, 40);
            this.time_InLabel1.Name = "time_InLabel1";
            this.time_InLabel1.Size = new System.Drawing.Size(317, 32);
            this.time_InLabel1.TabIndex = 8;
            this.time_InLabel1.Text = "TimeIn";
            // 
            // time_OutLabel1
            // 
            this.time_OutLabel1.Location = new System.Drawing.Point(165, 7);
            this.time_OutLabel1.Name = "time_OutLabel1";
            this.time_OutLabel1.Size = new System.Drawing.Size(377, 32);
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
            this.panel1.Location = new System.Drawing.Point(182, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 90);
            this.panel1.TabIndex = 16;
            // 
            // lblMotion
            // 
            this.lblMotion.BackColor = System.Drawing.Color.Red;
            this.lblMotion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.ForeColor = System.Drawing.Color.White;
            this.lblMotion.Location = new System.Drawing.Point(0, 60);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(230, 28);
            this.lblMotion.TabIndex = 2;
            this.lblMotion.Text = "MOTION";
            this.lblMotion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMotion.Visible = false;
            // 
            // lblScaleWeight
            // 
            this.lblScaleWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScaleWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaleWeight.Location = new System.Drawing.Point(0, 25);
            this.lblScaleWeight.Name = "lblScaleWeight";
            this.lblScaleWeight.Size = new System.Drawing.Size(230, 36);
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
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picOutbound
            // 
            this.picOutbound.Location = new System.Drawing.Point(762, 430);
            this.picOutbound.Name = "picOutbound";
            this.picOutbound.Size = new System.Drawing.Size(464, 264);
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
            this.pnlTimeOut.Location = new System.Drawing.Point(660, 90);
            this.pnlTimeOut.Name = "pnlTimeOut";
            this.pnlTimeOut.Size = new System.Drawing.Size(558, 50);
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
            // lotTextBox
            // 
            this.lotTextBox.Location = new System.Drawing.Point(260, 410);
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(278, 39);
            this.lotTextBox.TabIndex = 4;
            this.lotTextBox.TextChanged += new System.EventHandler(this.lotTextBox_TextChanged);
            this.lotTextBox.Enter += new System.EventHandler(this.textbox_Enter);
            this.lotTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.lotTextBox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // binComboBox
            // 
            this.binComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.binComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.binComboBox.BackColor = System.Drawing.Color.White;
            this.binComboBox.DataSource = this.binListBindingSource;
            this.binComboBox.DisplayMember = "Bin";
            this.binComboBox.ForeColor = System.Drawing.Color.Black;
            this.binComboBox.FormattingEnabled = true;
            this.binComboBox.Location = new System.Drawing.Point(261, 301);
            this.binComboBox.Name = "binComboBox";
            this.binComboBox.Size = new System.Drawing.Size(489, 40);
            this.binComboBox.TabIndex = 3;
            this.binComboBox.ValueMember = "Variety";
            this.binComboBox.SelectedIndexChanged += new System.EventHandler(this.binComboBox_SelectedIndexChanged);
            this.binComboBox.Enter += new System.EventHandler(this.ComboBox_Enter);
            this.binComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.binComboBox.Leave += new System.EventHandler(this.binComboBox_Leave);
            this.binComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.binComboBox_Validating);
            this.binComboBox.Validated += new System.EventHandler(this.binComboBox_Validated);
            // 
            // binListBindingSource
            // 
            this.binListBindingSource.DataMember = "BinList";
            this.binListBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // in_WeightLabel1
            // 
            this.in_WeightLabel1.Location = new System.Drawing.Point(203, 18);
            this.in_WeightLabel1.Name = "in_WeightLabel1";
            this.in_WeightLabel1.Size = new System.Drawing.Size(169, 35);
            this.in_WeightLabel1.TabIndex = 27;
            this.in_WeightLabel1.Text = "120,000 lbs";
            this.in_WeightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // out_WeightLabel1
            // 
            this.out_WeightLabel1.Location = new System.Drawing.Point(203, 53);
            this.out_WeightLabel1.Name = "out_WeightLabel1";
            this.out_WeightLabel1.Size = new System.Drawing.Size(169, 35);
            this.out_WeightLabel1.TabIndex = 28;
            this.out_WeightLabel1.Text = "120,000 lbs";
            this.out_WeightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGross
            // 
            this.lblGross.Location = new System.Drawing.Point(202, 89);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(169, 35);
            this.lblGross.TabIndex = 30;
            this.lblGross.Text = "120,000 lbs";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTare
            // 
            this.lblTare.Location = new System.Drawing.Point(202, 124);
            this.lblTare.Name = "lblTare";
            this.lblTare.Size = new System.Drawing.Size(169, 35);
            this.lblTare.TabIndex = 32;
            this.lblTare.Text = "120,000 lbs";
            this.lblTare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNet
            // 
            this.lblNet.ForeColor = System.Drawing.Color.Blue;
            this.lblNet.Location = new System.Drawing.Point(203, 160);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(169, 35);
            this.lblNet.TabIndex = 34;
            this.lblNet.Text = "120,000 lbs";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBushels
            // 
            this.lblBushels.ForeColor = System.Drawing.Color.Magenta;
            this.lblBushels.Location = new System.Drawing.Point(203, 195);
            this.lblBushels.Name = "lblBushels";
            this.lblBushels.Size = new System.Drawing.Size(169, 35);
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
            this.pnlGTN.Location = new System.Drawing.Point(89, 569);
            this.pnlGTN.Name = "pnlGTN";
            this.pnlGTN.Size = new System.Drawing.Size(530, 234);
            this.pnlGTN.TabIndex = 37;
            this.pnlGTN.Visible = false;
            // 
            // lnkEditOutbound
            // 
            this.lnkEditOutbound.AutoSize = true;
            this.lnkEditOutbound.Location = new System.Drawing.Point(422, 54);
            this.lnkEditOutbound.Name = "lnkEditOutbound";
            this.lnkEditOutbound.Size = new System.Drawing.Size(67, 32);
            this.lnkEditOutbound.TabIndex = 38;
            this.lnkEditOutbound.TabStop = true;
            this.lnkEditOutbound.Text = "Edit";
            this.lnkEditOutbound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditOutbound_LinkClicked);
            // 
            // lnkEditInbound
            // 
            this.lnkEditInbound.AutoSize = true;
            this.lnkEditInbound.Location = new System.Drawing.Point(422, 18);
            this.lnkEditInbound.Name = "lnkEditInbound";
            this.lnkEditInbound.Size = new System.Drawing.Size(67, 32);
            this.lnkEditInbound.TabIndex = 37;
            this.lnkEditInbound.TabStop = true;
            this.lnkEditInbound.Text = "Edit";
            this.lnkEditInbound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditInbound_LinkClicked);
            // 
            // Truck_IDtextbox
            // 
            this.Truck_IDtextbox.AcceptsReturn = true;
            this.Truck_IDtextbox.Location = new System.Drawing.Point(260, 137);
            this.Truck_IDtextbox.Name = "Truck_IDtextbox";
            this.Truck_IDtextbox.Size = new System.Drawing.Size(232, 39);
            this.Truck_IDtextbox.TabIndex = 0;
            this.Truck_IDtextbox.Enter += new System.EventHandler(this.textbox_Enter);
            this.Truck_IDtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.Truck_IDtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Truck_IDtextbox_KeyPress);
            this.Truck_IDtextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.Truck_IDtextbox.Layout += new System.Windows.Forms.LayoutEventHandler(this.textbox_Layout);
            this.Truck_IDtextbox.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // lblVariety
            // 
            this.lblVariety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVariety.Location = new System.Drawing.Point(261, 356);
            this.lblVariety.Name = "lblVariety";
            this.lblVariety.Size = new System.Drawing.Size(489, 39);
            this.lblVariety.TabIndex = 40;
            this.lblVariety.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVariety.Click += new System.EventHandler(this.lblVariety_Click);
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
            this.rtbComment.Location = new System.Drawing.Point(762, 742);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(464, 143);
            this.rtbComment.TabIndex = 43;
            this.rtbComment.Text = "";
            // 
            // btnManualWeight
            // 
            this.btnManualWeight.Location = new System.Drawing.Point(2, 13);
            this.btnManualWeight.Name = "btnManualWeight";
            this.btnManualWeight.Size = new System.Drawing.Size(174, 88);
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
            this.pnlWeight.Size = new System.Drawing.Size(488, 120);
            this.pnlWeight.TabIndex = 45;
            // 
            // picInbound
            // 
            this.picInbound.Location = new System.Drawing.Point(762, 149);
            this.picInbound.Name = "picInbound";
            this.picInbound.Size = new System.Drawing.Size(464, 264);
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
            this.btnDelete.Location = new System.Drawing.Point(500, 821);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 63);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // ckDriverOn
            // 
            this.ckDriverOn.Location = new System.Drawing.Point(511, 149);
            this.ckDriverOn.Name = "ckDriverOn";
            this.ckDriverOn.Size = new System.Drawing.Size(239, 36);
            this.ckDriverOn.TabIndex = 53;
            this.ckDriverOn.Text = "Driver On Scale";
            this.ckDriverOn.UseVisualStyleBackColor = true;
            // 
            // cboWeighmaster
            // 
            this.cboWeighmaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboWeighmaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboWeighmaster.DataSource = this.weighMastersBindingSource;
            this.cboWeighmaster.DisplayMember = "Weighmaster";
            this.cboWeighmaster.FormattingEnabled = true;
            this.cboWeighmaster.Location = new System.Drawing.Point(260, 511);
            this.cboWeighmaster.Name = "cboWeighmaster";
            this.cboWeighmaster.Size = new System.Drawing.Size(408, 40);
            this.cboWeighmaster.TabIndex = 6;
            this.cboWeighmaster.ValueMember = "Weighmaster";
            this.cboWeighmaster.SelectedIndexChanged += new System.EventHandler(this.cboWeighmaster_SelectedIndexChanged);
            this.cboWeighmaster.Enter += new System.EventHandler(this.ComboBox_Enter);
            this.cboWeighmaster.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctlbox_KeyUp);
            this.cboWeighmaster.Leave += new System.EventHandler(this.ComboBox_Leave);
            // 
            // weighMastersBindingSource
            // 
            this.weighMastersBindingSource.DataMember = "WeighMasters";
            this.weighMastersBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // weighMastersTableAdapter
            // 
            this.weighMastersTableAdapter.ClearBeforeFill = true;
            // 
            // txtBushTicket
            // 
            this.txtBushTicket.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shippingBindingSource, "Bush_Ticket", true));
            this.txtBushTicket.Location = new System.Drawing.Point(261, 461);
            this.txtBushTicket.Name = "txtBushTicket";
            this.txtBushTicket.Size = new System.Drawing.Size(489, 39);
            this.txtBushTicket.TabIndex = 60;
            this.txtBushTicket.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shippingBindingSource
            // 
            this.shippingBindingSource.DataMember = "Shipping";
            this.shippingBindingSource.DataSource = this.Seed_Storage_Dataset;
            // 
            // shippingTableAdapter
            // 
            this.shippingTableAdapter.ClearBeforeFill = true;
            // 
            // videoInbound
            // 
            this.videoInbound.BackColor = System.Drawing.Color.Black;
            this.videoInbound.Location = new System.Drawing.Point(762, 149);
            this.videoInbound.MediaPlayer = null;
            this.videoInbound.Name = "videoInbound";
            this.videoInbound.Size = new System.Drawing.Size(464, 264);
            this.videoInbound.TabIndex = 61;
            this.videoInbound.Text = "videoView1";
            // 
            // videoOutbound
            // 
            this.videoOutbound.BackColor = System.Drawing.Color.Black;
            this.videoOutbound.Location = new System.Drawing.Point(762, 430);
            this.videoOutbound.MediaPlayer = null;
            this.videoOutbound.Name = "videoOutbound";
            this.videoOutbound.Size = new System.Drawing.Size(464, 264);
            this.videoOutbound.TabIndex = 62;
            this.videoOutbound.Text = "videoView2";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(419, 37);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(44, 36);
            this.lblConnectionStatus.TabIndex = 45;
            this.lblConnectionStatus.Text = "-";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 904);
            this.Controls.Add(this.videoOutbound);
            this.Controls.Add(this.videoInbound);
            this.Controls.Add(this.txtBushTicket);
            this.Controls.Add(label4);
            this.Controls.Add(label6);
            this.Controls.Add(this.cboWeighmaster);
            this.Controls.Add(this.ckDriverOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlWeight);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(label3);
            this.Controls.Add(label8);
            this.Controls.Add(this.lblVariety);
            this.Controls.Add(label1);
            this.Controls.Add(this.Truck_IDtextbox);
            this.Controls.Add(this.pnlGTN);
            this.Controls.Add(binLabel);
            this.Controls.Add(this.binComboBox);
            this.Controls.Add(lotLabel);
            this.Controls.Add(this.lotTextBox);
            this.Controls.Add(this.pnlTimeOut);
            this.Controls.Add(this.picOutbound);
            this.Controls.Add(time_InLabel);
            this.Controls.Add(this.time_InLabel1);
            this.Controls.Add(growerLabel);
            this.Controls.Add(this.growerComboBox);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(driverLabel);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.picInbound);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmShipping_Activated);
            this.Load += new System.EventHandler(this.Shipping_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.weighMastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button button2;
        private  Seed_Storage_Dataset Seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource ticketBindingSource;
     
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.BindingSource driversBindingSource;
     
        private System.Windows.Forms.ComboBox growerComboBox;
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
        private System.Windows.Forms.TextBox lotTextBox;
        private System.Windows.Forms.ComboBox binComboBox;
        private System.Windows.Forms.Label in_WeightLabel1;
        private System.Windows.Forms.Label out_WeightLabel1;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblTare;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblBushels;
        private System.Windows.Forms.Panel pnlGTN;
        private System.Windows.Forms.TextBox Truck_IDtextbox;
        private System.Windows.Forms.Label lblVariety;
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
        private System.Windows.Forms.CheckBox ckDriverOn;
        private System.Windows.Forms.ComboBox cboWeighmaster;
        private System.Windows.Forms.BindingSource weighMastersBindingSource;
        private Seed_Storage_DatasetTableAdapters.WeighMastersTableAdapter weighMastersTableAdapter;
        
        private System.Windows.Forms.TextBox txtBushTicket;
        private System.Windows.Forms.BindingSource shippingBindingSource;
        private Seed_Storage_DatasetTableAdapters.ShippingTableAdapter shippingTableAdapter;
        private LibVLCSharp.WinForms.VideoView videoInbound;
        private LibVLCSharp.WinForms.VideoView videoOutbound;
        private System.Windows.Forms.Label lblConnectionStatus;
    }
}