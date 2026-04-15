namespace Seed_Storage
{
    partial class frmTicketDetails
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
            System.Windows.Forms.Label ticketLabel;
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.vwTicket_InformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTicket_InformationTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.ticketLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            ticketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTicket_InformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketLabel
            // 
            ticketLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ticketLabel.Location = new System.Drawing.Point(247, 9);
            ticketLabel.Name = "ticketLabel";
            ticketLabel.Size = new System.Drawing.Size(81, 27);
            ticketLabel.TabIndex = 1;
            ticketLabel.Text = "Ticket:";
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwTicket_InformationBindingSource
            // 
            this.vwTicket_InformationBindingSource.DataMember = "vwTicket_Information";
            this.vwTicket_InformationBindingSource.DataSource = this.seed_Storage_Dataset;
            // 
            // vwTicket_InformationTableAdapter
            // 
            this.vwTicket_InformationTableAdapter.ClearBeforeFill = true;
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
            // ticketLabel1
            // 
            this.ticketLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ticketLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwTicket_InformationBindingSource, "Ticket", true));
            this.ticketLabel1.Location = new System.Drawing.Point(334, 9);
            this.ticketLabel1.Name = "ticketLabel1";
            this.ticketLabel1.Size = new System.Drawing.Size(195, 27);
            this.ticketLabel1.TabIndex = 2;
            this.ticketLabel1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(231, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePictureBox.Location = new System.Drawing.Point(12, 79);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(657, 451);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePictureBox.TabIndex = 8;
            this.picturePictureBox.TabStop = false;
            // 
            // frmTicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 652);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(ticketLabel);
            this.Controls.Add(this.ticketLabel1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimizeBox = false;
            this.Name = "frmTicketDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTicketDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTicket_InformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource vwTicket_InformationBindingSource;
        private Seed_Storage_DatasetTableAdapters.vwTicket_InformationTableAdapter vwTicket_InformationTableAdapter;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label ticketLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picturePictureBox;
    }
}