namespace Seed_Storage
{
    partial class frmBinInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vwInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.vw_InventoryTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vw_InventoryTableAdapter();
            this.binDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingBushelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recievingNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bushelWtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBushelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdjust = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1288, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1181, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.binDescriptionDataGridViewTextBoxColumn,
            this.varietyDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.startingBushelsDataGridViewTextBoxColumn,
            this.recievingNetDataGridViewTextBoxColumn,
            this.shippingNetDataGridViewTextBoxColumn,
            this.currentWeightDataGridViewTextBoxColumn,
            this.bushelWtDataGridViewTextBoxColumn,
            this.currentBushelsDataGridViewTextBoxColumn,
            this.percentFullDataGridViewTextBoxColumn,
            this.btnAdjust});
            this.dataGridView1.DataSource = this.vwInventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 652);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vwInventoryBindingSource
            // 
            this.vwInventoryBindingSource.DataMember = "vw_Inventory";
            this.vwInventoryBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_InventoryTableAdapter
            // 
            this.vw_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // binDescriptionDataGridViewTextBoxColumn
            // 
            this.binDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.binDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Bin_Description";
            this.binDescriptionDataGridViewTextBoxColumn.HeaderText = "Bin";
            this.binDescriptionDataGridViewTextBoxColumn.Name = "binDescriptionDataGridViewTextBoxColumn";
            this.binDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.binDescriptionDataGridViewTextBoxColumn.Width = 62;
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            this.varietyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            this.varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            this.varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            this.varietyDataGridViewTextBoxColumn.ReadOnly = true;
            this.varietyDataGridViewTextBoxColumn.Width = 92;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.capacityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity BU";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 139;
            // 
            // startingBushelsDataGridViewTextBoxColumn
            // 
            this.startingBushelsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startingBushelsDataGridViewTextBoxColumn.DataPropertyName = "Starting_Bushels";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.startingBushelsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.startingBushelsDataGridViewTextBoxColumn.HeaderText = "Starting Amt";
            this.startingBushelsDataGridViewTextBoxColumn.Name = "startingBushelsDataGridViewTextBoxColumn";
            this.startingBushelsDataGridViewTextBoxColumn.ReadOnly = true;
            this.startingBushelsDataGridViewTextBoxColumn.Width = 137;
            // 
            // recievingNetDataGridViewTextBoxColumn
            // 
            this.recievingNetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recievingNetDataGridViewTextBoxColumn.DataPropertyName = "Recieving_Net";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.recievingNetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.recievingNetDataGridViewTextBoxColumn.HeaderText = "Recieved";
            this.recievingNetDataGridViewTextBoxColumn.Name = "recievingNetDataGridViewTextBoxColumn";
            this.recievingNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.recievingNetDataGridViewTextBoxColumn.Width = 116;
            // 
            // shippingNetDataGridViewTextBoxColumn
            // 
            this.shippingNetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shippingNetDataGridViewTextBoxColumn.DataPropertyName = "Shipping_Net";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.shippingNetDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.shippingNetDataGridViewTextBoxColumn.HeaderText = "Shipped";
            this.shippingNetDataGridViewTextBoxColumn.Name = "shippingNetDataGridViewTextBoxColumn";
            this.shippingNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.shippingNetDataGridViewTextBoxColumn.Width = 106;
            // 
            // currentWeightDataGridViewTextBoxColumn
            // 
            this.currentWeightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currentWeightDataGridViewTextBoxColumn.DataPropertyName = "Current_Weight";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.currentWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.currentWeightDataGridViewTextBoxColumn.HeaderText = "Current Weight";
            this.currentWeightDataGridViewTextBoxColumn.Name = "currentWeightDataGridViewTextBoxColumn";
            this.currentWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentWeightDataGridViewTextBoxColumn.Width = 148;
            // 
            // bushelWtDataGridViewTextBoxColumn
            // 
            this.bushelWtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bushelWtDataGridViewTextBoxColumn.DataPropertyName = "Bushel_Wt";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.bushelWtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.bushelWtDataGridViewTextBoxColumn.HeaderText = "#/BU";
            this.bushelWtDataGridViewTextBoxColumn.Name = "bushelWtDataGridViewTextBoxColumn";
            this.bushelWtDataGridViewTextBoxColumn.ReadOnly = true;
            this.bushelWtDataGridViewTextBoxColumn.Width = 77;
            // 
            // currentBushelsDataGridViewTextBoxColumn
            // 
            this.currentBushelsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currentBushelsDataGridViewTextBoxColumn.DataPropertyName = "Current_Bushels";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.currentBushelsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.currentBushelsDataGridViewTextBoxColumn.HeaderText = "Current BU";
            this.currentBushelsDataGridViewTextBoxColumn.Name = "currentBushelsDataGridViewTextBoxColumn";
            this.currentBushelsDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentBushelsDataGridViewTextBoxColumn.Width = 117;
            // 
            // percentFullDataGridViewTextBoxColumn
            // 
            this.percentFullDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.percentFullDataGridViewTextBoxColumn.DataPropertyName = "Percent_Full";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.percentFullDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.percentFullDataGridViewTextBoxColumn.HeaderText = "% Full";
            this.percentFullDataGridViewTextBoxColumn.Name = "percentFullDataGridViewTextBoxColumn";
            this.percentFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentFullDataGridViewTextBoxColumn.Width = 80;
            // 
            // btnAdjust
            // 
            this.btnAdjust.DataPropertyName = "btnAdjust";
            this.btnAdjust.HeaderText = "";
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.ReadOnly = true;
            // 
            // frmBinInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 757);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmBinInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmBinInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource vwInventoryBindingSource;
        private Seed_Storage_DatasetTableAdapters.vw_InventoryTableAdapter vw_InventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn binDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingBushelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recievingNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bushelWtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBushelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn btnAdjust;
    }
}