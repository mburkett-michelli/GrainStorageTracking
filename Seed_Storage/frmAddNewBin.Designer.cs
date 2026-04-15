namespace Seed_Storage
{
    partial class frmAddNewBin
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
            System.Windows.Forms.Label binLabel;
            System.Windows.Forms.Label varietyLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label lblStartBushels;
            System.Windows.Forms.Label label2;
            this.binsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.binTextBox = new System.Windows.Forms.TextBox();
            this.use_For_Inbound_LoadsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVariety = new System.Windows.Forms.ComboBox();
            this.varietiesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.varietiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.varietiesTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter();
            this.binsTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.BinsTableAdapter();
            this.numStartingBushels = new System.Windows.Forms.NumericUpDown();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.varietiesListTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.VarietiesListTableAdapter();
            binLabel = new System.Windows.Forms.Label();
            varietyLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            lblStartBushels = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingBushels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // binLabel
            // 
            binLabel.AutoSize = true;
            binLabel.Location = new System.Drawing.Point(174, 53);
            binLabel.Name = "binLabel";
            binLabel.Size = new System.Drawing.Size(54, 27);
            binLabel.TabIndex = 3;
            binLabel.Text = "Bin:";
            // 
            // varietyLabel
            // 
            varietyLabel.AutoSize = true;
            varietyLabel.Location = new System.Drawing.Point(138, 148);
            varietyLabel.Name = "varietyLabel";
            varietyLabel.Size = new System.Drawing.Size(90, 27);
            varietyLabel.TabIndex = 5;
            varietyLabel.Text = "Variety:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(109, 207);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(119, 27);
            capacityLabel.TabIndex = 9;
            capacityLabel.Text = "Capacity :";
            capacityLabel.Click += new System.EventHandler(this.capacityLabel_Click);
            // 
            // lblStartBushels
            // 
            lblStartBushels.AutoSize = true;
            lblStartBushels.Location = new System.Drawing.Point(24, 261);
            lblStartBushels.Name = "lblStartBushels";
            lblStartBushels.Size = new System.Drawing.Size(204, 27);
            lblStartBushels.TabIndex = 17;
            lblStartBushels.Text = "Starting Bushels :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 315);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(167, 27);
            label2.TabIndex = 21;
            label2.Text = "Starting Date :";
            // 
            // binsBindingSource
            // 
            this.binsBindingSource.DataMember = "Bins";
            // 
            // binTextBox
            // 
            this.binTextBox.Location = new System.Drawing.Point(234, 50);
            this.binTextBox.Name = "binTextBox";
            this.binTextBox.Size = new System.Drawing.Size(322, 35);
            this.binTextBox.TabIndex = 4;
            // 
            // use_For_Inbound_LoadsCheckBox
            // 
            this.use_For_Inbound_LoadsCheckBox.Checked = true;
            this.use_For_Inbound_LoadsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.use_For_Inbound_LoadsCheckBox.Location = new System.Drawing.Point(234, 91);
            this.use_For_Inbound_LoadsCheckBox.Name = "use_For_Inbound_LoadsCheckBox";
            this.use_For_Inbound_LoadsCheckBox.Size = new System.Drawing.Size(316, 43);
            this.use_For_Inbound_LoadsCheckBox.TabIndex = 8;
            this.use_For_Inbound_LoadsCheckBox.Text = "Use For Inbound Loads";
            this.use_For_Inbound_LoadsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New Bin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboVariety
            // 
            this.cboVariety.DataSource = this.varietiesListBindingSource;
            this.cboVariety.DisplayMember = "Variety";
            this.cboVariety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVariety.FormattingEnabled = true;
            this.cboVariety.Location = new System.Drawing.Point(234, 140);
            this.cboVariety.Name = "cboVariety";
            this.cboVariety.Size = new System.Drawing.Size(322, 35);
            this.cboVariety.TabIndex = 14;
            this.cboVariety.ValueMember = "Variety";
            // 
            // varietiesListBindingSource
            // 
            this.varietiesListBindingSource.DataMember = "VarietiesList";
            this.varietiesListBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varietiesBindingSource
            // 
            this.varietiesBindingSource.DataMember = "Varieties";
            this.varietiesBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(394, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 59);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(234, 373);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 59);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // varietiesTableAdapter
            // 
            this.varietiesTableAdapter.ClearBeforeFill = true;
            // 
            // binsTableAdapter
            // 
            this.binsTableAdapter.ClearBeforeFill = true;
            // 
            // numStartingBushels
            // 
            this.numStartingBushels.Location = new System.Drawing.Point(234, 253);
            this.numStartingBushels.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numStartingBushels.Name = "numStartingBushels";
            this.numStartingBushels.Size = new System.Drawing.Size(251, 35);
            this.numStartingBushels.TabIndex = 18;
            this.numStartingBushels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(234, 199);
            this.numCapacity.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(252, 35);
            this.numCapacity.TabIndex = 19;
            this.numCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(234, 309);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(252, 35);
            this.dtStartDate.TabIndex = 20;
            // 
            // varietiesListTableAdapter
            // 
            this.varietiesListTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddNewBin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 461);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numStartingBushels);
            this.Controls.Add(lblStartBushels);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboVariety);
            this.Controls.Add(this.label1);
            this.Controls.Add(binLabel);
            this.Controls.Add(this.binTextBox);
            this.Controls.Add(varietyLabel);
            this.Controls.Add(this.use_For_Inbound_LoadsCheckBox);
            this.Controls.Add(capacityLabel);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmAddNewBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bin";
            this.Load += new System.EventHandler(this.frmAddNewBin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varietiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingBushels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource binsBindingSource;
        private System.Windows.Forms.TextBox binTextBox;
        private System.Windows.Forms.CheckBox use_For_Inbound_LoadsCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVariety;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource varietiesBindingSource;
        private Seed_Storage_DatasetTableAdapters.VarietiesTableAdapter varietiesTableAdapter;
        private Seed_Storage_DatasetTableAdapters.BinsTableAdapter binsTableAdapter;
        private System.Windows.Forms.NumericUpDown numStartingBushels;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.BindingSource varietiesListBindingSource;
        private Seed_Storage_DatasetTableAdapters.VarietiesListTableAdapter varietiesListTableAdapter;
    }
}