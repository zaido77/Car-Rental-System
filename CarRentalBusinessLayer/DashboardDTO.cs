using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsDashboardDTO
    {
        public int AvailableVehicles { get; set; }
        public int TotalVehicles { get; set; }

        public int CurrentRentalsCount { get; set; }

        public int PendingReturnsCount { get; set; }

        public decimal CurrentMonthRevenue { get; set; }
        public decimal RevenueGrowthPercentageVsLastMonth { get; set; }
        public decimal RevenueGrowthAmountVsLastMonth { get; set; }

        public DataView PendingReturnsView { get; set; }
        public DataView RecentBookingsView { get; set; }

    }
}
