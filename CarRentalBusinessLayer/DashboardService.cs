using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsDashboardService
    {
        public static clsDashboardDTO GetDashboardData()
        {
            clsDashboardDTO DashboardData = new clsDashboardDTO();

            int AvailableVehicles = 0;
            int TotalVehicles = 0;
            int CurrentRentalsCount = 0;
            decimal CurrentMonthRevenue = 0;
            decimal LastMonthRevenue = 0;
            DataTable dtPendingReturns = new DataTable();
            DataTable dtRecentBookings = new DataTable();

            if (clsDashboardDataAccess.GetDashboardData(ref AvailableVehicles, ref TotalVehicles, 
                ref CurrentRentalsCount, ref CurrentMonthRevenue, ref LastMonthRevenue,
                ref dtPendingReturns, ref dtRecentBookings))
            {
                DashboardData.AvailableVehicles = AvailableVehicles;
                DashboardData.TotalVehicles = TotalVehicles;
                DashboardData.CurrentRentalsCount = CurrentRentalsCount;
                DashboardData.PendingReturnsCount = dtPendingReturns.Rows.Count;
                DashboardData.CurrentMonthRevenue = CurrentMonthRevenue;

                DashboardData.RevenueGrowthAmountVsLastMonth = DashboardData.CurrentMonthRevenue - LastMonthRevenue;
                
                if (LastMonthRevenue > 0)
                {
                    decimal Percentage = (DashboardData.RevenueGrowthAmountVsLastMonth / LastMonthRevenue) * 100;
                    DashboardData.RevenueGrowthPercentageVsLastMonth = Math.Round(Percentage, 2);
                }
                else
                {
                    DashboardData.RevenueGrowthPercentageVsLastMonth = CurrentMonthRevenue > 0 ? 100 : 0;
                }
            }

            DashboardData.PendingReturnsView = dtPendingReturns.DefaultView;
            DashboardData.RecentBookingsView = dtRecentBookings.DefaultView;

            return DashboardData;
        }

    }
}
