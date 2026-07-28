using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentalPresentationLayer.Users
{
    public partial class frmProfile : FormWithTitle
    {
        public frmProfile()
        {
            InitializeComponent();

            Title = "My Profile";
        }

        void _LoadData()
        {
            lblUserID.Text = clsGlobal.CurrentUser.ID.ToString();
            txtUsername.Text = clsGlobal.CurrentUser.Username;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            gbChangePassword.Enabled = chkChangePassword.Checked;

            if (!chkChangePassword.Checked)
            {
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                clsMessageBoxUtil.ShowError("Username cannot be empty.");
                return;
            }

            if (chkChangePassword.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    clsMessageBoxUtil.ShowError("Please fill in all password fields.");
                    return;
                }

                if (!clsGlobal.CurrentUser.IsEqualPassword(txtCurrentPassword.Text))
                {
                    clsMessageBoxUtil.ShowError("Current password is incorrect.");
                    return;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    clsMessageBoxUtil.ShowError("New password and confirmation do not match.");
                    return;
                }

                clsGlobal.CurrentUser.ChangePassword(txtNewPassword.Text);
            }

            clsGlobal.CurrentUser.Username = txtUsername.Text.Trim();

            if (clsGlobal.CurrentUser.Save())
            {
                clsMessageBoxUtil.ShowSuccesMessage("User Data Saved Successfully!");
            }
            else
            {
                clsMessageBoxUtil.ShowError("Something went wrong: Could not save user data");
            }
        }

    }
}