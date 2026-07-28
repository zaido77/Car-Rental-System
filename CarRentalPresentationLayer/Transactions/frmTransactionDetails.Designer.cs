namespace CarRentalPresentationLayer.Transactions
{
    partial class frmTransactionDetails
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
            this.ucBookingInfo1 = new CarRentalPresentationLayer.UserControls.ucBookingInfo();
            this.ucTransactionInfo1 = new CarRentalPresentationLayer.Transactions.ucTransactionInfo();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // ucBookingInfo1
            // 
            this.ucBookingInfo1.Location = new System.Drawing.Point(9, 427);
            this.ucBookingInfo1.Name = "ucBookingInfo1";
            this.ucBookingInfo1.Size = new System.Drawing.Size(862, 382);
            this.ucBookingInfo1.TabIndex = 0;
            // 
            // ucTransactionInfo1
            // 
            this.ucTransactionInfo1.Location = new System.Drawing.Point(9, 113);
            this.ucTransactionInfo1.Name = "ucTransactionInfo1";
            this.ucTransactionInfo1.Size = new System.Drawing.Size(862, 308);
            this.ucTransactionInfo1.TabIndex = 1;
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(731, 826);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(144, 47);
            this.ucCloseButton1.TabIndex = 2;
            // 
            // frmTransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 885);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.ucTransactionInfo1);
            this.Controls.Add(this.ucBookingInfo1);
            this.Name = "frmTransactionDetails";
            this.Text = "frmTransactionDetails";
            this.Controls.SetChildIndex(this.ucBookingInfo1, 0);
            this.Controls.SetChildIndex(this.ucTransactionInfo1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucBookingInfo ucBookingInfo1;
        private ucTransactionInfo ucTransactionInfo1;
        private ucCloseButton ucCloseButton1;
    }
}