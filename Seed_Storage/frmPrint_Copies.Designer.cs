namespace Seed_Storage
{
    partial class frmPrint_Copies
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
            this.lbl_HowManyCopies = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_NumberofCopies = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_HowManyCopies
            // 
            this.lbl_HowManyCopies.AutoSize = true;
            this.lbl_HowManyCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HowManyCopies.Location = new System.Drawing.Point(12, 21);
            this.lbl_HowManyCopies.Name = "lbl_HowManyCopies";
            this.lbl_HowManyCopies.Size = new System.Drawing.Size(229, 20);
            this.lbl_HowManyCopies.TabIndex = 0;
            this.lbl_HowManyCopies.Text = "How Many Copies to Print ?";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(166, 51);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // cb_NumberofCopies
            // 
            this.cb_NumberofCopies.FormatString = "N0";
            this.cb_NumberofCopies.FormattingEnabled = true;
            this.cb_NumberofCopies.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_NumberofCopies.Location = new System.Drawing.Point(259, 20);
            this.cb_NumberofCopies.Name = "cb_NumberofCopies";
            this.cb_NumberofCopies.Size = new System.Drawing.Size(49, 21);
            this.cb_NumberofCopies.Sorted = true;
            this.cb_NumberofCopies.TabIndex = 1;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(85, 51);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // frmPrint_Copies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 86);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.cb_NumberofCopies);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_HowManyCopies);
            this.Name = "frmPrint_Copies";
            this.Text = "Print_Copies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HowManyCopies;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cb_NumberofCopies;
        private System.Windows.Forms.Button btn_Print;
    }
}