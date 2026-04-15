namespace Seed_Storage
{
    partial class frmAdjust_Bin
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblStartBushels;
            System.Windows.Forms.Label capacityLabel;
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.binsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numStartingBushels = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblBin = new System.Windows.Forms.Label();
            this.binsTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.BinsTableAdapter();
            label2 = new System.Windows.Forms.Label();
            lblStartBushels = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingBushels)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 162);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(342, 35);
            label2.TabIndex = 29;
            label2.Text = "Starting Date for Reports";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStartBushels
            // 
            lblStartBushels.AutoSize = true;
            lblStartBushels.Location = new System.Drawing.Point(193, 119);
            lblStartBushels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStartBushels.Name = "lblStartBushels";
            lblStartBushels.Size = new System.Drawing.Size(243, 35);
            lblStartBushels.TabIndex = 25;
            lblStartBushels.Text = "Starting Wt in lbs";
            lblStartBushels.Click += new System.EventHandler(this.lblStartBushels_Click);
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(158, 77);
            capacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(278, 35);
            capacityLabel.TabIndex = 22;
            capacityLabel.Text = "Capacity in Bushels";
            capacityLabel.Click += new System.EventHandler(this.capacityLabel_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binsBindingSource, "Starting_Time", true));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(444, 156);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(320, 42);
            this.dtStartDate.TabIndex = 28;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
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
            // numCapacity
            // 
            this.numCapacity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binsBindingSource, "Capacity", true));
            this.numCapacity.Location = new System.Drawing.Point(444, 70);
            this.numCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numCapacity.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(321, 42);
            this.numCapacity.TabIndex = 27;
            this.numCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCapacity.ValueChanged += new System.EventHandler(this.numCapacity_ValueChanged);
            // 
            // numStartingBushels
            // 
            this.numStartingBushels.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binsBindingSource, "Starting_Bushels", true));
            this.numStartingBushels.Location = new System.Drawing.Point(445, 117);
            this.numStartingBushels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numStartingBushels.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numStartingBushels.Name = "numStartingBushels";
            this.numStartingBushels.Size = new System.Drawing.Size(319, 42);
            this.numStartingBushels.TabIndex = 26;
            this.numStartingBushels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStartingBushels.ValueChanged += new System.EventHandler(this.numStartingBushels_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(475, 215);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 55);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(272, 216);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(178, 55);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblBin
            // 
            this.lblBin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binsBindingSource, "Bin", true));
            this.lblBin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBin.Location = new System.Drawing.Point(0, 0);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(820, 46);
            this.lblBin.TabIndex = 30;
            this.lblBin.Text = "label1";
            this.lblBin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binsTableAdapter
            // 
            this.binsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdjust_Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 284);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numStartingBushels);
            this.Controls.Add(lblStartBushels);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(capacityLabel);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmAdjust_Bin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjust Bin";
            this.Load += new System.EventHandler(this.frmAdjust_Bin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartingBushels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.NumericUpDown numStartingBushels;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblBin;
        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource binsBindingSource;
        private Seed_Storage_DatasetTableAdapters.BinsTableAdapter binsTableAdapter;
    }
}