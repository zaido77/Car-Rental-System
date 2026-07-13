namespace CarRentalPresentationLayer.FuelTypes
{
    partial class frmManageFuelTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageFuelTypes));
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::CarRentalPresentationLayer.Properties.Resources.Fuel;
            this.pbImage.Location = new System.Drawing.Point(156, 12);
            this.pbImage.Size = new System.Drawing.Size(119, 115);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 591);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Location = new System.Drawing.Point(109, 591);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(11, 141);
            this.lblTitle.Size = new System.Drawing.Size(408, 57);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(344, 201);
            this.btnAddNew.Size = new System.Drawing.Size(70, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 241);
            // 
            // cbFilters
            // 
            this.cbFilters.Location = new System.Drawing.Point(114, 241);
            this.cbFilters.Size = new System.Drawing.Size(109, 29);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(229, 242);
            this.txtFilter.Size = new System.Drawing.Size(106, 29);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(268, 625);
            this.ucCloseButton1.Size = new System.Drawing.Size(146, 49);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 277);
            this.panel1.Size = new System.Drawing.Size(397, 311);
            // 
            // frmManageFuelTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 682);
            this.Name = "frmManageFuelTypes";
            this.Text = "Manage Fuel Types";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}