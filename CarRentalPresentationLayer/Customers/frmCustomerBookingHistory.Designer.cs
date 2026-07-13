namespace CarRentalPresentationLayer.Customers
{
    partial class frmCustomerBookingHistory
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
            this.gbCustomerBookings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllCustomerBookings = new System.Windows.Forms.DataGridView();
            this.cmsBooking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.showBookingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucCustomerInfo1 = new CarRentalPresentationLayer.UserControls.ucCustomerInfo();
            this.gbCustomerBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomerBookings)).BeginInit();
            this.cmsBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerBookings
            // 
            this.gbCustomerBookings.Controls.Add(this.label3);
            this.gbCustomerBookings.Controls.Add(this.dgvAllCustomerBookings);
            this.gbCustomerBookings.Location = new System.Drawing.Point(14, 523);
            this.gbCustomerBookings.Name = "gbCustomerBookings";
            this.gbCustomerBookings.Size = new System.Drawing.Size(1107, 241);
            this.gbCustomerBookings.TabIndex = 6;
            this.gbCustomerBookings.TabStop = false;
            this.gbCustomerBookings.Text = "Customer Bookings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Bookings History:";
            // 
            // dgvAllCustomerBookings
            // 
            this.dgvAllCustomerBookings.AllowUserToAddRows = false;
            this.dgvAllCustomerBookings.AllowUserToDeleteRows = false;
            this.dgvAllCustomerBookings.AllowUserToOrderColumns = true;
            this.dgvAllCustomerBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCustomerBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllCustomerBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCustomerBookings.ContextMenuStrip = this.cmsBooking;
            this.dgvAllCustomerBookings.Location = new System.Drawing.Point(14, 57);
            this.dgvAllCustomerBookings.MultiSelect = false;
            this.dgvAllCustomerBookings.Name = "dgvAllCustomerBookings";
            this.dgvAllCustomerBookings.ReadOnly = true;
            this.dgvAllCustomerBookings.RowHeadersWidth = 62;
            this.dgvAllCustomerBookings.RowTemplate.Height = 28;
            this.dgvAllCustomerBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCustomerBookings.Size = new System.Drawing.Size(1079, 172);
            this.dgvAllCustomerBookings.TabIndex = 21;
            // 
            // cmsBooking
            // 
            this.cmsBooking.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingInfoToolStripMenuItem});
            this.cmsBooking.Name = "cmsBooking";
            this.cmsBooking.Size = new System.Drawing.Size(265, 85);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCloseButton1.Location = new System.Drawing.Point(957, 815);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(160, 52);
            this.ucCloseButton1.TabIndex = 7;
            // 
            // showBookingInfoToolStripMenuItem
            // 
            this.showBookingInfoToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.showDetails;
            this.showBookingInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showBookingInfoToolStripMenuItem.Name = "showBookingInfoToolStripMenuItem";
            this.showBookingInfoToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.showBookingInfoToolStripMenuItem.Text = "Show Booking Info";
            this.showBookingInfoToolStripMenuItem.Click += new System.EventHandler(this.showBookingInfoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalPresentationLayer.Properties.Resources.CustomerBookingHistory;
            this.pictureBox1.Location = new System.Drawing.Point(14, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ucCustomerInfo1
            // 
            this.ucCustomerInfo1.Location = new System.Drawing.Point(296, 156);
            this.ucCustomerInfo1.Name = "ucCustomerInfo1";
            this.ucCustomerInfo1.Size = new System.Drawing.Size(825, 349);
            this.ucCustomerInfo1.TabIndex = 9;
            // 
            // frmCustomerBookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 879);
            this.Controls.Add(this.ucCustomerInfo1);
            this.Controls.Add(this.gbCustomerBookings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucCloseButton1);
            this.Name = "frmCustomerBookingHistory";
            this.Text = "frmCustomerBookingHistory";
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.gbCustomerBookings, 0);
            this.Controls.SetChildIndex(this.ucCustomerInfo1, 0);
            this.gbCustomerBookings.ResumeLayout(false);
            this.gbCustomerBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomerBookings)).EndInit();
            this.cmsBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerBookings;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DataGridView dgvAllCustomerBookings;
        private System.Windows.Forms.ContextMenuStrip cmsBooking;
        private System.Windows.Forms.ToolStripMenuItem showBookingInfoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ucCloseButton ucCloseButton1;
        private UserControls.ucCustomerInfo ucCustomerInfo1;
    }
}