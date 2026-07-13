using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.RentalBookings
{
    public partial class frmBookingDetails : FormWithTitle
    {
        public frmBookingDetails(int BookingID)
        {
            InitializeComponent();

            Title = "Booking Details";
            ucBookingInfo1.FillDetails(BookingID);
        }
    }
}
