namespace CarRentalPresentationLayer.VehicleCategories
{
    partial class frmManageVehicleCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageVehicleCategories));
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::CarRentalPresentationLayer.Properties.Resources.Category;
            this.pbImage.Location = new System.Drawing.Point(190, 18);
            this.pbImage.Size = new System.Drawing.Size(155, 147);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 605);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Location = new System.Drawing.Point(109, 605);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(7, 170);
            this.lblTitle.Size = new System.Drawing.Size(521, 64);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(447, 250);
            this.btnAddNew.Size = new System.Drawing.Size(70, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 291);
            // 
            // cbFilters
            // 
            this.cbFilters.Location = new System.Drawing.Point(117, 291);
            this.cbFilters.Size = new System.Drawing.Size(132, 29);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(255, 291);
            this.txtFilter.Size = new System.Drawing.Size(140, 29);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(363, 613);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 326);
            this.panel1.Size = new System.Drawing.Size(500, 276);
            // 
            // frmManageVehicleCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 674);
            this.Name = "frmManageVehicleCategories";
            this.Text = "Manage Vehicle Categories";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}