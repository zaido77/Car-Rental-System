namespace CarRentalPresentationLayer.Vehicles
{
    partial class frmVehicleBookingHistory
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
            this.ucVehicleInfo1 = new CarRentalPresentationLayer.UserControls.ucVehicleInfo();
            this.gbVehicleBookings = new System.Windows.Forms.GroupBox();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAllVehicleBookings = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsBooking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showBookingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbVehicleBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicleBookings)).BeginInit();
            this.cmsBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucVehicleInfo1
            // 
            this.ucVehicleInfo1.Location = new System.Drawing.Point(325, 127);
            this.ucVehicleInfo1.Name = "ucVehicleInfo1";
            this.ucVehicleInfo1.Size = new System.Drawing.Size(771, 495);
            this.ucVehicleInfo1.TabIndex = 1;
            // 
            // gbVehicleBookings
            // 
            this.gbVehicleBookings.Controls.Add(this.label3);
            this.gbVehicleBookings.Controls.Add(this.dgvAllVehicleBookings);
            this.gbVehicleBookings.Location = new System.Drawing.Point(21, 628);
            this.gbVehicleBookings.Name = "gbVehicleBookings";
            this.gbVehicleBookings.Size = new System.Drawing.Size(1075, 241);
            this.gbVehicleBookings.TabIndex = 2;
            this.gbVehicleBookings.TabStop = false;
            this.gbVehicleBookings.Text = "Vehicle Bookings";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCloseButton1.Location = new System.Drawing.Point(936, 875);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(160, 50);
            this.ucCloseButton1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalPresentationLayer.Properties.Resources.VehicleBookingHistory;
            this.pictureBox1.Location = new System.Drawing.Point(35, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAllVehicleBookings
            // 
            this.dgvAllVehicleBookings.AllowUserToAddRows = false;
            this.dgvAllVehicleBookings.AllowUserToDeleteRows = false;
            this.dgvAllVehicleBookings.AllowUserToOrderColumns = true;
            this.dgvAllVehicleBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllVehicleBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllVehicleBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllVehicleBookings.ContextMenuStrip = this.cmsBooking;
            this.dgvAllVehicleBookings.Location = new System.Drawing.Point(14, 57);
            this.dgvAllVehicleBookings.MultiSelect = false;
            this.dgvAllVehicleBookings.Name = "dgvAllVehicleBookings";
            this.dgvAllVehicleBookings.ReadOnly = true;
            this.dgvAllVehicleBookings.RowHeadersWidth = 62;
            this.dgvAllVehicleBookings.RowTemplate.Height = 28;
            this.dgvAllVehicleBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllVehicleBookings.Size = new System.Drawing.Size(1048, 172);
            this.dgvAllVehicleBookings.TabIndex = 21;
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
            // cmsBooking
            // 
            this.cmsBooking.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingInfoToolStripMenuItem});
            this.cmsBooking.Name = "cmsBooking";
            this.cmsBooking.Size = new System.Drawing.Size(261, 52);
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
            // frmShowVehicleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 937);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.gbVehicleBookings);
            this.Controls.Add(this.ucVehicleInfo1);
            this.Name = "frmShowVehicleHistory";
            this.Text = "frmShowVehicleHistory";
            this.Controls.SetChildIndex(this.ucVehicleInfo1, 0);
            this.Controls.SetChildIndex(this.gbVehicleBookings, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.gbVehicleBookings.ResumeLayout(false);
            this.gbVehicleBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllVehicleBookings)).EndInit();
            this.cmsBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucVehicleInfo ucVehicleInfo1;
        private System.Windows.Forms.GroupBox gbVehicleBookings;
        private ucCloseButton ucCloseButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.DataGridView dgvAllVehicleBookings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsBooking;
        private System.Windows.Forms.ToolStripMenuItem showBookingInfoToolStripMenuItem;
    }
}