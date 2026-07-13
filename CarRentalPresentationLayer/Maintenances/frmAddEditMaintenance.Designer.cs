namespace CarRentalPresentationLayer.Maintenances
{
    partial class frmAddEditMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditMaintenance));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVehicleInfo = new System.Windows.Forms.TabPage();
            this.ucFilterVehicle1 = new CarRentalPresentationLayer.UserControls.ucFilterVehicle();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabMaintenanceInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVehicleInfo.SuspendLayout();
            this.tabMaintenanceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVehicleInfo);
            this.tabControl1.Controls.Add(this.tabMaintenanceInfo);
            this.tabControl1.Location = new System.Drawing.Point(9, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 719);
            this.tabControl1.TabIndex = 1;
            // 
            // tabVehicleInfo
            // 
            this.tabVehicleInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabVehicleInfo.Controls.Add(this.ucFilterVehicle1);
            this.tabVehicleInfo.Controls.Add(this.btnNext);
            this.tabVehicleInfo.Location = new System.Drawing.Point(4, 30);
            this.tabVehicleInfo.Name = "tabVehicleInfo";
            this.tabVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleInfo.Size = new System.Drawing.Size(822, 685);
            this.tabVehicleInfo.TabIndex = 0;
            this.tabVehicleInfo.Text = "Vehicle Info";
            // 
            // ucFilterVehicle1
            // 
            this.ucFilterVehicle1.Location = new System.Drawing.Point(13, 11);
            this.ucFilterVehicle1.Name = "ucFilterVehicle1";
            this.ucFilterVehicle1.Size = new System.Drawing.Size(791, 606);
            this.ucFilterVehicle1.TabIndex = 41;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.Image = global::CarRentalPresentationLayer.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(629, 626);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 51);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = "Next    ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabMaintenanceInfo
            // 
            this.tabMaintenanceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabMaintenanceInfo.Controls.Add(this.btnBack);
            this.tabMaintenanceInfo.Controls.Add(this.pictureBox1);
            this.tabMaintenanceInfo.Controls.Add(this.label11);
            this.tabMaintenanceInfo.Controls.Add(this.nudCost);
            this.tabMaintenanceInfo.Controls.Add(this.lblMaintenanceDate);
            this.tabMaintenanceInfo.Controls.Add(this.label3);
            this.tabMaintenanceInfo.Controls.Add(this.label2);
            this.tabMaintenanceInfo.Controls.Add(this.txtDescription);
            this.tabMaintenanceInfo.Controls.Add(this.label1);
            this.tabMaintenanceInfo.Controls.Add(this.lblMaintenanceID);
            this.tabMaintenanceInfo.Controls.Add(this.label7);
            this.tabMaintenanceInfo.Location = new System.Drawing.Point(4, 30);
            this.tabMaintenanceInfo.Name = "tabMaintenanceInfo";
            this.tabMaintenanceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaintenanceInfo.Size = new System.Drawing.Size(822, 685);
            this.tabMaintenanceInfo.TabIndex = 1;
            this.tabMaintenanceInfo.Text = "Maintenance Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalPresentationLayer.Properties.Resources.coins;
            this.pictureBox1.Location = new System.Drawing.Point(128, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(461, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 28);
            this.label11.TabIndex = 91;
            this.label11.Text = "AED";
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCost.Location = new System.Drawing.Point(269, 481);
            this.nudCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(190, 29);
            this.nudCost.TabIndex = 90;
            this.nudCost.ThousandsSeparator = true;
            this.nudCost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceDate.Location = new System.Drawing.Point(264, 167);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(53, 28);
            this.lblMaintenanceDate.TabIndex = 89;
            this.lblMaintenanceDate.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 88;
            this.label3.Text = "Maintenance Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 87;
            this.label2.Text = "Cost:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(269, 233);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(414, 191);
            this.txtDescription.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 85;
            this.label1.Text = "Description:";
            // 
            // lblMaintenanceID
            // 
            this.lblMaintenanceID.AutoSize = true;
            this.lblMaintenanceID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceID.Location = new System.Drawing.Point(264, 103);
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            this.lblMaintenanceID.Size = new System.Drawing.Size(53, 28);
            this.lblMaintenanceID.TabIndex = 84;
            this.lblMaintenanceID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 28);
            this.label7.TabIndex = 83;
            this.label7.Text = "Maintenance ID:";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(495, 865);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(168, 51);
            this.ucCloseButton1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(671, 865);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 51);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBack.Image = global::CarRentalPresentationLayer.Properties.Resources.back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(69, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 51);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "     Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddEditMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 928);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditMaintenance";
            this.Text = "Add / Edit Maintenance";
            this.Load += new System.EventHandler(this.frmAddEditMaintenance_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabVehicleInfo.ResumeLayout(false);
            this.tabMaintenanceInfo.ResumeLayout(false);
            this.tabMaintenanceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVehicleInfo;
        private System.Windows.Forms.TabPage tabMaintenanceInfo;
        private ucCloseButton ucCloseButton1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private UserControls.ucFilterVehicle ucFilterVehicle1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaintenanceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}