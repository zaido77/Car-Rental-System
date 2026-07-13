using CarRentalBusinessLayer;
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

namespace CarRentalPresentationLayer.UserControls
{
    public partial class ucCustomerInfo : UserControl
    {
        clsCustomer CustomerInfo;
        public enum enFillBy : byte { Email, Phone }

        public int CustomerID
        {
            get
            {
                return CustomerInfo.ID;
            }
        }

        public ucCustomerInfo()
        {
            InitializeComponent();

            lblName.ForeColor = clsColorsSettings.MainColor;
        }

        void _LoadData()
        {
            lblCustomerID.Text = CustomerInfo.ID.ToString();
            lblName.Text = CustomerInfo.FullName;
            lblEmail.Text = CustomerInfo.Email;
            lblPhone.Text = CustomerInfo.Phone;
            lblDrivingLicenseNumber.Text = CustomerInfo.DriverLicenseNumber;

            if (!string.IsNullOrWhiteSpace(CustomerInfo.ImagePath))
                pbImage.Load(CustomerInfo.ImagePath);
            else
                pbImage.Image = Properties.Resources.NullCustomerImage;

            llEditCustomerInfo.Enabled = true;
        }

        void _ClearData()
        {
            lblCustomerID.Text = "[????]";
            lblName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDrivingLicenseNumber.Text = "[????]";

            pbImage.Image = Properties.Resources.NullCustomerImage;
            pbImage.ImageLocation = "";
            
            llEditCustomerInfo.Enabled = false;
        }

        void _ShowNotFoundMessage()
        {
            clsMessageBoxUtil.ShowError("Not Found!");
        }

        public bool FillDetails(int CustomerID)
        {
            CustomerInfo = clsCustomer.Find(CustomerID);

            if (CustomerInfo == null)
            {
                _ClearData(); 
                _ShowNotFoundMessage();
                return false;
            }

            _LoadData();

            return true;
        }

        public bool FillDetails(string Value, enFillBy FillBy)
        {
            switch (FillBy)
            {
                case enFillBy.Email:
                    CustomerInfo = clsCustomer.Find(Value);
                    break;
                
                case enFillBy.Phone:
                    CustomerInfo = clsCustomer.FindByPhone(Value);
                    break;                
            }

            if (CustomerInfo == null)
            {
                _ClearData();
                _ShowNotFoundMessage();
                return false;
            }

            _LoadData();

            return true;
        }

        private void llEditCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditCustomer(CustomerInfo.ID);
            frm.ShowDialog();
        }

        private void ucCustomerInfo_Load(object sender, EventArgs e)
        {
            if (CustomerInfo == null)
            {
                llEditCustomerInfo.Enabled = false;
            }
        }

    }
}
