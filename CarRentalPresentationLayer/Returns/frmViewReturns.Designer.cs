namespace CarRentalPresentationLayer.Returns
{
    partial class frmViewReturns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReturns));
            this.cmsRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showReturnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::CarRentalPresentationLayer.Properties.Resources.BigReturns;
            this.pbImage.Location = new System.Drawing.Point(495, 3);
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(309, 206);
            this.lblTitle.Size = new System.Drawing.Size(572, 64);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1067, 294);
            // 
            // cbFilters
            // 
            this.cbFilters.Size = new System.Drawing.Size(227, 29);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(347, 352);
            this.txtFilter.Size = new System.Drawing.Size(227, 29);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(1020, 772);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1157, 332);
            // 
            // cmsRecord
            // 
            this.cmsRecord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReturnDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showBookingDetailsToolStripMenuItem});
            this.cmsRecord.Name = "contextMenuStrip1";
            this.cmsRecord.Size = new System.Drawing.Size(282, 139);
            // 
            // showReturnDetailsToolStripMenuItem
            // 
            this.showReturnDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showReturnDetailsToolStripMenuItem.Image")));
            this.showReturnDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showReturnDetailsToolStripMenuItem.Name = "showReturnDetailsToolStripMenuItem";
            this.showReturnDetailsToolStripMenuItem.Size = new System.Drawing.Size(281, 48);
            this.showReturnDetailsToolStripMenuItem.Text = "Show Return Details";
            this.showReturnDetailsToolStripMenuItem.Click += new System.EventHandler(this.showReturnDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
            // 
            // showBookingDetailsToolStripMenuItem
            // 
            this.showBookingDetailsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.showDetails2;
            this.showBookingDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showBookingDetailsToolStripMenuItem.Name = "showBookingDetailsToolStripMenuItem";
            this.showBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(281, 48);
            this.showBookingDetailsToolStripMenuItem.Text = "Show Booking Details";
            this.showBookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showBookingDetailsToolStripMenuItem_Click);
            // 
            // frmViewReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 833);
            this.Name = "frmViewReturns";
            this.Text = "View Returns";
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
        private System.Windows.Forms.ToolStripMenuItem showReturnDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showBookingDetailsToolStripMenuItem;
    }
}