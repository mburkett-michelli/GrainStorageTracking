namespace Seed_Storage
{
    partial class frmCommodities
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.commodity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.poundsPerBushelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.commoditiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.commoditiesTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.CommoditiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrompt.Location = new System.Drawing.Point(0, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(961, 27);
            this.lblPrompt.TabIndex = 12;
            this.lblPrompt.Text = "Commodities";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Commodity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(797, 59);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 59);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.customersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodity,
            this.activeDataGridViewCheckBoxColumn,
            this.poundsPerBushelDataGridViewTextBoxColumn,
            this.btnDelete});
            this.customersDataGridView.DataSource = this.commoditiesBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(21, 124);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowTemplate.Height = 40;
            this.customersDataGridView.Size = new System.Drawing.Size(916, 463);
            this.customersDataGridView.TabIndex = 9;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            // 
            // commodity
            // 
            this.commodity.ActiveLinkColor = System.Drawing.Color.Black;
            this.commodity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commodity.DataPropertyName = "Commodity";
            this.commodity.HeaderText = "Commodity";
            this.commodity.LinkColor = System.Drawing.Color.Black;
            this.commodity.Name = "commodity";
            this.commodity.ReadOnly = true;
            this.commodity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.commodity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.commodity.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // poundsPerBushelDataGridViewTextBoxColumn
            // 
            this.poundsPerBushelDataGridViewTextBoxColumn.DataPropertyName = "Pounds_Per_Bushel";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.poundsPerBushelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.poundsPerBushelDataGridViewTextBoxColumn.HeaderText = "# Per Bushel";
            this.poundsPerBushelDataGridViewTextBoxColumn.Name = "poundsPerBushelDataGridViewTextBoxColumn";
            this.poundsPerBushelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.DataPropertyName = "btnDelete";
            this.btnDelete.HeaderText = "";
            this.btnDelete.LinkColor = System.Drawing.Color.Red;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.VisitedLinkColor = System.Drawing.Color.Red;
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
            // frmCommodities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 673);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.customersDataGridView);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmCommodities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commodities";
            this.Load += new System.EventHandler(this.Commodities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource commoditiesBindingSource;
        private Seed_Storage_DatasetTableAdapters.CommoditiesTableAdapter commoditiesTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn commodity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poundsPerBushelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
    }
}