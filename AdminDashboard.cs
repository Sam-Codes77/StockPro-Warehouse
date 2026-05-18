using System;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace StockPro
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Summary cards
            lblCard1Num.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Product").ToString();
            lblCard2Num.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Orders").ToString();
            lblCard3Num.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Product WHERE Quantity < LowStockThreshold").ToString();
            lblCard4Num.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Supplier").ToString();
            lblCard5Num.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Category").ToString();

            // Status bar
            lblStatusUser.Text = "User: " + Session.Username;
            lblStatusProducts.Text = "Products: " + lblCard1Num.Text;
            lblStatusOrders.Text = "Orders: " + lblCard2Num.Text;
            lblStatusRefresh.Text = "Last refresh: " + DateTime.Now.ToString("hh:mm tt");

            // Recent Orders
            string orderQuery = @"SELECT TOP 5 o.OrderID, u.Username AS Customer, 
                                  o.TotalAmount, o.PaymentStatus 
                                  FROM Orders o 
                                  JOIN Users u ON o.UserID = u.UserID 
                                  ORDER BY o.OrderDate DESC";
            DataTable orders = DBHelper.ExecuteQuery(orderQuery);
            dgvRecentOrders.DataSource = orders;

            // Stock Alerts
            lstStockAlerts.Items.Clear();
            string alertQuery = "SELECT ProductName, Quantity FROM Product WHERE Quantity < LowStockThreshold";
            DataTable alerts = DBHelper.ExecuteQuery(alertQuery);
            foreach (DataRow row in alerts.Rows)
            {
                lstStockAlerts.Items.Add("⚠ " + row["ProductName"] + " — " + row["Quantity"] + " remaining");
            }

            if (lstStockAlerts.Items.Count == 0)
                lstStockAlerts.Items.Add("✅ All stock levels are healthy.");

            // Hide buttons based on role
            if (Session.Role != "Admin")
            {
                btnNavUsers.Visible = false;
            }
            if (Session.Role == "Logistics")
            {
                btnNavCategories.Visible = false;
                btnNavSuppliers.Visible = false;
                btnNavReviews.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy\nhh:mm:ss tt");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.ShowDialog();
            LoadDashboard();
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            PaymentGateway pg = new PaymentGateway();
            pg.ShowDialog();
            LoadDashboard();
        }

        private void btnNavSuppliers_Click(object sender, EventArgs e)
        {
            SupplierManagement sm = new SupplierManagement();
            sm.ShowDialog();
            LoadDashboard();
        }

        private void btnNavCategories_Click(object sender, EventArgs e)
        {
            CategoryManagement cm = new CategoryManagement();
            cm.ShowDialog();
            LoadDashboard();
        }
        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.ShowDialog();
        }

        private void btnNavReviews_Click(object sender, EventArgs e)
        {
            ReviewSystem rs = new ReviewSystem();
            rs.ShowDialog();
            LoadDashboard();
        }

        private void btnNavHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistory ph = new PurchaseHistory();
            ph.ShowDialog();
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ShowDialog();
        }

    }
}