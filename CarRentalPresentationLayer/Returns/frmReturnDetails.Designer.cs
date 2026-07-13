namespace CarRentalPresentationLayer.Returns
{
    partial class frmReturnDetails
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
            this.ucReturnInfo1 = new CarRentalPresentationLayer.UserControls.ucReturnInfo();
            this.ucTransactionInfo1 = new CarRentalPresentationLayer.Transactions.ucTransactionInfo();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // ucReturnInfo1
            // 
            this.ucReturnInfo1.Location = new System.Drawing.Point(16, 113);
            this.ucReturnInfo1.Name = "ucReturnInfo1";
            this.ucReturnInfo1.Size = new System.Drawing.Size(805, 435);
            this.ucReturnInfo1.TabIndex = 1;
            // 
            // ucTransactionInfo1
            // 
            this.ucTransactionInfo1.Location = new System.Drawing.Point(16, 553);
            this.ucTransactionInfo1.Name = "ucTransactionInfo1";
            this.ucTransactionInfo1.Size = new System.Drawing.Size(805, 309);
            this.ucTransactionInfo1.TabIndex = 2;
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(673, 876);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(148, 46);
            this.ucCloseButton1.TabIndex = 3;
            // 
            // frmReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 938);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.ucTransactionInfo1);
            this.Controls.Add(this.ucReturnInfo1);
            this.Name = "frmReturnDetails";
            this.Text = "frmReturnDetails";
            this.Controls.SetChildIndex(this.ucReturnInfo1, 0);
            this.Controls.SetChildIndex(this.ucTransactionInfo1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucReturnInfo ucReturnInfo1;
        private Transactions.ucTransactionInfo ucTransactionInfo1;
        private ucCloseButton ucCloseButton1;
    }
}