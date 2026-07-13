using CarRentalBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer
{
    public partial class frmAddEditCustomer : FormWithTitle
    {
        clsCustomer Customer;

        public frmAddEditCustomer()
        {
            InitializeComponent();

            panel1.BackColor = clsColorsSettings.MainColor;

            Customer = new clsCustomer();
        }

        public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();

            panel1.BackColor = clsColorsSettings.MainColor;

            Customer = clsCustomer.Find(CustomerID);
        }

        void _LoadCustomerData()
        {
            if (Customer.Mode == clsCustomer.enMode.AddNew)
            {
                Title = "Add New Customer";
                lblCustomerID.Text = "N/A";
            }
            else if (Customer.Mode == clsCustomer.enMode.Update)
            {
                Title = "Update Customer";

                lblCustomerID.Text = Customer.ID.ToString();
                txtFirstName.Text = Customer.FirstName;
                txtLastName.Text = Customer.LastName;
                txtEmail.Text = Customer.Email;
                txtPhone.Text = Customer.Phone;
                txtDrivingLicenseNumber.Text = Customer.DriverLicenseNumber;

                if (!string.IsNullOrEmpty(Customer.ImagePath))
                {
                    pbImage.Load(Customer.ImagePath);
                    llRemoveImage.Visible = true;
                }
            }
        }

        bool _AreAllInputsValidated()
        {
            foreach (Control control in this.Controls)
            {
                TextBox txt = control as TextBox;

                if (txt != null)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        void _ShowErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _LoadCustomerData();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Set Image";
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Load(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = Properties.Resources.NullCustomerImage;
            pbImage.ImageLocation = "";
            llRemoveImage.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_AreAllInputsValidated())
            {
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;
                Customer.Email = txtEmail.Text;
                Customer.Phone = txtPhone.Text;
                Customer.DriverLicenseNumber = txtDrivingLicenseNumber.Text;

                if (!string.IsNullOrEmpty(pbImage.ImageLocation))
                    Customer.ImagePath = pbImage.ImageLocation;
                else
                    Customer.ImagePath = "";

                if (Customer.Save())
                {
                    MessageBox.Show("Data Saved Succesfully", "Succes", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Title = "Update Customer";
                    lblCustomerID.Text = Customer.ID.ToString();
                }
                else
                {
                    _ShowErrorMessage("Failed to save data");
                }
            }
            else
            {
                _ShowErrorMessage("Some fields are not validated");
            }
        }

        private void txtInputs_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtInput = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                e.Cancel = true;
                txtInput.Focus();
                errorProvider1.SetError(txtInput, $"{txtInput.Tag.ToString()} should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtInput, "");
            }
        }

    }
}
