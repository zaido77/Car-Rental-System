namespace CarRentalPresentationLayer.Bookings
{
    partial class frmReturnVehicle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReturnInfo = new System.Windows.Forms.TabPage();
            this.btnCustomerNext = new System.Windows.Forms.Button();
            this.ucBookingInfo1 = new CarRentalPresentationLayer.UserControls.ucBookingInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAdditionalCharges = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCurrentMileage = new System.Windows.Forms.NumericUpDown();
            this.txtFinalCheckNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActualReturnDate = new System.Windows.Forms.Label();
            this.lblConsumedMileage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPaymentSummary = new System.Windows.Forms.TabPage();
            this.gbPaymentSummary = new System.Windows.Forms.GroupBox();
            this.lblActualTotal = new System.Windows.Forms.Label();
            this.lblActualRentalDays = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblInitialPaid = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.btnVehicleBack = new System.Windows.Forms.Button();
            this.btnCompleteReturn = new System.Windows.Forms.Button();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.tabControl1.SuspendLayout();
            this.tabReturnInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).BeginInit();
            this.tabPaymentSummary.SuspendLayout();
            this.gbPaymentSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReturnInfo);
            this.tabControl1.Controls.Add(this.tabPaymentSummary);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 760);
            this.tabControl1.TabIndex = 1;
            // 
            // tabReturnInfo
            // 
            this.tabReturnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabReturnInfo.Controls.Add(this.btnCustomerNext);
            this.tabReturnInfo.Controls.Add(this.ucBookingInfo1);
            this.tabReturnInfo.Controls.Add(this.groupBox1);
            this.tabReturnInfo.Location = new System.Drawing.Point(4, 30);
            this.tabReturnInfo.Name = "tabReturnInfo";
            this.tabReturnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabReturnInfo.Size = new System.Drawing.Size(850, 726);
            this.tabReturnInfo.TabIndex = 0;
            this.tabReturnInfo.Text = "Return Info";
            // 
            // btnCustomerNext
            // 
            this.btnCustomerNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerNext.Image = global::CarRentalPresentationLayer.Properties.Resources.next;
            this.btnCustomerNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerNext.Location = new System.Drawing.Point(696, 668);
            this.btnCustomerNext.Name = "btnCustomerNext";
            this.btnCustomerNext.Size = new System.Drawing.Size(145, 51);
            this.btnCustomerNext.TabIndex = 42;
            this.btnCustomerNext.Text = "Next    ";
            this.btnCustomerNext.UseVisualStyleBackColor = true;
            this.btnCustomerNext.Click += new System.EventHandler(this.btnCustomerNext_Click);
            // 
            // ucBookingInfo1
            // 
            this.ucBookingInfo1.Location = new System.Drawing.Point(6, 8);
            this.ucBookingInfo1.Name = "ucBookingInfo1";
            this.ucBookingInfo1.Size = new System.Drawing.Size(837, 290);
            this.ucBookingInfo1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudAdditionalCharges);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudCurrentMileage);
            this.groupBox1.Controls.Add(this.txtFinalCheckNotes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblActualReturnDate);
            this.groupBox1.Controls.Add(this.lblConsumedMileage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 357);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(757, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 28);
            this.label6.TabIndex = 143;
            this.label6.Text = "AED";
            // 
            // nudAdditionalCharges
            // 
            this.nudAdditionalCharges.DecimalPlaces = 2;
            this.nudAdditionalCharges.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAdditionalCharges.Location = new System.Drawing.Point(652, 119);
            this.nudAdditionalCharges.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAdditionalCharges.Name = "nudAdditionalCharges";
            this.nudAdditionalCharges.Size = new System.Drawing.Size(104, 29);
            this.nudAdditionalCharges.TabIndex = 142;
            this.nudAdditionalCharges.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(606, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 28);
            this.label5.TabIndex = 141;
            this.label5.Text = "KM";
            // 
            // nudCurrentMileage
            // 
            this.nudCurrentMileage.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCurrentMileage.Location = new System.Drawing.Point(458, 65);
            this.nudCurrentMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCurrentMileage.Name = "nudCurrentMileage";
            this.nudCurrentMileage.Size = new System.Drawing.Size(146, 29);
            this.nudCurrentMileage.TabIndex = 140;
            this.nudCurrentMileage.ThousandsSeparator = true;
            this.nudCurrentMileage.ValueChanged += new System.EventHandler(this.nudCurrentMileage_ValueChanged);
            // 
            // txtFinalCheckNotes
            // 
            this.txtFinalCheckNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalCheckNotes.Location = new System.Drawing.Point(28, 204);
            this.txtFinalCheckNotes.Multiline = true;
            this.txtFinalCheckNotes.Name = "txtFinalCheckNotes";
            this.txtFinalCheckNotes.Size = new System.Drawing.Size(796, 135);
            this.txtFinalCheckNotes.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 28);
            this.label4.TabIndex = 138;
            this.label4.Text = "Final Check Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 28);
            this.label3.TabIndex = 137;
            this.label3.Text = "Additional Charges:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 28);
            this.label2.TabIndex = 136;
            this.label2.Text = "Consumed Mileage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 135;
            this.label1.Text = "Current Mileage:";
            // 
            // lblActualReturnDate
            // 
            this.lblActualReturnDate.AutoSize = true;
            this.lblActualReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualReturnDate.Location = new System.Drawing.Point(23, 65);
            this.lblActualReturnDate.Name = "lblActualReturnDate";
            this.lblActualReturnDate.Size = new System.Drawing.Size(60, 28);
            this.lblActualReturnDate.TabIndex = 134;
            this.lblActualReturnDate.Text = "[????]";
            // 
            // lblConsumedMileage
            // 
            this.lblConsumedMileage.AutoSize = true;
            this.lblConsumedMileage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConsumedMileage.Location = new System.Drawing.Point(223, 116);
            this.lblConsumedMileage.Name = "lblConsumedMileage";
            this.lblConsumedMileage.Size = new System.Drawing.Size(60, 28);
            this.lblConsumedMileage.TabIndex = 133;
            this.lblConsumedMileage.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 28);
            this.label7.TabIndex = 132;
            this.label7.Text = "Actual Return Date:";
            // 
            // tabPaymentSummary
            // 
            this.tabPaymentSummary.BackColor = System.Drawing.SystemColors.Control;
            this.tabPaymentSummary.Controls.Add(this.gbPaymentSummary);
            this.tabPaymentSummary.Controls.Add(this.btnVehicleBack);
            this.tabPaymentSummary.Location = new System.Drawing.Point(4, 30);
            this.tabPaymentSummary.Name = "tabPaymentSummary";
            this.tabPaymentSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaymentSummary.Size = new System.Drawing.Size(850, 726);
            this.tabPaymentSummary.TabIndex = 1;
            this.tabPaymentSummary.Text = "Payment Summary";
            // 
            // gbPaymentSummary
            // 
            this.gbPaymentSummary.Controls.Add(this.lblActualTotal);
            this.gbPaymentSummary.Controls.Add(this.lblActualRentalDays);
            this.gbPaymentSummary.Controls.Add(this.label9);
            this.gbPaymentSummary.Controls.Add(this.label17);
            this.gbPaymentSummary.Controls.Add(this.lblInitialPaid);
            this.gbPaymentSummary.Controls.Add(this.lblRefund);
            this.gbPaymentSummary.Controls.Add(this.label11);
            this.gbPaymentSummary.Controls.Add(this.label15);
            this.gbPaymentSummary.Controls.Add(this.label13);
            this.gbPaymentSummary.Controls.Add(this.lblRemaining);
            this.gbPaymentSummary.Location = new System.Drawing.Point(156, 110);
            this.gbPaymentSummary.Name = "gbPaymentSummary";
            this.gbPaymentSummary.Size = new System.Drawing.Size(548, 397);
            this.gbPaymentSummary.TabIndex = 145;
            this.gbPaymentSummary.TabStop = false;
            this.gbPaymentSummary.Text = "Payment Summary";
            // 
            // lblActualTotal
            // 
            this.lblActualTotal.AutoSize = true;
            this.lblActualTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblActualTotal.Location = new System.Drawing.Point(356, 114);
            this.lblActualTotal.Name = "lblActualTotal";
            this.lblActualTotal.Size = new System.Drawing.Size(62, 28);
            this.lblActualTotal.TabIndex = 138;
            this.lblActualTotal.Text = "[????]";
            // 
            // lblActualRentalDays
            // 
            this.lblActualRentalDays.AutoSize = true;
            this.lblActualRentalDays.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualRentalDays.Location = new System.Drawing.Point(356, 304);
            this.lblActualRentalDays.Name = "lblActualRentalDays";
            this.lblActualRentalDays.Size = new System.Drawing.Size(62, 28);
            this.lblActualRentalDays.TabIndex = 144;
            this.lblActualRentalDays.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 28);
            this.label9.TabIndex = 135;
            this.label9.Text = "Initial Paid:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 28);
            this.label17.TabIndex = 143;
            this.label17.Text = "Actual Rental Days:";
            // 
            // lblInitialPaid
            // 
            this.lblInitialPaid.AutoSize = true;
            this.lblInitialPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialPaid.ForeColor = System.Drawing.Color.Green;
            this.lblInitialPaid.Location = new System.Drawing.Point(356, 64);
            this.lblInitialPaid.Name = "lblInitialPaid";
            this.lblInitialPaid.Size = new System.Drawing.Size(62, 28);
            this.lblInitialPaid.TabIndex = 136;
            this.lblInitialPaid.Text = "[????]";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.Gray;
            this.lblRefund.Location = new System.Drawing.Point(356, 214);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(62, 28);
            this.lblRefund.TabIndex = 142;
            this.lblRefund.Text = "[????]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 28);
            this.label11.TabIndex = 137;
            this.label11.Text = "Actual Total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 28);
            this.label15.TabIndex = 141;
            this.label15.Text = "Refund:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 28);
            this.label13.TabIndex = 139;
            this.label13.Text = "Remaining:";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRemaining.Location = new System.Drawing.Point(356, 164);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(62, 28);
            this.lblRemaining.TabIndex = 140;
            this.lblRemaining.Text = "[????]";
            // 
            // btnVehicleBack
            // 
            this.btnVehicleBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicleBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVehicleBack.Image = global::CarRentalPresentationLayer.Properties.Resources.back;
            this.btnVehicleBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleBack.Location = new System.Drawing.Point(12, 668);
            this.btnVehicleBack.Name = "btnVehicleBack";
            this.btnVehicleBack.Size = new System.Drawing.Size(145, 51);
            this.btnVehicleBack.TabIndex = 43;
            this.btnVehicleBack.Text = "     Back";
            this.btnVehicleBack.UseVisualStyleBackColor = true;
            this.btnVehicleBack.Click += new System.EventHandler(this.btnVehicleBack_Click);
            // 
            // btnCompleteReturn
            // 
            this.btnCompleteReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.btnCompleteReturn.Enabled = false;
            this.btnCompleteReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteReturn.ForeColor = System.Drawing.Color.White;
            this.btnCompleteReturn.Location = new System.Drawing.Point(647, 888);
            this.btnCompleteReturn.Name = "btnCompleteReturn";
            this.btnCompleteReturn.Size = new System.Drawing.Size(219, 57);
            this.btnCompleteReturn.TabIndex = 44;
            this.btnCompleteReturn.Text = "Complete Return";
            this.btnCompleteReturn.UseVisualStyleBackColor = false;
            this.btnCompleteReturn.Click += new System.EventHandler(this.btnCompleteReturn_Click);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(465, 888);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(161, 57);
            this.ucCloseButton1.TabIndex = 45;
            // 
            // frmReturnVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 957);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.btnCompleteReturn);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmReturnVehicle";
            this.Text = "Return Vehicle";
            this.Load += new System.EventHandler(this.frmReturnVehicle_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnCompleteReturn, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabReturnInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdditionalCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentMileage)).EndInit();
            this.tabPaymentSummary.ResumeLayout(false);
            this.gbPaymentSummary.ResumeLayout(false);
            this.gbPaymentSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReturnInfo;
        private UserControls.ucBookingInfo ucBookingInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAdditionalCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCurrentMileage;
        private System.Windows.Forms.TextBox txtFinalCheckNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActualReturnDate;
        private System.Windows.Forms.Label lblConsumedMileage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPaymentSummary;
        private System.Windows.Forms.Button btnCustomerNext;
        private System.Windows.Forms.Button btnVehicleBack;
        private System.Windows.Forms.Label lblActualRentalDays;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblActualTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblInitialPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbPaymentSummary;
        private System.Windows.Forms.Button btnCompleteReturn;
        private ucCloseButton ucCloseButton1;
    }
}