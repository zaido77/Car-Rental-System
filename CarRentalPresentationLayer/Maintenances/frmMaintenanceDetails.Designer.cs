namespace CarRentalPresentationLayer.Maintenances
{
    partial class frmMaintenanceDetails
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMaintenanceInfo = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMaintenanceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucVehicleInfo1
            // 
            this.ucVehicleInfo1.Location = new System.Drawing.Point(12, 265);
            this.ucVehicleInfo1.Name = "ucVehicleInfo1";
            this.ucVehicleInfo1.Size = new System.Drawing.Size(764, 492);
            this.ucVehicleInfo1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalPresentationLayer.Properties.Resources.coins;
            this.pictureBox1.Location = new System.Drawing.Point(190, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 96;
            this.label3.Text = "Maintenance Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 95;
            this.label2.Text = "Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 28);
            this.label7.TabIndex = 93;
            this.label7.Text = "Maintenance ID:";
            // 
            // gbMaintenanceInfo
            // 
            this.gbMaintenanceInfo.Controls.Add(this.lblDescription);
            this.gbMaintenanceInfo.Controls.Add(this.lblCost);
            this.gbMaintenanceInfo.Controls.Add(this.lblMaintenanceDate);
            this.gbMaintenanceInfo.Controls.Add(this.label3);
            this.gbMaintenanceInfo.Controls.Add(this.lblMaintenanceID);
            this.gbMaintenanceInfo.Controls.Add(this.pictureBox1);
            this.gbMaintenanceInfo.Controls.Add(this.label7);
            this.gbMaintenanceInfo.Controls.Add(this.label1);
            this.gbMaintenanceInfo.Controls.Add(this.label2);
            this.gbMaintenanceInfo.Location = new System.Drawing.Point(12, 13);
            this.gbMaintenanceInfo.Name = "gbMaintenanceInfo";
            this.gbMaintenanceInfo.Size = new System.Drawing.Size(764, 246);
            this.gbMaintenanceInfo.TabIndex = 98;
            this.gbMaintenanceInfo.TabStop = false;
            this.gbMaintenanceInfo.Text = "Maintenance Infomation";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(424, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(334, 139);
            this.lblDescription.TabIndex = 102;
            this.lblDescription.Text = "[????]";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(225, 189);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(60, 28);
            this.lblCost.TabIndex = 101;
            this.lblCost.Text = "[????]";
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDate.Location = new System.Drawing.Point(225, 120);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(60, 28);
            this.lblMaintenanceDate.TabIndex = 100;
            this.lblMaintenanceDate.Text = "[????]";
            // 
            // lblMaintenanceID
            // 
            this.lblMaintenanceID.AutoSize = true;
            this.lblMaintenanceID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceID.Location = new System.Drawing.Point(223, 50);
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            this.lblMaintenanceID.Size = new System.Drawing.Size(62, 28);
            this.lblMaintenanceID.TabIndex = 99;
            this.lblMaintenanceID.Text = "[????]";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(645, 763);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(131, 51);
            this.ucCloseButton1.TabIndex = 99;
            // 
            // frmMaintenanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 826);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.gbMaintenanceInfo);
            this.Controls.Add(this.ucVehicleInfo1);
            this.Name = "frmMaintenanceDetails";
            this.Text = "Maintenance Info";
            this.Load += new System.EventHandler(this.frmMaintenanceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMaintenanceInfo.ResumeLayout(false);
            this.gbMaintenanceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucVehicleInfo ucVehicleInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMaintenanceInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.Label lblMaintenanceID;
        private ucCloseButton ucCloseButton1;
    }
}