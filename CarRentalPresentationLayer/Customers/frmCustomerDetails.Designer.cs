namespace CarRentalPresentationLayer.Customers
{
    partial class frmCustomerDetails
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
            this.ucCustomerInfo1 = new CarRentalPresentationLayer.UserControls.ucCustomerInfo();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // ucCustomerInfo1
            // 
            this.ucCustomerInfo1.Location = new System.Drawing.Point(21, 141);
            this.ucCustomerInfo1.Name = "ucCustomerInfo1";
            this.ucCustomerInfo1.Size = new System.Drawing.Size(827, 313);
            this.ucCustomerInfo1.TabIndex = 1;
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(670, 483);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(178, 51);
            this.ucCloseButton1.TabIndex = 2;
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.ucCustomerInfo1);
            this.Name = "frmCustomerDetails";
            this.Text = "frmCustomerDetails";
            this.Controls.SetChildIndex(this.ucCustomerInfo1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucCustomerInfo ucCustomerInfo1;
        private ucCloseButton ucCloseButton1;
    }
}