namespace Seed_Storage
{
    partial class FrmFinishTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inbound_TicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.inbound_TicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_StorageDataSet = new Seed_Storage.Seed_Storage_Dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.vw_Inbound_TicketsTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vw_Inbound_TicketsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.Load_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWeighOut = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Bin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_StorageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inbound_TicketsDataGridView
            // 
            this.inbound_TicketsDataGridView.AllowUserToAddRows = false;
            this.inbound_TicketsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.inbound_TicketsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inbound_TicketsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inbound_TicketsDataGridView.AutoGenerateColumns = false;
            this.inbound_TicketsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inbound_TicketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inbound_TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inbound_TicketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Load_Type,
            this.btnWeighOut,
            this.btnEdit,
            this.Bin,
            this.Ticket,
            this.Picture,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.btnDelete});
            this.inbound_TicketsDataGridView.DataSource = this.inbound_TicketsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inbound_TicketsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.inbound_TicketsDataGridView.Location = new System.Drawing.Point(12, 81);
            this.inbound_TicketsDataGridView.Name = "inbound_TicketsDataGridView";
            this.inbound_TicketsDataGridView.ReadOnly = true;
            this.inbound_TicketsDataGridView.RowHeadersVisible = false;
            this.inbound_TicketsDataGridView.RowTemplate.Height = 100;
            this.inbound_TicketsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inbound_TicketsDataGridView.Size = new System.Drawing.Size(1227, 683);
            this.inbound_TicketsDataGridView.TabIndex = 1;
            this.inbound_TicketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inbound_TicketsDataGridView_CellContentClick);
            this.inbound_TicketsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.inbound_TicketsDataGridView_RowPostPaint);
            this.inbound_TicketsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.inbound_TicketsDataGridView_RowPrePaint);
            this.inbound_TicketsDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.inbound_TicketsDataGridView_Paint);
            // 
            // inbound_TicketsBindingSource
            // 
            this.inbound_TicketsBindingSource.DataMember = "vw_Inbound_Tickets";
            this.inbound_TicketsBindingSource.DataSource = this.seed_StorageDataSet;
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
            this.label1.Size = new System.Drawing.Size(1251, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "INBOUND TRUCKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // vw_Inbound_TicketsTableAdapter
            // 
            this.vw_Inbound_TicketsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1020, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // btnWeighOut
            // 
            this.btnWeighOut.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnWeighOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnWeighOut.DataPropertyName = "btnWeighOut";
            this.btnWeighOut.HeaderText = "";
            this.btnWeighOut.LinkColor = System.Drawing.Color.Black;
            this.btnWeighOut.Name = "btnWeighOut";
            this.btnWeighOut.ReadOnly = true;
            this.btnWeighOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnWeighOut.Width = 5;
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
            // Picture
            // 
            this.Picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 180;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Truck_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Truck ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time_In";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Time In";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnDelete.DataPropertyName = "btnDelete";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnDelete.HeaderText = "";
            this.btnDelete.LinkColor = System.Drawing.Color.Red;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.VisitedLinkColor = System.Drawing.Color.Red;
            this.btnDelete.Width = 5;
            // 
            // FrmFinishTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 776);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inbound_TicketsDataGridView);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmFinishTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFinishTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inbound_TicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_StorageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Seed_Storage_Dataset seed_StorageDataSet;
        private System.Windows.Forms.BindingSource inbound_TicketsBindingSource;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inbound_TicketsDataGridView;
        private System.Windows.Forms.Label label1;
        private Seed_Storage_DatasetTableAdapters.vw_Inbound_TicketsTableAdapter vw_Inbound_TicketsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load_Type;
        private System.Windows.Forms.DataGridViewLinkColumn btnWeighOut;
        private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
    }
}