namespace Seed_Storage
{
    partial class frmSetup
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
            System.Windows.Forms.Label setup_PasswordLabel;
            System.Windows.Forms.Label inbound_Camera_IP_AddressLabel;
            System.Windows.Forms.Label outbound_Camera_IP_AddressLabel;
            System.Windows.Forms.Label inbound_Camera_Admin_PassLabel;
            System.Windows.Forms.Label outbound_Camera_Admin_PassLabel;
            System.Windows.Forms.Label scale_IP_AddressLabel;
            System.Windows.Forms.Label scale_PortLabel;
            System.Windows.Forms.Label update_RateLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.setup_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.system_SetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seed_Storage_Dataset = new Seed_Storage.Seed_Storage_Dataset();
            this.inbound_Camera_IP_AddressTextBox = new System.Windows.Forms.TextBox();
            this.outbound_Camera_IP_AddressTextBox = new System.Windows.Forms.TextBox();
            this.inbound_Camera_Admin_PassTextBox = new System.Windows.Forms.TextBox();
            this.outbound_Camera_Admin_PassTextBox = new System.Windows.Forms.TextBox();
            this.scale_IP_AddressTextBox = new System.Windows.Forms.TextBox();
            this.scale_PortTextBox = new System.Windows.Forms.TextBox();
            this.update_RateTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.system_SetupTableAdapter = new Seed_Storage.Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter();
            this.tableAdapterManager = new Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager();
            this.btnHeaders = new System.Windows.Forms.Button();
            setup_PasswordLabel = new System.Windows.Forms.Label();
            inbound_Camera_IP_AddressLabel = new System.Windows.Forms.Label();
            outbound_Camera_IP_AddressLabel = new System.Windows.Forms.Label();
            inbound_Camera_Admin_PassLabel = new System.Windows.Forms.Label();
            outbound_Camera_Admin_PassLabel = new System.Windows.Forms.Label();
            scale_IP_AddressLabel = new System.Windows.Forms.Label();
            scale_PortLabel = new System.Windows.Forms.Label();
            update_RateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.system_SetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setup_PasswordLabel
            // 
            setup_PasswordLabel.Location = new System.Drawing.Point(100, 90);
            setup_PasswordLabel.Name = "setup_PasswordLabel";
            setup_PasswordLabel.Size = new System.Drawing.Size(162, 29);
            setup_PasswordLabel.TabIndex = 17;
            setup_PasswordLabel.Text = "Setup Password:";
            // 
            // inbound_Camera_IP_AddressLabel
            // 
            inbound_Camera_IP_AddressLabel.Location = new System.Drawing.Point(100, 131);
            inbound_Camera_IP_AddressLabel.Name = "inbound_Camera_IP_AddressLabel";
            inbound_Camera_IP_AddressLabel.Size = new System.Drawing.Size(263, 29);
            inbound_Camera_IP_AddressLabel.TabIndex = 19;
            inbound_Camera_IP_AddressLabel.Text = "Inbound Camera IP Address:";
            // 
            // outbound_Camera_IP_AddressLabel
            // 
            outbound_Camera_IP_AddressLabel.Location = new System.Drawing.Point(100, 172);
            outbound_Camera_IP_AddressLabel.Name = "outbound_Camera_IP_AddressLabel";
            outbound_Camera_IP_AddressLabel.Size = new System.Drawing.Size(279, 29);
            outbound_Camera_IP_AddressLabel.TabIndex = 21;
            outbound_Camera_IP_AddressLabel.Text = "Outbound Camera IP Address:";
            // 
            // inbound_Camera_Admin_PassLabel
            // 
            inbound_Camera_Admin_PassLabel.Location = new System.Drawing.Point(100, 213);
            inbound_Camera_Admin_PassLabel.Name = "inbound_Camera_Admin_PassLabel";
            inbound_Camera_Admin_PassLabel.Size = new System.Drawing.Size(272, 29);
            inbound_Camera_Admin_PassLabel.TabIndex = 23;
            inbound_Camera_Admin_PassLabel.Text = "Inbound Camera Admin Pass:";
            // 
            // outbound_Camera_Admin_PassLabel
            // 
            outbound_Camera_Admin_PassLabel.Location = new System.Drawing.Point(100, 254);
            outbound_Camera_Admin_PassLabel.Name = "outbound_Camera_Admin_PassLabel";
            outbound_Camera_Admin_PassLabel.Size = new System.Drawing.Size(288, 29);
            outbound_Camera_Admin_PassLabel.TabIndex = 25;
            outbound_Camera_Admin_PassLabel.Text = "Outbound Camera Admin Pass:";
            // 
            // scale_IP_AddressLabel
            // 
            scale_IP_AddressLabel.Location = new System.Drawing.Point(8, 6);
            scale_IP_AddressLabel.Name = "scale_IP_AddressLabel";
            scale_IP_AddressLabel.Size = new System.Drawing.Size(167, 29);
            scale_IP_AddressLabel.TabIndex = 27;
            scale_IP_AddressLabel.Text = "Scale IP Address:";
            // 
            // scale_PortLabel
            // 
            scale_PortLabel.Location = new System.Drawing.Point(8, 50);
            scale_PortLabel.Name = "scale_PortLabel";
            scale_PortLabel.Size = new System.Drawing.Size(108, 29);
            scale_PortLabel.TabIndex = 28;
            scale_PortLabel.Text = "Scale Port:";
            // 
            // update_RateLabel
            // 
            update_RateLabel.Location = new System.Drawing.Point(8, 92);
            update_RateLabel.Name = "update_RateLabel";
            update_RateLabel.Size = new System.Drawing.Size(306, 29);
            update_RateLabel.TabIndex = 29;
            update_RateLabel.Text = "Scale Update Rate (milliseconds):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setup_PasswordTextBox
            // 
            this.setup_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Setup_Password", true));
            this.setup_PasswordTextBox.Location = new System.Drawing.Point(474, 87);
            this.setup_PasswordTextBox.Name = "setup_PasswordTextBox";
            this.setup_PasswordTextBox.Size = new System.Drawing.Size(370, 35);
            this.setup_PasswordTextBox.TabIndex = 18;
            // 
            // system_SetupBindingSource
            // 
            this.system_SetupBindingSource.DataMember = "System_Setup";
            this.system_SetupBindingSource.DataSource = this.seed_Storage_Dataset;
            this.system_SetupBindingSource.CurrentChanged += new System.EventHandler(this.system_SetupBindingSource_CurrentChanged);
            // 
            // seed_Storage_Dataset
            // 
            this.seed_Storage_Dataset.DataSetName = "Seed_Storage_Dataset";
            this.seed_Storage_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inbound_Camera_IP_AddressTextBox
            // 
            this.inbound_Camera_IP_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Inbound_Camera_IP_Address", true));
            this.inbound_Camera_IP_AddressTextBox.Location = new System.Drawing.Point(474, 128);
            this.inbound_Camera_IP_AddressTextBox.Name = "inbound_Camera_IP_AddressTextBox";
            this.inbound_Camera_IP_AddressTextBox.Size = new System.Drawing.Size(182, 35);
            this.inbound_Camera_IP_AddressTextBox.TabIndex = 20;
            // 
            // outbound_Camera_IP_AddressTextBox
            // 
            this.outbound_Camera_IP_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Outbound_Camera_IP_Address", true));
            this.outbound_Camera_IP_AddressTextBox.Location = new System.Drawing.Point(474, 169);
            this.outbound_Camera_IP_AddressTextBox.Name = "outbound_Camera_IP_AddressTextBox";
            this.outbound_Camera_IP_AddressTextBox.Size = new System.Drawing.Size(182, 35);
            this.outbound_Camera_IP_AddressTextBox.TabIndex = 22;
            // 
            // inbound_Camera_Admin_PassTextBox
            // 
            this.inbound_Camera_Admin_PassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Inbound_Camera_Admin_Pass", true));
            this.inbound_Camera_Admin_PassTextBox.Location = new System.Drawing.Point(474, 210);
            this.inbound_Camera_Admin_PassTextBox.Name = "inbound_Camera_Admin_PassTextBox";
            this.inbound_Camera_Admin_PassTextBox.Size = new System.Drawing.Size(290, 35);
            this.inbound_Camera_Admin_PassTextBox.TabIndex = 24;
            // 
            // outbound_Camera_Admin_PassTextBox
            // 
            this.outbound_Camera_Admin_PassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Outbound_Camera_Admin_Pass", true));
            this.outbound_Camera_Admin_PassTextBox.Location = new System.Drawing.Point(474, 251);
            this.outbound_Camera_Admin_PassTextBox.Name = "outbound_Camera_Admin_PassTextBox";
            this.outbound_Camera_Admin_PassTextBox.Size = new System.Drawing.Size(290, 35);
            this.outbound_Camera_Admin_PassTextBox.TabIndex = 26;
            // 
            // scale_IP_AddressTextBox
            // 
            this.scale_IP_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Scale_IP_Address", true));
            this.scale_IP_AddressTextBox.Location = new System.Drawing.Point(382, 3);
            this.scale_IP_AddressTextBox.Name = "scale_IP_AddressTextBox";
            this.scale_IP_AddressTextBox.Size = new System.Drawing.Size(182, 35);
            this.scale_IP_AddressTextBox.TabIndex = 28;
            // 
            // scale_PortTextBox
            // 
            this.scale_PortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Scale_Port", true));
            this.scale_PortTextBox.Location = new System.Drawing.Point(382, 44);
            this.scale_PortTextBox.Name = "scale_PortTextBox";
            this.scale_PortTextBox.Size = new System.Drawing.Size(100, 35);
            this.scale_PortTextBox.TabIndex = 29;
            this.scale_PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // update_RateTextBox
            // 
            this.update_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.system_SetupBindingSource, "Update_Rate", true));
            this.update_RateTextBox.Location = new System.Drawing.Point(382, 89);
            this.update_RateTextBox.Name = "update_RateTextBox";
            this.update_RateTextBox.Size = new System.Drawing.Size(100, 35);
            this.update_RateTextBox.TabIndex = 30;
            this.update_RateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(update_RateLabel);
            this.panel1.Controls.Add(this.update_RateTextBox);
            this.panel1.Controls.Add(scale_PortLabel);
            this.panel1.Controls.Add(this.scale_PortTextBox);
            this.panel1.Controls.Add(scale_IP_AddressLabel);
            this.panel1.Controls.Add(this.scale_IP_AddressTextBox);
            this.panel1.Location = new System.Drawing.Point(91, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 157);
            this.panel1.TabIndex = 31;
            // 
            // system_SetupTableAdapter
            // 
            this.system_SetupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinsTableAdapter = null;
            this.tableAdapterManager.CommoditiesTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.GrowersTableAdapter = null;
            this.tableAdapterManager.GTN_TicketTableAdapter = null;
            this.tableAdapterManager.HeadersTableAdapter = null;
            this.tableAdapterManager.RecievingTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.System_SetupTableAdapter = this.system_SetupTableAdapter;
            this.tableAdapterManager.Ticket_WeightsTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Seed_Storage.Seed_Storage_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VarietiesTableAdapter = null;
            // 
            // btnHeaders
            // 
            this.btnHeaders.Location = new System.Drawing.Point(105, 36);
            this.btnHeaders.Name = "btnHeaders";
            this.btnHeaders.Size = new System.Drawing.Size(739, 45);
            this.btnHeaders.TabIndex = 38;
            this.btnHeaders.Text = "Set Headers for Ticket Type";
            this.btnHeaders.UseVisualStyleBackColor = true;
            this.btnHeaders.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.btnHeaders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(setup_PasswordLabel);
            this.Controls.Add(this.setup_PasswordTextBox);
            this.Controls.Add(inbound_Camera_IP_AddressLabel);
            this.Controls.Add(this.inbound_Camera_IP_AddressTextBox);
            this.Controls.Add(outbound_Camera_IP_AddressLabel);
            this.Controls.Add(this.outbound_Camera_IP_AddressTextBox);
            this.Controls.Add(inbound_Camera_Admin_PassLabel);
            this.Controls.Add(this.inbound_Camera_Admin_PassTextBox);
            this.Controls.Add(outbound_Camera_Admin_PassLabel);
            this.Controls.Add(this.outbound_Camera_Admin_PassTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.system_SetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_Storage_Dataset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Seed_Storage_Dataset seed_Storage_Dataset;
        private System.Windows.Forms.BindingSource system_SetupBindingSource;
        private Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter system_SetupTableAdapter;
        private Seed_Storage_DatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox setup_PasswordTextBox;
        private System.Windows.Forms.TextBox inbound_Camera_IP_AddressTextBox;
        private System.Windows.Forms.TextBox outbound_Camera_IP_AddressTextBox;
        private System.Windows.Forms.TextBox inbound_Camera_Admin_PassTextBox;
        private System.Windows.Forms.TextBox outbound_Camera_Admin_PassTextBox;
        private System.Windows.Forms.TextBox scale_IP_AddressTextBox;
        private System.Windows.Forms.TextBox scale_PortTextBox;
        private System.Windows.Forms.TextBox update_RateTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHeaders;
    }
}