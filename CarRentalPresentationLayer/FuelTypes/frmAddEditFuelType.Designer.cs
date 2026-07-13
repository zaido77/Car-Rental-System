namespace CarRentalPresentationLayer.FuelTypes
{
    partial class frmAddEditFuelType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditFuelType));
            this.lblFuelTypeID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFuelTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuelTypeID
            // 
            this.lblFuelTypeID.AutoSize = true;
            this.lblFuelTypeID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelTypeID.Location = new System.Drawing.Point(179, 110);
            this.lblFuelTypeID.Name = "lblFuelTypeID";
            this.lblFuelTypeID.Size = new System.Drawing.Size(51, 28);
            this.lblFuelTypeID.TabIndex = 45;
            this.lblFuelTypeID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fuel Type ID:";
            // 
            // txtFuelTypeName
            // 
            this.txtFuelTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuelTypeName.Location = new System.Drawing.Point(205, 170);
            this.txtFuelTypeName.Name = "txtFuelTypeName";
            this.txtFuelTypeName.Size = new System.Drawing.Size(237, 29);
            this.txtFuelTypeName.TabIndex = 43;
            this.txtFuelTypeName.Tag = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Fuel Type Name:";
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(122, 237);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(150, 41);
            this.ucCloseButton1.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(290, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 41);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditFuelType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 294);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.lblFuelTypeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFuelTypeName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditFuelType";
            this.Text = "Add / Edit Fuel Type";
            this.Load += new System.EventHandler(this.frmAddEditFuelType_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtFuelTypeName, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.lblFuelTypeID, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuelTypeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFuelTypeName;
        private System.Windows.Forms.Label label1;
        private ucCloseButton ucCloseButton1;
        private System.Windows.Forms.Button btnSave;
    }
}