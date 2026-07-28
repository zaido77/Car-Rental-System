using CarRentalBusinessLayer;
using CarRentalPresentationLayer;
using CarRentalPresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                clsGlobal.CurrentUser = clsUser.Find(txtUsername.Text, txtPassword.Text);

                if (clsGlobal.CurrentUser != null)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();

                    Form frm = new frmMainMenu();
                    frm.ShowDialog();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Incorrect Username/Password");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowWarning("Please Fill Username and Password Fields", MessageBoxButtons.OK);
            }
        }

    }
}
