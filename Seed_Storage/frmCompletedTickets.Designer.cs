namespace Seed_Storage
{
    partial class frmCompletedTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inbound_TicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.Load_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReprint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Bin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_StorageDataSet = new Seed_Storage.Seed_Storage_Dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cboLoadtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.vwTicket_InformationTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.vwTicketInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gTNCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gTNCustomersTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.GTNCustomersTableAdapter();
            this.vwDistinctCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDistinctCustomersTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vwDistinctCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_StorageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTicketInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTNCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDistinctCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inbound_TicketsDataGridView
            // 
            this.inbound_TicketsDataGridView.AllowUserToAddRows = false;
            this.inbound_TicketsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue;
            this.inbound_TicketsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.inbound_TicketsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inbound_TicketsDataGridView.AutoGenerateColumns = false;
            this.inbound_TicketsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inbound_TicketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inbound_TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inbound_TicketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Load_Type,
            this.btnReprint,
            this.btnEdit,
            this.Bin,
            this.Ticket,
            this.dataGridViewTextBoxColumn10,
            this.Gross,
            this.Tare,
            this.Net,
            this.dataGridViewTextBoxColumn2,
            this.Customer,
            this.btnDelete});
            this.inbound_TicketsDataGridView.DataSource = this.TicketsBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inbound_TicketsDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.inbound_TicketsDataGridView.Location = new System.Drawing.Point(12, 154);
            this.inbound_TicketsDataGridView.Name = "inbound_TicketsDataGridView";
            this.inbound_TicketsDataGridView.ReadOnly = true;
            this.inbound_TicketsDataGridView.RowHeadersVisible = false;
            this.inbound_TicketsDataGridView.RowTemplate.Height = 100;
            this.inbound_TicketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inbound_TicketsDataGridView.Size = new System.Drawing.Size(1528, 610);
            this.inbound_TicketsDataGridView.TabIndex = 1;
            this.inbound_TicketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inbound_TicketsDataGridView_CellContentClick);
            // 
            // Load_Type
            // 
            this.Load_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Load_Type.DataPropertyName = "Load_Type";
            this.Load_Type.HeaderText = "Type";
            this.Load_Type.Name = "Load_Type";
            this.Load_Type.ReadOnly = true;
            this.Load_Type.Width = 103;
            // 
            // btnReprint
            // 
            this.btnReprint.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnReprint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnReprint.DataPropertyName = "btnReprint";
            this.btnReprint.HeaderText = "";
            this.btnReprint.LinkColor = System.Drawing.Color.Black;
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.ReadOnly = true;
            this.btnReprint.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnReprint.Width = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEdit.DataPropertyName = "btnEdit";
            this.btnEdit.HeaderText = "";
            this.btnEdit.LinkColor = System.Drawing.Color.Black;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnEdit.Width = 5;
            // 
            // Bin
            // 
            this.Bin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bin.DataPropertyName = "Bin";
            this.Bin.HeaderText = "Bin";
            this.Bin.Name = "Bin";
            this.Bin.ReadOnly = true;
            this.Bin.Width = 85;
            // 
            // Ticket
            // 
            this.Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ticket.DataPropertyName = "ID";
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ticket.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Truck_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Truck ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 151;
            // 
            // Gross
            // 
            this.Gross.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gross.DataPropertyName = "Gross";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Gross.DefaultCellStyle = dataGridViewCellStyle9;
            this.Gross.HeaderText = "Gross";
            this.Gross.Name = "Gross";
            this.Gross.ReadOnly = true;
            this.Gross.Width = 119;
            // 
            // Tare
            // 
            this.Tare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tare.DataPropertyName = "Tare";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Tare.DefaultCellStyle = dataGridViewCellStyle10;
            this.Tare.HeaderText = "Tare";
            this.Tare.Name = "Tare";
            this.Tare.ReadOnly = true;
            this.Tare.Width = 97;
            // 
            // Net
            // 
            this.Net.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Net.DataPropertyName = "Net";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.Net.DefaultCellStyle = dataGridViewCellStyle11;
            this.Net.HeaderText = "Net";
            this.Net.Name = "Net";
            this.Net.ReadOnly = true;
            this.Net.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time_Out";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "g";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Time Out";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 162;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 170;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnDelete.DataPropertyName = "btnDelete";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle13;
            this.btnDelete.HeaderText = "";
            this.btnDelete.LinkColor = System.Drawing.Color.Red;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.VisitedLinkColor = System.Drawing.Color.Red;
            this.btnDelete.Width = 5;
            // 
            // TicketsBindingSource
            // 
            this.TicketsBindingSource.DataMember = "vwTicket_Information";
            this.TicketsBindingSource.DataSource = this.seed_StorageDataSet;
            this.TicketsBindingSource.Filter = "";
            // 
            // seed_StorageDataSet
            // 
            this.seed_StorageDataSet.DataSetName = "Seed_StorageDataSet";
            this.seed_StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1552, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPLETED TRUCKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1321, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(104, 107);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(646, 39);
            this.dtEnd.TabIndex = 8;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "From";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(104, 59);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(646, 39);
            this.dtStart.TabIndex = 10;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // cboLoadtype
            // 
            this.cboLoadtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoadtype.FormattingEnabled = true;
            this.cboLoadtype.Items.AddRange(new object[] {
            "All Types",
            "Inbound",
            "Outbound",
            "Other"});
            this.cboLoadtype.Location = new System.Drawing.Point(874, 59);
            this.cboLoadtype.Name = "cboLoadtype";
            this.cboLoadtype.Size = new System.Drawing.Size(319, 40);
            this.cboLoadtype.TabIndex = 12;
            this.cboLoadtype.SelectedIndexChanged += new System.EventHandler(this.cboLoadtype_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type";
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
            // vwTicket_InformationTableAdapter
            // 
            this.vwTicket_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DataSource = this.vwDistinctCustomersBindingSource;
            this.cboCustomer.DisplayMember = "Customer";
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(938, 107);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(602, 40);
            this.cboCustomer.TabIndex = 16;
            this.cboCustomer.ValueMember = "Customer";
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // vwTicketInformationBindingSource
            // 
            this.vwTicketInformationBindingSource.DataMember = "vwTicket_Information";
            this.vwTicketInformationBindingSource.DataSource = this.seed_StorageDataSet;
            // 
            // gTNCustomersBindingSource
            // 
            this.gTNCustomersBindingSource.DataMember = "GTNCustomers";
            this.gTNCustomersBindingSource.DataSource = this.seed_StorageDataSet;
            // 
            // gTNCustomersTableAdapter
            // 
            this.gTNCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // vwDistinctCustomersBindingSource
            // 
            this.vwDistinctCustomersBindingSource.DataMember = "vwDistinctCustomers";
            this.vwDistinctCustomersBindingSource.DataSource = this.seed_StorageDataSet;
            // 
            // vwDistinctCustomersTableAdapter
            // 
            this.vwDistinctCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompletedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 776);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLoadtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inbound_TicketsDataGridView);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmCompletedTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompletedTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_StorageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTicketInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTNCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDistinctCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Seed_Storage_Dataset seed_StorageDataSet;
        private System.Windows.Forms.BindingSource TicketsBindingSource;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inbound_TicketsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.ComboBox cboLoadtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load_Type;
        private System.Windows.Forms.DataGridViewLinkColumn btnReprint;
        private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.BindingSource gTNCustomersBindingSource;
        private Seed_Storage_DatasetTableAdapters.GTNCustomersTableAdapter gTNCustomersTableAdapter;
        private System.Windows.Forms.BindingSource vwTicketInformationBindingSource;
        private System.Windows.Forms.BindingSource vwDistinctCustomersBindingSource;
        private Seed_Storage_DatasetTableAdapters.vwDistinctCustomersTableAdapter vwDistinctCustomersTableAdapter;
    }
}