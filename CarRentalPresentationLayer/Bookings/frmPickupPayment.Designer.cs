namespace CarRentalPresentationLayer.RentalBookings
{
    partial class frmPickupPayment
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
            this.btnComfirmPickup = new System.Windows.Forms.Button();
            this.ucBookingInfo1 = new CarRentalPresentationLayer.UserControls.ucBookingInfo();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.lblTransactionOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.gbPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComfirmPickup
            // 
            this.btnComfirmPickup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComfirmPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.btnComfirmPickup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmPickup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirmPickup.ForeColor = System.Drawing.Color.White;
            this.btnComfirmPickup.Location = new System.Drawing.Point(647, 622);
            this.btnComfirmPickup.Name = "btnComfirmPickup";
            this.btnComfirmPickup.Size = new System.Drawing.Size(219, 57);
            this.btnComfirmPickup.TabIndex = 42;
            this.btnComfirmPickup.Text = "Confirm Pickup";
            this.btnComfirmPickup.UseVisualStyleBackColor = false;
            this.btnComfirmPickup.Click += new System.EventHandler(this.btnComfirmPickup_Click);
            // 
            // ucBookingInfo1
            // 
            this.ucBookingInfo1.Location = new System.Drawing.Point(9, 113);
            this.ucBookingInfo1.Name = "ucBookingInfo1";
            this.ucBookingInfo1.Size = new System.Drawing.Size(857, 290);
            this.ucBookingInfo1.TabIndex = 90;
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Controls.Add(this.lblTransactionOn);
            this.gbPaymentInfo.Controls.Add(this.label1);
            this.gbPaymentInfo.Controls.Add(this.cbPaymentMethod);
            this.gbPaymentInfo.Controls.Add(this.label2);
            this.gbPaymentInfo.Controls.Add(this.lblAmountToPay);
            this.gbPaymentInfo.Controls.Add(this.label7);
            this.gbPaymentInfo.Location = new System.Drawing.Point(12, 416);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(853, 190);
            this.gbPaymentInfo.TabIndex = 91;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Information";
            // 
            // lblTransactionOn
            // 
            this.lblTransactionOn.AutoSize = true;
            this.lblTransactionOn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransactionOn.Location = new System.Drawing.Point(224, 144);
            this.lblTransactionOn.Name = "lblTransactionOn";
            this.lblTransactionOn.Size = new System.Drawing.Size(51, 28);
            this.lblTransactionOn.TabIndex = 95;
            this.lblTransactionOn.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Transaction On:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Apple Pay",
            "Google Pay",
            "Bank Transfer"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(229, 31);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(195, 29);
            this.cbPaymentMethod.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 92;
            this.label2.Text = "Payment Method:";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmountToPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(156)))));
            this.lblAmountToPay.Location = new System.Drawing.Point(223, 82);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(65, 32);
            this.lblAmountToPay.TabIndex = 91;
            this.lblAmountToPay.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 28);
            this.label7.TabIndex = 90;
            this.label7.Text = "Amount To Pay:";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(481, 622);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(148, 56);
            this.ucCloseButton1.TabIndex = 93;
            // 
            // frmPickupPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 691);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.gbPaymentInfo);
            this.Controls.Add(this.ucBookingInfo1);
            this.Controls.Add(this.btnComfirmPickup);
            this.Name = "frmPickupPayment";
            this.Text = "Vehicle Pickup Payment";
            this.Load += new System.EventHandler(this.frmBookingPayment_Load);
            this.Controls.SetChildIndex(this.btnComfirmPickup, 0);
            this.Controls.SetChildIndex(this.ucBookingInfo1, 0);
            this.Controls.SetChildIndex(this.gbPaymentInfo, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComfirmPickup;
        private UserControls.ucBookingInfo ucBookingInfo1;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.Label lblTransactionOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Label label7;
        private ucCloseButton ucCloseButton1;
    }
}