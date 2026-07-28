namespace CarRentalPresentationLayer.RentalBookings
{
    partial class frmManageRentalBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageRentalBookings));
            this.cmsRecord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pickupVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::CarRentalPresentationLayer.Properties.Resources.BookingsBig;
            this.pbImage.Location = new System.Drawing.Point(588, 12);
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 801);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Location = new System.Drawing.Point(109, 801);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(310, 215);
            this.lblTitle.Size = new System.Drawing.Size(757, 64);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::CarRentalPresentationLayer.Properties.Resources.AddBooking;
            this.btnAddNew.Location = new System.Drawing.Point(1259, 281);
            this.btnAddNew.Size = new System.Drawing.Size(100, 100);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 353);
            // 
            // cbFilters
            // 
            this.cbFilters.Size = new System.Drawing.Size(251, 29);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(371, 352);
            this.txtFilter.Size = new System.Drawing.Size(251, 29);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(1205, 856);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1342, 407);
            // 
            // cmsRecord
            // 
            this.cmsRecord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.cancelBookingToolStripMenuItem,
            this.toolStripSeparator2,
            this.pickupVehicleToolStripMenuItem,
            this.returnVehicleToolStripMenuItem,
            this.toolStripSeparator3,
            this.showDetailsToolStripMenuItem1});
            this.cmsRecord.Name = "contextMenuStrip1";
            this.cmsRecord.Size = new System.Drawing.Size(287, 406);
            this.cmsRecord.Opening += new System.ComponentModel.CancelEventHandler(this.cmsRecord_Opening);
            // 
            // showBookingDetailsToolStripMenuItem
            // 
            this.showBookingDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showBookingDetailsToolStripMenuItem.Image")));
            this.showBookingDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showBookingDetailsToolStripMenuItem.Name = "showBookingDetailsToolStripMenuItem";
            this.showBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.showBookingDetailsToolStripMenuItem.Text = "Show Booking Details";
            this.showBookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showBookingDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.edit;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.delete;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(283, 6);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.cancel_booking;
            this.cancelBookingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(283, 6);
            // 
            // pickupVehicleToolStripMenuItem
            // 
            this.pickupVehicleToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.PickupVehicle;
            this.pickupVehicleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pickupVehicleToolStripMenuItem.Name = "pickupVehicleToolStripMenuItem";
            this.pickupVehicleToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.pickupVehicleToolStripMenuItem.Text = "Pickup Vehicle";
            this.pickupVehicleToolStripMenuItem.Click += new System.EventHandler(this.pickupVehicleToolStripMenuItem_Click);
            // 
            // returnVehicleToolStripMenuItem
            // 
            this.returnVehicleToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.ReturnsIcon;
            this.returnVehicleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnVehicleToolStripMenuItem.Name = "returnVehicleToolStripMenuItem";
            this.returnVehicleToolStripMenuItem.Size = new System.Drawing.Size(286, 54);
            this.returnVehicleToolStripMenuItem.Text = "Return Vehicle";
            this.returnVehicleToolStripMenuItem.Click += new System.EventHandler(this.returnVehicleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(283, 6);
            // 
            // showDetailsToolStripMenuItem1
            // 
            this.showDetailsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.vehicleToolStripMenuItem});
            this.showDetailsToolStripMenuItem1.Image = global::CarRentalPresentationLayer.Properties.Resources.showDetails2;
            this.showDetailsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            this.showDetailsToolStripMenuItem1.Size = new System.Drawing.Size(286, 54);
            this.showDetailsToolStripMenuItem1.Text = "Show Details";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.showCustomer;
            this.customerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(207, 50);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.showVehicle;
            this.vehicleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(207, 50);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // frmManageRentalBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 913);
            this.Name = "frmManageRentalBookings";
            this.Text = "Manage Rental Bookings";
            this.Load += new System.EventHandler(this.frmManageRentalBookings_Load);
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
        private System.Windows.Forms.ToolStripMenuItem showBookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem returnVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickupVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}