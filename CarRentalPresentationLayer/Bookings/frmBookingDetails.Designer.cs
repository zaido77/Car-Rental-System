namespace CarRentalPresentationLayer.RentalBookings
{
    partial class frmBookingDetails
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
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // ucBookingInfo1
            // 
            this.ucBookingInfo1.Location = new System.Drawing.Point(29, 113);
            this.ucBookingInfo1.Name = "ucBookingInfo1";
            this.ucBookingInfo1.Size = new System.Drawing.Size(859, 393);
            this.ucBookingInfo1.TabIndex = 1;
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(739, 531);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(157, 54);
            this.ucCloseButton1.TabIndex = 2;
            // 
            // frmBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 597);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.ucBookingInfo1);
            this.Name = "frmBookingDetails";
            this.Text = "frmBookingDetails";
            this.Controls.SetChildIndex(this.ucBookingInfo1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucBookingInfo ucBookingInfo1;
        private ucCloseButton ucCloseButton1;
    }
}