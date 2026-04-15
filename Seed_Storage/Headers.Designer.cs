namespace Seed_Storage
{
    partial class Headers
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
            System.Windows.Forms.Label load_TypeLabel;
            System.Windows.Forms.Label header1Label;
            System.Windows.Forms.Label header2Label;
            System.Windows.Forms.Label header3Label;
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.headersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headersTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.HeadersTableAdapter();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.header1TextBox = new System.Windows.Forms.TextBox();
            this.header2TextBox = new System.Windows.Forms.TextBox();
            this.header3TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            load_TypeLabel = new System.Windows.Forms.Label();
            header1Label = new System.Windows.Forms.Label();
            header2Label = new System.Windows.Forms.Label();
            header3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // load_TypeLabel
            // 
            load_TypeLabel.AutoSize = true;
            load_TypeLabel.Location = new System.Drawing.Point(16, 38);
            load_TypeLabel.Name = "load_TypeLabel";
            load_TypeLabel.Size = new System.Drawing.Size(131, 27);
            load_TypeLabel.TabIndex = 0;
            load_TypeLabel.Text = "Load Type:";
            // 
            // header1Label
            // 
            header1Label.AutoSize = true;
            header1Label.Location = new System.Drawing.Point(16, 79);
            header1Label.Name = "header1Label";
            header1Label.Size = new System.Drawing.Size(110, 27);
            header1Label.TabIndex = 2;
            header1Label.Text = "Header1:";
            // 
            // header2Label
            // 
            header2Label.AutoSize = true;
            header2Label.Location = new System.Drawing.Point(16, 120);
            header2Label.Name = "header2Label";
            header2Label.Size = new System.Drawing.Size(110, 27);
            header2Label.TabIndex = 4;
            header2Label.Text = "Header2:";
            // 
            // header3Label
            // 
            header3Label.AutoSize = true;
            header3Label.Location = new System.Drawing.Point(16, 161);
            header3Label.Name = "header3Label";
            header3Label.Size = new System.Drawing.Size(110, 27);
            header3Label.TabIndex = 6;
            header3Label.Text = "Header3:";
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // headersBindingSource
            // 
            this.headersBindingSource.DataMember = "Headers";
            this.headersBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // headersTableAdapter
            // 
            this.headersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinsTableAdapter = null;
            this.tableAdapterManager.CommoditiesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.GrowersTableAdapter = null;
            this.tableAdapterManager.GTN_TicketTableAdapter = null;
            this.tableAdapterManager.HeadersTableAdapter = this.headersTableAdapter;
            this.tableAdapterManager.RecievingTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.System_SetupTableAdapter = null;
            this.tableAdapterManager.Ticket_WeightsTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarietiesTableAdapter = null;
            // 
            // header1TextBox
            // 
            this.header1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headersBindingSource, "Header1", true));
            this.header1TextBox.Location = new System.Drawing.Point(153, 76);
            this.header1TextBox.Name = "header1TextBox";
            this.header1TextBox.Size = new System.Drawing.Size(632, 35);
            this.header1TextBox.TabIndex = 3;
            // 
            // header2TextBox
            // 
            this.header2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headersBindingSource, "Header2", true));
            this.header2TextBox.Location = new System.Drawing.Point(153, 117);
            this.header2TextBox.Name = "header2TextBox";
            this.header2TextBox.Size = new System.Drawing.Size(632, 35);
            this.header2TextBox.TabIndex = 5;
            // 
            // header3TextBox
            // 
            this.header3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.headersBindingSource, "Header3", true));
            this.header3TextBox.Location = new System.Drawing.Point(153, 158);
            this.header3TextBox.Name = "header3TextBox";
            this.header3TextBox.Size = new System.Drawing.Size(632, 35);
            this.header3TextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.headersBindingSource;
            this.comboBox1.DisplayMember = "Load_Type";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 35);
            this.comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save and Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Headers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(load_TypeLabel);
            this.Controls.Add(header1Label);
            this.Controls.Add(this.header1TextBox);
            this.Controls.Add(header2Label);
            this.Controls.Add(this.header2TextBox);
            this.Controls.Add(header3Label);
            this.Controls.Add(this.header3TextBox);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Headers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Headers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Headers_FormClosing);
            this.Load += new System.EventHandler(this.Headers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource headersBindingSource;
        private Seed_Storage_DatasetTableAdapters.HeadersTableAdapter headersTableAdapter;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox header1TextBox;
        private System.Windows.Forms.TextBox header2TextBox;
        private System.Windows.Forms.TextBox header3TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}