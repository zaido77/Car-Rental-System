namespace CarRentalPresentationLayer.Vehicles
{
    partial class frmVehicleDetails
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
            this.ucVehicleInfo1 = new CarRentalPresentationLayer.UserControls.ucVehicleInfo();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // ucVehicleInfo1
            // 
            this.ucVehicleInfo1.Location = new System.Drawing.Point(37, 113);
            this.ucVehicleInfo1.Name = "ucVehicleInfo1";
            this.ucVehicleInfo1.Size = new System.Drawing.Size(793, 496);
            this.ucVehicleInfo1.TabIndex = 1;
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(652, 648);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(178, 51);
            this.ucCloseButton1.TabIndex = 3;
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 711);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.ucVehicleInfo1);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.Controls.SetChildIndex(this.ucVehicleInfo1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucVehicleInfo ucVehicleInfo1;
        private ucCloseButton ucCloseButton1;
    }
}