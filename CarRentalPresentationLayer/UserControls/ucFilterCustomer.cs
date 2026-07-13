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
    public partial class ucFilterCustomer : UserControl
    {
        enum enFindBy : byte { CustomerID, Email, Phone }

        public int CustomerID { get; private set; } = -1;

        public ucFilterCustomer()
        {
            InitializeComponent();
        }

        public bool FillDetails(int CustomerID)
        {
            if (ucCustomerInfo1.FillDetails(CustomerID))
            {
                this.CustomerID = CustomerID;
                _LockFilter(CustomerID);
                return true;
            }

            return false;
        }

        void _LockFilter(int CustomerID)
        {
            cbFilter.SelectedItem = enFindBy.CustomerID;
            txtFilter.Text = CustomerID.ToString();
            gbFilter.Enabled = false;
        }

        public void Lock()
        {
            gbFilter.Enabled = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditCustomer();
            frm.ShowDialog();
        }

        private void ucFilterCustomer_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Add(enFindBy.CustomerID);
            cbFilter.Items.Add(enFindBy.Email);
            cbFilter.Items.Add(enFindBy.Phone);

            cbFilter.SelectedItem = enFindBy.Email;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool IsFound = false;
            string FilterText = txtFilter.Text;
            
            switch ((enFindBy)cbFilter.SelectedItem)
            {
                case enFindBy.CustomerID:
                    IsFound = ucCustomerInfo1.FillDetails(Convert.ToInt32(FilterText));
                    break;

                case enFindBy.Email:
                    IsFound = ucCustomerInfo1.FillDetails(FilterText, ucCustomerInfo.enFillBy.Email);
                    break;

                case enFindBy.Phone:
                    IsFound = ucCustomerInfo1.FillDetails(FilterText, ucCustomerInfo.enFillBy.Phone);
                    break;

                default: break;
            }

            this.CustomerID = IsFound ? ucCustomerInfo1.CustomerID : -1;
        }
    }
}
