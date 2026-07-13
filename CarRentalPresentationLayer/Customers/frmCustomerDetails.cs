using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Customers
{
    public partial class frmCustomerDetails : FormWithTitle
    {
        public frmCustomerDetails(int CustomerID)
        {
            InitializeComponent();

            Title = "Customer Details";
            ucCustomerInfo1.FillDetails(CustomerID);
        }
    }
}
