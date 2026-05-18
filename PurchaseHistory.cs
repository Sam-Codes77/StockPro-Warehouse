using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
            LoadUsers();
            LoadHistory();
        }

        private void LoadUsers()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT UserID, Username FROM Users");
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "Username";
            cmbUser.ValueMember = "UserID";
            cmbUser.SelectedIndex = -1;
        }

        private void LoadHistory(int userID = -1, string fromDate = null, string toDate = null)
        {
            string query = @"SELECT o.OrderID, u.Username AS Customer,
                             o.TotalAmount, o.PaymentStatus, o.PaymentMethod,
                             CONVERT(VARCHAR, o.OrderDate, 103) AS OrderDate,
                             od.Quantity, p.ProductName, od.UnitPrice
                             FROM Orders o
                             JOIN Users u ON o.UserID = u.UserID
                             JOIN Order_Details od ON o.OrderID = od.OrderID
                             JOIN Product p ON od.ProductID = p.ProductID
                             WHERE 1=1";

            if (userID > 0)
                query += " AND o.UserID = " + userID;
            if (!string.IsNullOrEmpty(fromDate))
                query += " AND o.OrderDate >= '" + fromDate + "'";
            if (!string.IsNullOrEmpty(toDate))
                query += " AND o.OrderDate <= '" + toDate + " 23:59:59'";

            query += " ORDER BY o.OrderDate DESC";

            DataTable dt = DBHelper.ExecuteQuery(query);
            dgvHistory.DataSource = dt;

            // Summary
            object totalRevenue = DBHelper.ExecuteScalar("SELECT ISNULL(SUM(TotalAmount),0) FROM Orders WHERE PaymentStatus='Paid'");
            lblTotalRevenue.Text = "Total Revenue: ৳" + Convert.ToDecimal(totalRevenue).ToString("N2");
            lblTotalOrders.Text = "Showing: " + dt.Rows.Count + " records";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int userID = cmbUser.SelectedValue != null && cmbUser.SelectedIndex >= 0
                ? Convert.ToInt32(cmbUser.SelectedValue) : -1;

            string fromDate = dtpFrom.Checked ? dtpFrom.Value.ToString("yyyy-MM-dd") : null;
            string toDate = dtpTo.Checked ? dtpTo.Value.ToString("yyyy-MM-dd") : null;

            LoadHistory(userID, fromDate, toDate);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbUser.SelectedIndex = -1;
            dtpFrom.Checked = false;
            dtpTo.Checked = false;
            LoadHistory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
