namespace Seed_Storage
{
    partial class frmSelectVarieties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commoditiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.commoditiesTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.CommoditiesTableAdapter();
            this.btnEditCommodities = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.varietiesDataGridView = new System.Windows.Forms.DataGridView();
            this.varietiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVariety = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.varietiesTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter();
            this.btnOk = new System.Windows.Forms.Button();
            this.Variety = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Bushel_Wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.commoditiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.commoditiesBindingSource;
            this.comboBox1.DisplayMember = "Commodity";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 35);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Commodity";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // commoditiesBindingSource
            // 
            this.commoditiesBindingSource.DataMember = "Commodities";
            this.commoditiesBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commoditiesTableAdapter
            // 
            this.commoditiesTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditCommodities
            // 
            this.btnEditCommodities.Location = new System.Drawing.Point(360, 40);
            this.btnEditCommodities.Name = "btnEditCommodities";
            this.btnEditCommodities.Size = new System.Drawing.Size(93, 35);
            this.btnEditCommodities.TabIndex = 1;
            this.btnEditCommodities.Text = "Edit";
            this.btnEditCommodities.UseVisualStyleBackColor = true;
            this.btnEditCommodities.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrompt.Location = new System.Drawing.Point(0, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(754, 27);
            this.lblPrompt.TabIndex = 2;
            this.lblPrompt.Text = "Select Variety";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varietiesDataGridView
            // 
            this.varietiesDataGridView.AllowUserToAddRows = false;
            this.varietiesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.varietiesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.varietiesDataGridView.AutoGenerateColumns = false;
            this.varietiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varietiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variety,
            this.Bushel_Wt,
            this.btnDelete});
            this.varietiesDataGridView.DataSource = this.varietiesBindingSource;
            this.varietiesDataGridView.Location = new System.Drawing.Point(14, 81);
            this.varietiesDataGridView.Name = "varietiesDataGridView";
            this.varietiesDataGridView.RowTemplate.Height = 40;
            this.varietiesDataGridView.Size = new System.Drawing.Size(725, 533);
            this.varietiesDataGridView.TabIndex = 3;
            this.varietiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varietiesDataGridView_CellContentClick);
            this.varietiesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.varietiesDataGridView_DataError);
            // 
            // varietiesBindingSource
            // 
            this.varietiesBindingSource.DataMember = "Varieties";
            this.varietiesBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // btnAddVariety
            // 
            this.btnAddVariety.Location = new System.Drawing.Point(268, 630);
            this.btnAddVariety.Name = "btnAddVariety";
            this.btnAddVariety.Size = new System.Drawing.Size(215, 35);
            this.btnAddVariety.TabIndex = 4;
            this.btnAddVariety.Text = "Add Variety";
            this.btnAddVariety.UseVisualStyleBackColor = true;
            this.btnAddVariety.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinsTableAdapter = null;
            this.tableAdapterManager.CommoditiesTableAdapter = this.commoditiesTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.GrowersTableAdapter = null;
            this.tableAdapterManager.GTN_TicketTableAdapter = null;
            this.tableAdapterManager.RecievingTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.System_SetupTableAdapter = null;
            this.tableAdapterManager.Ticket_WeightsTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarietiesTableAdapter = this.varietiesTableAdapter;
            // 
            // varietiesTableAdapter
            // 
            this.varietiesTableAdapter.ClearBeforeFill = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(599, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 59);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button3_Click);
            // 
            // Variety
            // 
            this.Variety.ActiveLinkColor = System.Drawing.Color.Black;
            this.Variety.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Variety.DataPropertyName = "Variety";
            this.Variety.HeaderText = "Variety";
            this.Variety.LinkColor = System.Drawing.Color.Black;
            this.Variety.Name = "Variety";
            this.Variety.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Variety.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Variety.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // Bushel_Wt
            // 
            this.Bushel_Wt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bushel_Wt.DataPropertyName = "Bushel_Wt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.Bushel_Wt.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bushel_Wt.HeaderText = "Bushel Wt";
            this.Bushel_Wt.MinimumWidth = 50;
            this.Bushel_Wt.Name = "Bushel_Wt";
            this.Bushel_Wt.Width = 149;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnDelete.DataPropertyName = "btnDelete";
            this.btnDelete.HeaderText = "";
            this.btnDelete.LinkColor = System.Drawing.Color.Red;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.VisitedLinkColor = System.Drawing.Color.Red;
            this.btnDelete.Width = 5;
            // 
            // frmSelectVarieties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 677);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddVariety);
            this.Controls.Add(this.varietiesDataGridView);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnEditCommodities);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmSelectVarieties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Varieties";
            this.Load += new System.EventHandler(this.frmSelectVarieties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commoditiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource commoditiesBindingSource;
        private Seed_Storage_DatasetTableAdapters.CommoditiesTableAdapter commoditiesTableAdapter;
        private System.Windows.Forms.Button btnEditCommodities;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.DataGridView varietiesDataGridView;
        private System.Windows.Forms.Button btnAddVariety;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter varietiesTableAdapter;
        private System.Windows.Forms.BindingSource varietiesBindingSource;
        
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewLinkColumn Variety;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bushel_Wt;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
    }
}