using CarRentalPresentationLayer.FuelTypes;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.Vehicles;
using CarRentalPresentationLayer.VehicleCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalPresentationLayer.Maintenances;
using CarRentalPresentationLayer.RentalBookings;
using CarRentalPresentationLayer.Transactions;
using CarRentalPresentationLayer.Returns;
using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Users;

namespace CarRentalPresentationLayer
{
    public partial class frmMainMenu : Form
    {
        clsDashboardDTO DashboardData;

        public frmMainMenu()
        {
            InitializeComponent();
            
            pnlSeparator.BackColor = clsColorsSettings.MainColor;
            lblWelcomeUser.Text = $"Welcome, {clsGlobal.CurrentUser.Username}";
        }

        void _UpdateTimeLabel()
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        void _UpdateDataViews()
        {
            // PendingReturns
            if (DashboardData.PendingReturnsView.Count > 0)
            {
                dgvPendingReturns.DataSource = DashboardData.PendingReturnsView;
                lblNoPendingReturns.Visible = false;
            }
            else
            {
                dgvPendingReturns.DataSource = null;
                lblNoPendingReturns.Visible = true;
            }

            // Recent Bookings
            if (DashboardData.RecentBookingsView.Count > 0)
            {
                dgvRecentBookings.DataSource = DashboardData.RecentBookingsView;
                lblNoRecentBookings.Visible = false;
            }
            else
            {
                dgvRecentBookings.DataSource = null;
                lblNoRecentBookings.Visible = true;
            }
        }

        void _UpdateSummaryCards()
        {
            lblAvailableVehicles.Text = $"{DashboardData.AvailableVehicles} / {DashboardData.TotalVehicles}";

            lblCurrentRentals.Text = DashboardData.CurrentRentalsCount.ToString();

            lblPendingReturns.Text = DashboardData.PendingReturnsCount.ToString();

            lblRevenue.Text = $"{DashboardData.CurrentMonthRevenue.ToString("F2")} AED";

            if (DashboardData.RevenueGrowthAmountVsLastMonth >= 0)
            {
                lblRevenueGrowth.Text = $"▲ +{DashboardData.RevenueGrowthPercentageVsLastMonth.ToString("F1")}% (+{DashboardData.RevenueGrowthAmountVsLastMonth.ToString("F2")} AED)";
                lblRevenueGrowth.ForeColor = Color.Green;
            }
            else
            {
                lblRevenueGrowth.Text = $"▼ {DashboardData.RevenueGrowthPercentageVsLastMonth.ToString("F1")}% ({DashboardData.RevenueGrowthAmountVsLastMonth.ToString("F2")} AED)";
                lblRevenueGrowth.ForeColor = Color.DarkRed;
            }
        }

        void _RefreshDashboard()
        {
            DashboardData = clsDashboardService.GetDashboardData();

            _UpdateDataViews();
            _UpdateSummaryCards();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageCustomers();
            frm.ShowDialog();
        }

        private void fuelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageFuelTypes();
            frm.ShowDialog();
        }

        private void vehicleCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageVehicleCategories();
            frm.ShowDialog();
        }

        private void maintenancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageMaintenances();
            frm.ShowDialog();
            _RefreshDashboard();
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageVehicles();
            frm.ShowDialog();
            _RefreshDashboard();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageRentalBookings();
            frm.ShowDialog();
            _RefreshDashboard();
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmViewReturns();
            frm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmViewTransactions();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _UpdateTimeLabel();

            timer1.Interval = 60000;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            _UpdateTimeLabel();
            timer1.Interval = 60000 - (DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);
            timer1.Start();

            _RefreshDashboard();
        }

        private void goToBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
            DataGridView dataGridView = (DataGridView)contextMenuStrip.SourceControl;

            int BookingID = (int)dataGridView.CurrentRow.Cells["BookingID"].Value;

            Form frm = new frmManageRentalBookings(BookingID);
            frm.ShowDialog();
            _RefreshDashboard();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to sign out?", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmProfile();
            frm.ShowDialog();
        }
    }
}
