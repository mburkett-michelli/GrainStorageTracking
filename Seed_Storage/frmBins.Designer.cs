namespace Seed_Storage
{
    partial class frmBins
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
            this.binsDataGridView = new System.Windows.Forms.DataGridView();
            this.binsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.binsTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.BinsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.btnBin = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVariety = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.binsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // binsDataGridView
            // 
            this.binsDataGridView.AllowUserToAddRows = false;
            this.binsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.binsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.binsDataGridView.AutoGenerateColumns = false;
            this.binsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.binsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBin,
            this.dataGridViewCheckBoxColumn1,
            this.btnVariety,
            this.dataGridViewTextBoxColumn3,
            this.btnDelete});
            this.binsDataGridView.DataSource = this.binsBindingSource;
            this.binsDataGridView.Location = new System.Drawing.Point(12, 78);
            this.binsDataGridView.Name = "binsDataGridView";
            this.binsDataGridView.RowTemplate.Height = 44;
            this.binsDataGridView.Size = new System.Drawing.Size(1159, 498);
            this.binsDataGridView.TabIndex = 1;
            this.binsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.binsDataGridView_CellClick);
            this.binsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.binsDataGridView_CellContentClick);
            this.binsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.binsDataGridView_DataError);
            // 
            // binsBindingSource
            // 
            this.binsBindingSource.DataMember = "Bins";
            this.binsBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1183, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bins";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // binsTableAdapter
            // 
            this.binsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1031, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Bin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.tableAdapterManager.RecievingTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.System_SetupTableAdapter = null;
            this.tableAdapterManager.Ticket_WeightsTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarietiesTableAdapter = null;
            // 
            // btnBin
            // 
            this.btnBin.ActiveLinkColor = System.Drawing.Color.Black;
            this.btnBin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnBin.DataPropertyName = "Bin";
            this.btnBin.HeaderText = "Bin";
            this.btnBin.LinkColor = System.Drawing.Color.Black;
            this.btnBin.MinimumWidth = 200;
            this.btnBin.Name = "btnBin";
            this.btnBin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBin.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Use_For_Inbound_Loads";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Use For Inbound";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 164;
            // 
            // btnVariety
            // 
            this.btnVariety.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnVariety.DataPropertyName = "Variety";
            this.btnVariety.HeaderText = "Variety";
            this.btnVariety.MinimumWidth = 200;
            this.btnVariety.Name = "btnVariety";
            this.btnVariety.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVariety.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVariety.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Capacity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Capacity(Bushels)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
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
            // frmBins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binsDataGridView);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmBins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bins";
            this.Load += new System.EventHandler(this.Bins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource binsBindingSource;
        private Seed_Storage_DatasetTableAdapters.BinsTableAdapter binsTableAdapter;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView binsDataGridView;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewLinkColumn btnBin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn btnVariety;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
    }
}