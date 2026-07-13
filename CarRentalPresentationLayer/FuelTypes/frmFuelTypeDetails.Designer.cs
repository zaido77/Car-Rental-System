namespace CarRentalPresentationLayer.FuelTypes
{
    partial class frmFuelTypeDetails
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
            this.lblFuelTypeName = new System.Windows.Forms.Label();
            this.lblFuelTypeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.SuspendLayout();
            // 
            // lblFuelTypeName
            // 
            this.lblFuelTypeName.AutoSize = true;
            this.lblFuelTypeName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelTypeName.Location = new System.Drawing.Point(236, 195);
            this.lblFuelTypeName.Name = "lblFuelTypeName";
            this.lblFuelTypeName.Size = new System.Drawing.Size(62, 28);
            this.lblFuelTypeName.TabIndex = 64;
            this.lblFuelTypeName.Text = "[????]";
            // 
            // lblFuelTypeID
            // 
            this.lblFuelTypeID.AutoSize = true;
            this.lblFuelTypeID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelTypeID.Location = new System.Drawing.Point(236, 145);
            this.lblFuelTypeID.Name = "lblFuelTypeID";
            this.lblFuelTypeID.Size = new System.Drawing.Size(60, 28);
            this.lblFuelTypeID.TabIndex = 63;
            this.lblFuelTypeID.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 28);
            this.label7.TabIndex = 62;
            this.label7.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 61;
            this.label1.Text = "Name:";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(411, 261);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(126, 55);
            this.ucCloseButton1.TabIndex = 65;
            // 
            // frmFuelTypeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 328);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.lblFuelTypeName);
            this.Controls.Add(this.lblFuelTypeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmFuelTypeDetails";
            this.Text = "frmShowFuelTypeDetails";
            this.Load += new System.EventHandler(this.frmFuelTypeDetails_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblFuelTypeID, 0);
            this.Controls.SetChildIndex(this.lblFuelTypeName, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuelTypeName;
        private System.Windows.Forms.Label lblFuelTypeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ucCloseButton ucCloseButton1;
    }
}