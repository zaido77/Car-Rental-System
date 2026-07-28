namespace CarRentalPresentationLayer
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vehicleCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlTotalVehicle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAvailableVehicles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActiveBookings = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCurrentRentals = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTodaysReturns = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPendingReturns = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueGrowth = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNoPendingReturns = new System.Windows.Forms.Label();
            this.dgvPendingReturns = new System.Windows.Forms.DataGridView();
            this.cmsDashboardDGVs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goToBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNoRecentBookings = new System.Windows.Forms.Label();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTotalVehicle.SuspendLayout();
            this.pnlActiveBookings.SuspendLayout();
            this.pnlTodaysReturns.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReturns)).BeginInit();
            this.cmsDashboardDGVs.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalsToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.maintenancesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 56);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1898, 64);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem,
            this.returnsToolStripMenuItem,
            this.toolStripSeparator1,
            this.transactionsToolStripMenuItem});
            this.rentalsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.RentalIcon;
            this.rentalsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(173, 64);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.BookingsIcon;
            this.bookingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(282, 56);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem
            // 
            this.returnsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.ReturnsIcon;
            this.returnsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnsToolStripMenuItem.Name = "returnsToolStripMenuItem";
            this.returnsToolStripMenuItem.Size = new System.Drawing.Size(282, 56);
            this.returnsToolStripMenuItem.Text = "Returns";
            this.returnsToolStripMenuItem.Click += new System.EventHandler(this.returnsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.TransactionsIcon;
            this.transactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(282, 56);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehiclesToolStripMenuItem,
            this.toolStripSeparator2,
            this.vehicleCategoriesToolStripMenuItem,
            this.fuelTypesToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.VehiclesIcon;
            this.vehiclesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(181, 64);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.ManageVehiclesIcon;
            this.manageVehiclesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(347, 56);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.manageVehiclesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(344, 6);
            // 
            // vehicleCategoriesToolStripMenuItem
            // 
            this.vehicleCategoriesToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.CategoriesIcon;
            this.vehicleCategoriesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vehicleCategoriesToolStripMenuItem.Name = "vehicleCategoriesToolStripMenuItem";
            this.vehicleCategoriesToolStripMenuItem.Size = new System.Drawing.Size(347, 56);
            this.vehicleCategoriesToolStripMenuItem.Text = "Vehicle Categories";
            this.vehicleCategoriesToolStripMenuItem.Click += new System.EventHandler(this.vehicleCategoriesToolStripMenuItem_Click);
            // 
            // fuelTypesToolStripMenuItem
            // 
            this.fuelTypesToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.FuelTypesIcon;
            this.fuelTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fuelTypesToolStripMenuItem.Name = "fuelTypesToolStripMenuItem";
            this.fuelTypesToolStripMenuItem.Size = new System.Drawing.Size(347, 56);
            this.fuelTypesToolStripMenuItem.Text = "Fuel Types";
            this.fuelTypesToolStripMenuItem.Click += new System.EventHandler(this.fuelTypesToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.CustomersIcon;
            this.customersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(211, 64);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // maintenancesToolStripMenuItem
            // 
            this.maintenancesToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.MaintenaceIcon;
            this.maintenancesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.maintenancesToolStripMenuItem.Name = "maintenancesToolStripMenuItem";
            this.maintenancesToolStripMenuItem.Size = new System.Drawing.Size(249, 64);
            this.maintenancesToolStripMenuItem.Text = "Maintenances";
            this.maintenancesToolStripMenuItem.Click += new System.EventHandler(this.maintenancesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.toolStripSeparator3,
            this.signOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.gear;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(169, 64);
            this.settingsToolStripMenuItem.Text = " Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.profile;
            this.profileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(238, 56);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.signout;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(238, 56);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblWelcomeUser);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1898, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(883, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 38);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "10:00 PM";
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(1433, 7);
            this.lblWelcomeUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(407, 42);
            this.lblWelcomeUser.TabIndex = 3;
            this.lblWelcomeUser.Text = "Welcome, User";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalPresentationLayer.Properties.Resources.CarRentalLogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Rental Management System";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.Location = new System.Drawing.Point(828, 177);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(243, 60);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pnlTotalVehicle
            // 
            this.pnlTotalVehicle.BackColor = System.Drawing.Color.White;
            this.pnlTotalVehicle.Controls.Add(this.panel1);
            this.pnlTotalVehicle.Controls.Add(this.lblAvailableVehicles);
            this.pnlTotalVehicle.Controls.Add(this.label1);
            this.pnlTotalVehicle.Location = new System.Drawing.Point(30, 270);
            this.pnlTotalVehicle.Name = "pnlTotalVehicle";
            this.pnlTotalVehicle.Size = new System.Drawing.Size(445, 200);
            this.pnlTotalVehicle.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 30);
            this.panel1.TabIndex = 11;
            // 
            // lblAvailableVehicles
            // 
            this.lblAvailableVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblAvailableVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.lblAvailableVehicles.Location = new System.Drawing.Point(0, 57);
            this.lblAvailableVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.lblAvailableVehicles.Name = "lblAvailableVehicles";
            this.lblAvailableVehicles.Size = new System.Drawing.Size(445, 70);
            this.lblAvailableVehicles.TabIndex = 10;
            this.lblAvailableVehicles.Text = "10 / 24";
            this.lblAvailableVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 70);
            this.label1.TabIndex = 9;
            this.label1.Text = "🚗 Available Vehicles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActiveBookings
            // 
            this.pnlActiveBookings.BackColor = System.Drawing.Color.White;
            this.pnlActiveBookings.Controls.Add(this.panel4);
            this.pnlActiveBookings.Controls.Add(this.lblCurrentRentals);
            this.pnlActiveBookings.Controls.Add(this.label3);
            this.pnlActiveBookings.Location = new System.Drawing.Point(500, 270);
            this.pnlActiveBookings.Name = "pnlActiveBookings";
            this.pnlActiveBookings.Size = new System.Drawing.Size(445, 200);
            this.pnlActiveBookings.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 30);
            this.panel4.TabIndex = 13;
            // 
            // lblCurrentRentals
            // 
            this.lblCurrentRentals.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblCurrentRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.lblCurrentRentals.Location = new System.Drawing.Point(0, 57);
            this.lblCurrentRentals.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentRentals.Name = "lblCurrentRentals";
            this.lblCurrentRentals.Size = new System.Drawing.Size(445, 70);
            this.lblCurrentRentals.TabIndex = 12;
            this.lblCurrentRentals.Text = "8";
            this.lblCurrentRentals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 70);
            this.label3.TabIndex = 11;
            this.label3.Text = "📅 Current Rentals";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTodaysReturns
            // 
            this.pnlTodaysReturns.BackColor = System.Drawing.Color.White;
            this.pnlTodaysReturns.Controls.Add(this.panel5);
            this.pnlTodaysReturns.Controls.Add(this.lblPendingReturns);
            this.pnlTodaysReturns.Controls.Add(this.label4);
            this.pnlTodaysReturns.Location = new System.Drawing.Point(970, 270);
            this.pnlTodaysReturns.Name = "pnlTodaysReturns";
            this.pnlTodaysReturns.Size = new System.Drawing.Size(445, 200);
            this.pnlTodaysReturns.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 30);
            this.panel5.TabIndex = 15;
            // 
            // lblPendingReturns
            // 
            this.lblPendingReturns.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblPendingReturns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.lblPendingReturns.Location = new System.Drawing.Point(0, 57);
            this.lblPendingReturns.Margin = new System.Windows.Forms.Padding(0);
            this.lblPendingReturns.Name = "lblPendingReturns";
            this.lblPendingReturns.Size = new System.Drawing.Size(445, 70);
            this.lblPendingReturns.TabIndex = 14;
            this.lblPendingReturns.Text = "8";
            this.lblPendingReturns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 70);
            this.label4.TabIndex = 13;
            this.label4.Text = "↩ Pending Returns";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueGrowth);
            this.pnlRevenue.Controls.Add(this.panel6);
            this.pnlRevenue.Controls.Add(this.lblRevenue);
            this.pnlRevenue.Controls.Add(this.label5);
            this.pnlRevenue.Location = new System.Drawing.Point(1440, 270);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(445, 200);
            this.pnlRevenue.TabIndex = 8;
            // 
            // lblRevenueGrowth
            // 
            this.lblRevenueGrowth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueGrowth.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRevenueGrowth.Location = new System.Drawing.Point(3, 130);
            this.lblRevenueGrowth.Name = "lblRevenueGrowth";
            this.lblRevenueGrowth.Size = new System.Drawing.Size(439, 30);
            this.lblRevenueGrowth.TabIndex = 18;
            this.lblRevenueGrowth.Text = "▼ -18% (-374.4 AED)";
            this.lblRevenueGrowth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(445, 30);
            this.panel6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "vs Last Month";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.lblRevenue.Location = new System.Drawing.Point(0, 57);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(445, 70);
            this.lblRevenue.TabIndex = 16;
            this.lblRevenue.Text = "12,000 AED";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 70);
            this.label5.TabIndex = 15;
            this.label5.Text = "💰 Month Revenue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 120);
            this.pnlSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1898, 10);
            this.pnlSeparator.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNoPendingReturns);
            this.panel2.Controls.Add(this.dgvPendingReturns);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(30, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 425);
            this.panel2.TabIndex = 12;
            // 
            // lblNoPendingReturns
            // 
            this.lblNoPendingReturns.AutoSize = true;
            this.lblNoPendingReturns.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoPendingReturns.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPendingReturns.ForeColor = System.Drawing.Color.Gray;
            this.lblNoPendingReturns.Location = new System.Drawing.Point(275, 231);
            this.lblNoPendingReturns.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoPendingReturns.Name = "lblNoPendingReturns";
            this.lblNoPendingReturns.Size = new System.Drawing.Size(365, 54);
            this.lblNoPendingReturns.TabIndex = 14;
            this.lblNoPendingReturns.Text = "No Pending Returns";
            this.lblNoPendingReturns.Visible = false;
            // 
            // dgvPendingReturns
            // 
            this.dgvPendingReturns.AllowUserToAddRows = false;
            this.dgvPendingReturns.AllowUserToDeleteRows = false;
            this.dgvPendingReturns.AllowUserToOrderColumns = true;
            this.dgvPendingReturns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingReturns.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPendingReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingReturns.ContextMenuStrip = this.cmsDashboardDGVs;
            this.dgvPendingReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingReturns.Location = new System.Drawing.Point(0, 97);
            this.dgvPendingReturns.MultiSelect = false;
            this.dgvPendingReturns.Name = "dgvPendingReturns";
            this.dgvPendingReturns.ReadOnly = true;
            this.dgvPendingReturns.RowHeadersWidth = 62;
            this.dgvPendingReturns.RowTemplate.Height = 28;
            this.dgvPendingReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingReturns.Size = new System.Drawing.Size(915, 328);
            this.dgvPendingReturns.TabIndex = 21;
            // 
            // cmsDashboardDGVs
            // 
            this.cmsDashboardDGVs.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDashboardDGVs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToBookingsToolStripMenuItem});
            this.cmsDashboardDGVs.Name = "cmsDashboardDGVs";
            this.cmsDashboardDGVs.Size = new System.Drawing.Size(270, 91);
            // 
            // goToBookingsToolStripMenuItem
            // 
            this.goToBookingsToolStripMenuItem.Image = global::CarRentalPresentationLayer.Properties.Resources.BookingsIcon;
            this.goToBookingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.goToBookingsToolStripMenuItem.Name = "goToBookingsToolStripMenuItem";
            this.goToBookingsToolStripMenuItem.Size = new System.Drawing.Size(269, 54);
            this.goToBookingsToolStripMenuItem.Text = "Go To Bookings";
            this.goToBookingsToolStripMenuItem.Click += new System.EventHandler(this.goToBookingsToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(915, 97);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pending Returns";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(915, 97);
            this.label7.TabIndex = 9;
            this.label7.Text = "Recent Bookings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNoRecentBookings);
            this.panel3.Controls.Add(this.dgvRecentBookings);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(970, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 425);
            this.panel3.TabIndex = 13;
            // 
            // lblNoRecentBookings
            // 
            this.lblNoRecentBookings.AutoSize = true;
            this.lblNoRecentBookings.BackColor = System.Drawing.SystemColors.Control;
            this.lblNoRecentBookings.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecentBookings.ForeColor = System.Drawing.Color.Gray;
            this.lblNoRecentBookings.Location = new System.Drawing.Point(275, 234);
            this.lblNoRecentBookings.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoRecentBookings.Name = "lblNoRecentBookings";
            this.lblNoRecentBookings.Size = new System.Drawing.Size(364, 54);
            this.lblNoRecentBookings.TabIndex = 23;
            this.lblNoRecentBookings.Text = "No Recent Bookings";
            this.lblNoRecentBookings.Visible = false;
            // 
            // dgvRecentBookings
            // 
            this.dgvRecentBookings.AllowUserToAddRows = false;
            this.dgvRecentBookings.AllowUserToDeleteRows = false;
            this.dgvRecentBookings.AllowUserToOrderColumns = true;
            this.dgvRecentBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRecentBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentBookings.ContextMenuStrip = this.cmsDashboardDGVs;
            this.dgvRecentBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentBookings.Location = new System.Drawing.Point(0, 97);
            this.dgvRecentBookings.MultiSelect = false;
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersWidth = 62;
            this.dgvRecentBookings.RowTemplate.Height = 28;
            this.dgvRecentBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentBookings.Size = new System.Drawing.Size(915, 328);
            this.dgvRecentBookings.TabIndex = 22;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlRevenue);
            this.Controls.Add(this.pnlTodaysReturns);
            this.Controls.Add(this.pnlActiveBookings);
            this.Controls.Add(this.pnlTotalVehicle);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmMainMenu";
            this.Text = "Car Rental Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTotalVehicle.ResumeLayout(false);
            this.pnlActiveBookings.ResumeLayout(false);
            this.pnlTodaysReturns.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReturns)).EndInit();
            this.cmsDashboardDGVs.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vehicleCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelTypesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlTotalVehicle;
        private System.Windows.Forms.Panel pnlActiveBookings;
        private System.Windows.Forms.Panel pnlTodaysReturns;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailableVehicles;
        private System.Windows.Forms.Label lblCurrentRentals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPendingReturns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNoPendingReturns;
        private System.Windows.Forms.Label lblNoRecentBookings;
        private System.Windows.Forms.Label lblRevenueGrowth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPendingReturns;
        private System.Windows.Forms.DataGridView dgvRecentBookings;
        private System.Windows.Forms.ContextMenuStrip cmsDashboardDGVs;
        private System.Windows.Forms.ToolStripMenuItem goToBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}