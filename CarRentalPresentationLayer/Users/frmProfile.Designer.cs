namespace CarRentalPresentationLayer.Users
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.ucCloseButton1 = new CarRentalPresentationLayer.ucCloseButton();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAccountDetails = new System.Windows.Forms.GroupBox();
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkChangePassword = new System.Windows.Forms.CheckBox();
            this.gbAccountDetails.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Location = new System.Drawing.Point(313, 558);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(128, 48);
            this.ucCloseButton1.TabIndex = 50;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(167, 38);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 28);
            this.lblUserID.TabIndex = 49;
            this.lblUserID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 48;
            this.label7.Text = "User ID:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(456, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 48);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(172, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 29);
            this.txtUsername.TabIndex = 45;
            this.txtUsername.Tag = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Username:";
            // 
            // gbAccountDetails
            // 
            this.gbAccountDetails.Controls.Add(this.label7);
            this.gbAccountDetails.Controls.Add(this.lblUserID);
            this.gbAccountDetails.Controls.Add(this.label1);
            this.gbAccountDetails.Controls.Add(this.txtUsername);
            this.gbAccountDetails.Location = new System.Drawing.Point(12, 112);
            this.gbAccountDetails.Name = "gbAccountDetails";
            this.gbAccountDetails.Size = new System.Drawing.Size(572, 159);
            this.gbAccountDetails.TabIndex = 51;
            this.gbAccountDetails.TabStop = false;
            this.gbAccountDetails.Text = "Account Details";
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.txtConfirmPassword);
            this.gbChangePassword.Controls.Add(this.txtNewPassword);
            this.gbChangePassword.Controls.Add(this.label3);
            this.gbChangePassword.Controls.Add(this.label2);
            this.gbChangePassword.Controls.Add(this.label4);
            this.gbChangePassword.Controls.Add(this.txtCurrentPassword);
            this.gbChangePassword.Enabled = false;
            this.gbChangePassword.Location = new System.Drawing.Point(12, 335);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(572, 185);
            this.gbChangePassword.TabIndex = 52;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Current Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "New Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Location = new System.Drawing.Point(234, 47);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size = new System.Drawing.Size(237, 29);
            this.txtCurrentPassword.TabIndex = 45;
            this.txtCurrentPassword.Tag = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 49;
            this.label3.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Location = new System.Drawing.Point(234, 92);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(237, 29);
            this.txtNewPassword.TabIndex = 50;
            this.txtNewPassword.Tag = "First Name";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Location = new System.Drawing.Point(234, 139);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(237, 29);
            this.txtConfirmPassword.TabIndex = 51;
            this.txtConfirmPassword.Tag = "First Name";
            // 
            // chkChangePassword
            // 
            this.chkChangePassword.AutoSize = true;
            this.chkChangePassword.Location = new System.Drawing.Point(12, 304);
            this.chkChangePassword.Name = "chkChangePassword";
            this.chkChangePassword.Size = new System.Drawing.Size(166, 25);
            this.chkChangePassword.TabIndex = 53;
            this.chkChangePassword.Text = "Change Password?";
            this.chkChangePassword.UseVisualStyleBackColor = true;
            this.chkChangePassword.CheckedChanged += new System.EventHandler(this.chkChangePassword_CheckedChanged);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 618);
            this.Controls.Add(this.chkChangePassword);
            this.Controls.Add(this.gbChangePassword);
            this.Controls.Add(this.gbAccountDetails);
            this.Controls.Add(this.ucCloseButton1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.ucCloseButton1, 0);
            this.Controls.SetChildIndex(this.gbAccountDetails, 0);
            this.Controls.SetChildIndex(this.gbChangePassword, 0);
            this.Controls.SetChildIndex(this.chkChangePassword, 0);
            this.gbAccountDetails.ResumeLayout(false);
            this.gbAccountDetails.PerformLayout();
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucCloseButton ucCloseButton1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAccountDetails;
        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkChangePassword;
    }
}