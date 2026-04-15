namespace Seed_Storage
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblMotion = new System.Windows.Forms.Label();
            this.lblScaleWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.vw_Inbound_TicketsTableAdapter1 = new Seed_Storage.Seed_Storage_DatasetTableAdapters.vw_Inbound_TicketsTableAdapter();
            this.videoInbound = new LibVLCSharp.WinForms.VideoView();
            this.videoOutbound = new LibVLCSharp.WinForms.VideoView();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblConnectionStatus);
            this.panel1.Controls.Add(this.lblMotion);
            this.panel1.Controls.Add(this.lblScaleWeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 90);
            this.panel1.TabIndex = 12;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(234, 25);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(44, 36);
            this.lblConnectionStatus.TabIndex = 3;
            this.lblConnectionStatus.Text = "-";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotion
            // 
            this.lblMotion.BackColor = System.Drawing.Color.Red;
            this.lblMotion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.ForeColor = System.Drawing.Color.White;
            this.lblMotion.Location = new System.Drawing.Point(0, 62);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(282, 28);
            this.lblMotion.TabIndex = 2;
            this.lblMotion.Text = "MOTION";
            this.lblMotion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMotion.Visible = false;
            // 
            // lblScaleWeight
            // 
            this.lblScaleWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaleWeight.Location = new System.Drawing.Point(0, 25);
            this.lblScaleWeight.Name = "lblScaleWeight";
            this.lblScaleWeight.Size = new System.Drawing.Size(228, 36);
            this.lblScaleWeight.TabIndex = 1;
            this.lblScaleWeight.Text = "0";
            this.lblScaleWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(47, 651);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 79);
            this.button4.TabIndex = 11;
            this.button4.Text = "View Finished Tickets";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(47, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 79);
            this.button3.TabIndex = 10;
            this.button3.Text = " Trucks In Yard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(47, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 79);
            this.button2.TabIndex = 9;
            this.button2.Text = "New Recieving Ticket";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShipping.ForeColor = System.Drawing.Color.White;
            this.btnShipping.Location = new System.Drawing.Point(47, 174);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(232, 79);
            this.btnShipping.TabIndex = 8;
            this.btnShipping.Text = "New Shipping Ticket";
            this.btnShipping.UseVisualStyleBackColor = false;
            this.btnShipping.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "What Do You Want To Do";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(47, 738);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 79);
            this.button5.TabIndex = 19;
            this.button5.Text = "Inventory";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(47, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 79);
            this.button6.TabIndex = 20;
            this.button6.Text = "New Generic Ticket";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // vw_Inbound_TicketsTableAdapter1
            // 
            this.vw_Inbound_TicketsTableAdapter1.ClearBeforeFill = true;
            // 
            // videoInbound
            // 
            this.videoInbound.BackColor = System.Drawing.Color.Black;
            this.videoInbound.Location = new System.Drawing.Point(376, 70);
            this.videoInbound.MediaPlayer = null;
            this.videoInbound.Name = "videoInbound";
            this.videoInbound.Size = new System.Drawing.Size(546, 365);
            this.videoInbound.TabIndex = 21;
            this.videoInbound.Text = "videoView1";
            // 
            // videoOutbound
            // 
            this.videoOutbound.BackColor = System.Drawing.Color.Black;
            this.videoOutbound.Location = new System.Drawing.Point(376, 452);
            this.videoOutbound.MediaPlayer = null;
            this.videoOutbound.Name = "videoOutbound";
            this.videoOutbound.Size = new System.Drawing.Size(546, 365);
            this.videoOutbound.TabIndex = 22;
            this.videoOutbound.Text = "videoView2";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 830);
            this.Controls.Add(this.videoOutbound);
            this.Controls.Add(this.videoInbound);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eckhart Farms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoInbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoOutbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScaleWeight;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Seed_Storage_DatasetTableAdapters.vw_Inbound_TicketsTableAdapter vw_Inbound_TicketsTableAdapter1;
        private LibVLCSharp.WinForms.VideoView videoInbound;
        private LibVLCSharp.WinForms.VideoView videoOutbound;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

