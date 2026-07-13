namespace CarRentalPresentationLayer.RentalBookings
{
    partial class frmAddEditRentalBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditRentalBooking));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.btnCustomerNext = new System.Windows.Forms.Button();
            this.ucFilterCustomer1 = new CarRentalPresentationLayer.UserControls.ucFilterCustomer();
            this.tabVehicleInfo = new System.Windows.Forms.TabPage();
            this.btnVehicleBack = new System.Windows.Forms.Button();
            this.ucFilterVehicle1 = new CarRentalPresentationLayer.UserControls.ucFilterVehicle();
            this.btnVehicleNext = new System.Windows.Forms.Button();
            this.tabBookingInfo = new System.Windows.Forms.TabPage();
            this.lblRentalDays = new System.Windows.Forms.Label();
            this.lblTotalDueAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRentalPricePerDay = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckNotes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDropoffLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBookingBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPickupLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.tabControl1.SuspendLayout();
            this.tabCustomerInfo.SuspendLayout();
            this.tabVehicleInfo.SuspendLayout();
            this.tabBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCustomerInfo);
            this.tabControl1.Controls.Add(this.tabVehicleInfo);
            this.tabControl1.Controls.Add(this.tabBookingInfo);
            this.tabControl1.Location = new System.Drawing.Point(9, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 719);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabCustomerInfo.Controls.Add(this.btnCustomerNext);
            this.tabCustomerInfo.Controls.Add(this.ucFilterCustomer1);
            this.tabCustomerInfo.Location = new System.Drawing.Point(4, 30);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerInfo.Size = new System.Drawing.Size(892, 685);
            this.tabCustomerInfo.TabIndex = 2;
            this.tabCustomerInfo.Text = "Customer Info";
            // 
            // btnCustomerNext
            // 
            this.btnCustomerNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerNext.Image = global::CarRentalPresentationLayer.Properties.Resources.next;
            this.btnCustomerNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerNext.Location = new System.Drawing.Point(689, 625);
            this.btnCustomerNext.Name = "btnCustomerNext";
            this.btnCustomerNext.Size = new System.Drawing.Size(145, 51);
            this.btnCustomerNext.TabIndex = 41;
            this.btnCustomerNext.Text = "Next    ";
            this.btnCustomerNext.UseVisualStyleBackColor = true;
            this.btnCustomerNext.Click += new System.EventHandler(this.btnCustomerNext_Click);
            // 
            // ucFilterCustomer1
            // 
            this.ucFilterCustomer1.Location = new System.Drawing.Point(18, 16);
            this.ucFilterCustomer1.Name = "ucFilterCustomer1";
            this.ucFilterCustomer1.Size = new System.Drawing.Size(855, 454);
            this.ucFilterCustomer1.TabIndex = 0;
            // 
            // tabVehicleInfo
            // 
            this.tabVehicleInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabVehicleInfo.Controls.Add(this.btnVehicleBack);
            this.tabVehicleInfo.Controls.Add(this.ucFilterVehicle1);
            this.tabVehicleInfo.Controls.Add(this.btnVehicleNext);
            this.tabVehicleInfo.Location = new System.Drawing.Point(4, 30);
            this.tabVehicleInfo.Name = "tabVehicleInfo";
            this.tabVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleInfo.Size = new System.Drawing.Size(892, 685);
            this.tabVehicleInfo.TabIndex = 0;
            this.tabVehicleInfo.Text = "Vehicle Info";
            // 
            // btnVehicleBack
            // 
            this.btnVehicleBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicleBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVehicleBack.Image = global::CarRentalPresentationLayer.Properties.Resources.back;
            this.btnVehicleBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleBack.Location = new System.Drawing.Point(63, 625);
            this.btnVehicleBack.Name = "btnVehicleBack";
            this.btnVehicleBack.Size = new System.Drawing.Size(145, 51);
            this.btnVehicleBack.TabIndex = 42;
            this.btnVehicleBack.Text = "     Back";
            this.btnVehicleBack.UseVisualStyleBackColor = true;
            this.btnVehicleBack.Click += new System.EventHandler(this.btnVehicleBack_Click);
            // 
            // ucFilterVehicle1
            // 
            this.ucFilterVehicle1.Location = new System.Drawing.Point(51, 14);
            this.ucFilterVehicle1.Name = "ucFilterVehicle1";
            this.ucFilterVehicle1.Size = new System.Drawing.Size(791, 606);
            this.ucFilterVehicle1.TabIndex = 41;
            // 
            // btnVehicleNext
            // 
            this.btnVehicleNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicleNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVehicleNext.Image = global::CarRentalPresentationLayer.Properties.Resources.next;
            this.btnVehicleNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicleNext.Location = new System.Drawing.Point(689, 625);
            this.btnVehicleNext.Name = "btnVehicleNext";
            this.btnVehicleNext.Size = new System.Drawing.Size(145, 51);
            this.btnVehicleNext.TabIndex = 40;
            this.btnVehicleNext.Text = "Next    ";
            this.btnVehicleNext.UseVisualStyleBackColor = true;
            this.btnVehicleNext.Click += new System.EventHandler(this.btnVehicleNext_Click);
            // 
            // tabBookingInfo
            // 
            this.tabBookingInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabBookingInfo.Controls.Add(this.lblRentalDays);
            this.tabBookingInfo.Controls.Add(this.lblTotalDueAmount);
            this.tabBookingInfo.Controls.Add(this.label15);
            this.tabBookingInfo.Controls.Add(this.label14);
            this.tabBookingInfo.Controls.Add(this.panel1);
            this.tabBookingInfo.Controls.Add(this.lblRentalPricePerDay);
            this.tabBookingInfo.Controls.Add(this.label12);
            this.tabBookingInfo.Controls.Add(this.label2);
            this.tabBookingInfo.Controls.Add(this.txtCheckNotes);
            this.tabBookingInfo.Controls.Add(this.label16);
            this.tabBookingInfo.Controls.Add(this.label10);
            this.tabBookingInfo.Controls.Add(this.txtDropoffLocation);
            this.tabBookingInfo.Controls.Add(this.label9);
            this.tabBookingInfo.Controls.Add(this.label8);
            this.tabBookingInfo.Controls.Add(this.label6);
            this.tabBookingInfo.Controls.Add(this.dtpEndDate);
            this.tabBookingInfo.Controls.Add(this.dtpStartDate);
            this.tabBookingInfo.Controls.Add(this.label5);
            this.tabBookingInfo.Controls.Add(this.label4);
            this.tabBookingInfo.Controls.Add(this.btnBookingBack);
            this.tabBookingInfo.Controls.Add(this.label3);
            this.tabBookingInfo.Controls.Add(this.txtPickupLocation);
            this.tabBookingInfo.Controls.Add(this.label1);
            this.tabBookingInfo.Controls.Add(this.lblBookingID);
            this.tabBookingInfo.Controls.Add(this.label7);
            this.tabBookingInfo.Location = new System.Drawing.Point(4, 30);
            this.tabBookingInfo.Name = "tabBookingInfo";
            this.tabBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookingInfo.Size = new System.Drawing.Size(892, 685);
            this.tabBookingInfo.TabIndex = 1;
            this.tabBookingInfo.Text = "Booking Info";
            // 
            // lblRentalDays
            // 
            this.lblRentalDays.AutoSize = true;
            this.lblRentalDays.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDays.Location = new System.Drawing.Point(680, 418);
            this.lblRentalDays.Name = "lblRentalDays";
            this.lblRentalDays.Size = new System.Drawing.Size(53, 28);
            this.lblRentalDays.TabIndex = 124;
            this.lblRentalDays.Text = "[???]";
            // 
            // lblTotalDueAmount
            // 
            this.lblTotalDueAmount.AutoSize = true;
            this.lblTotalDueAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDueAmount.Location = new System.Drawing.Point(680, 551);
            this.lblTotalDueAmount.Name = "lblTotalDueAmount";
            this.lblTotalDueAmount.Size = new System.Drawing.Size(53, 28);
            this.lblTotalDueAmount.TabIndex = 122;
            this.lblTotalDueAmount.Text = "[???]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(648, 551);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 28);
            this.label15.TabIndex = 121;
            this.label15.Text = "=";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(536, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 69);
            this.label14.TabIndex = 120;
            this.label14.Text = "Total Due Amount ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(523, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 10);
            this.panel1.TabIndex = 119;
            // 
            // lblRentalPricePerDay
            // 
            this.lblRentalPricePerDay.AutoSize = true;
            this.lblRentalPricePerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPricePerDay.Location = new System.Drawing.Point(679, 474);
            this.lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            this.lblRentalPricePerDay.Size = new System.Drawing.Size(53, 28);
            this.lblRentalPricePerDay.TabIndex = 117;
            this.lblRentalPricePerDay.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(530, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 28);
            this.label12.TabIndex = 116;
            this.label12.Text = "Price / Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 114;
            this.label2.Text = "Rental Days:";
            // 
            // txtCheckNotes
            // 
            this.txtCheckNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckNotes.Location = new System.Drawing.Point(56, 420);
            this.txtCheckNotes.Multiline = true;
            this.txtCheckNotes.Name = "txtCheckNotes";
            this.txtCheckNotes.Size = new System.Drawing.Size(403, 171);
            this.txtCheckNotes.TabIndex = 112;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(51, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 28);
            this.label16.TabIndex = 111;
            this.label16.Text = "Check Notes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(476, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 28);
            this.label10.TabIndex = 102;
            this.label10.Text = "➔";
            // 
            // txtDropoffLocation
            // 
            this.txtDropoffLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDropoffLocation.Location = new System.Drawing.Point(520, 245);
            this.txtDropoffLocation.Multiline = true;
            this.txtDropoffLocation.Name = "txtDropoffLocation";
            this.txtDropoffLocation.Size = new System.Drawing.Size(246, 103);
            this.txtDropoffLocation.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(603, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 28);
            this.label9.TabIndex = 100;
            this.label9.Text = "Dropoff";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(301, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 99;
            this.label8.Text = "Pickup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(476, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 28);
            this.label6.TabIndex = 98;
            this.label6.Text = "➔";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(520, 150);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(246, 29);
            this.dtpEndDate.TabIndex = 97;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(213, 150);
            this.dtpStartDate.MinDate = new System.DateTime(2026, 7, 6, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(246, 29);
            this.dtpStartDate.TabIndex = 96;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(610, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 95;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(311, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 28);
            this.label4.TabIndex = 94;
            this.label4.Text = "Start";
            // 
            // btnBookingBack
            // 
            this.btnBookingBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookingBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBookingBack.Image = global::CarRentalPresentationLayer.Properties.Resources.back;
            this.btnBookingBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingBack.Location = new System.Drawing.Point(63, 625);
            this.btnBookingBack.Name = "btnBookingBack";
            this.btnBookingBack.Size = new System.Drawing.Size(145, 51);
            this.btnBookingBack.TabIndex = 93;
            this.btnBookingBack.Text = "     Back";
            this.btnBookingBack.UseVisualStyleBackColor = true;
            this.btnBookingBack.Click += new System.EventHandler(this.btnBookingBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 88;
            this.label3.Text = "Booking Dates:";
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPickupLocation.Location = new System.Drawing.Point(213, 245);
            this.txtPickupLocation.Multiline = true;
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.Size = new System.Drawing.Size(246, 103);
            this.txtPickupLocation.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 85;
            this.label1.Text = "Locations:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(208, 67);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(53, 28);
            this.lblBookingID.TabIndex = 84;
            this.lblBookingID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 83;
            this.label7.Text = "Booking ID:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(736, 863);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 51);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(554, 863);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(168, 54);
            this.ucCloseButton1.TabIndex = 40;
            // 
            // frmAddEditRentalBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 926);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditRentalBooking";
            this.Text = "Add / Edit Booking";
            this.Load += new System.EventHandler(this.frmAddEditRentalBooking_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabCustomerInfo.ResumeLayout(false);
            this.tabVehicleInfo.ResumeLayout(false);
            this.tabBookingInfo.ResumeLayout(false);
            this.tabBookingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVehicleInfo;
        private UserControls.ucFilterVehicle ucFilterVehicle1;
        private System.Windows.Forms.Button btnVehicleNext;
        private System.Windows.Forms.TabPage tabBookingInfo;
        private System.Windows.Forms.TextBox txtPickupLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private System.Windows.Forms.Button btnSave;
        private ucCloseButton ucCloseButton1;
        private System.Windows.Forms.Button btnCustomerNext;
        private UserControls.ucFilterCustomer ucFilterCustomer1;
        private System.Windows.Forms.Button btnVehicleBack;
        private System.Windows.Forms.Button btnBookingBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDropoffLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheckNotes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRentalDays;
        private System.Windows.Forms.Label lblTotalDueAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}