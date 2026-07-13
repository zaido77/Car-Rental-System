namespace CarRentalPresentationLayer.Transactions
{
    partial class frmViewTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTransactions));
            this.cmsRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTransactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::CarRentalPresentationLayer.Properties.Resources.BigTransactions;
            this.pbImage.Location = new System.Drawing.Point(609, 12);
            this.pbImage.Size = new System.Drawing.Size(180, 180);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 755);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Location = new System.Drawing.Point(109, 755);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(314, 195);
            this.lblTitle.Size = new System.Drawing.Size(770, 64);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1274, 294);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 355);
            // 
            // cbFilters
            // 
            this.cbFilters.Location = new System.Drawing.Point(114, 354);
            this.cbFilters.Size = new System.Drawing.Size(272, 29);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(392, 354);
            this.txtFilter.Size = new System.Drawing.Size(272, 29);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(1227, 783);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1364, 362);
            // 
            // cmsRecord
            // 
            this.cmsRecord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionDetailsToolStripMenuItem});
            this.cmsRecord.Name = "contextMenuStrip1";
            this.cmsRecord.Size = new System.Drawing.Size(304, 85);
            // 
            // showTransactionDetailsToolStripMenuItem
            // 
            this.showTransactionDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showTransactionDetailsToolStripMenuItem.Image")));
            this.showTransactionDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showTransactionDetailsToolStripMenuItem.Name = "showTransactionDetailsToolStripMenuItem";
            this.showTransactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(303, 48);
            this.showTransactionDetailsToolStripMenuItem.Text = "Show Transaction Details";
            this.showTransactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.showTransactionDetailsToolStripMenuItem_Click);
            // 
            // frmViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1393, 844);
            this.Name = "frmViewTransactions";
            this.Text = "View Transactions";
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.pbImage, 0);
            this.Controls.SetChildIndex(this.lblNumberOfRecords, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbFilters, 0);
            this.Controls.SetChildIndex(this.txtFilter, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cmsRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsRecord;
        private System.Windows.Forms.ToolStripMenuItem showTransactionDetailsToolStripMenuItem;
    }
}