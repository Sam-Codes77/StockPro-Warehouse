using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            LoadWeeklySales();
            LoadMonthlySales();
            LoadTopProducts();
        }

        private void LoadWeeklySales()
        {
            string query = @"SELECT 
                             DATENAME(WEEKDAY, OrderDate) AS Day,
                             COUNT(*) AS Orders,
                             ISNULL(SUM(TotalAmount), 0) AS Revenue
                             FROM Orders
                             WHERE OrderDate >= DATEADD(DAY, -7, GETDATE())
                             AND PaymentStatus = 'Paid'
                             GROUP BY DATENAME(WEEKDAY, OrderDate), DATEPART(WEEKDAY, OrderDate)
                             ORDER BY DATEPART(WEEKDAY, OrderDate)";
            dgvWeekly.DataSource = DBHelper.ExecuteQuery(query);

            object weekTotal = DBHelper.ExecuteScalar(@"SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders 
                               WHERE OrderDate >= DATEADD(DAY, -7, GETDATE()) AND PaymentStatus = 'Paid'");
            lblWeekTotal.Text = "This Week: ৳" + Convert.ToDecimal(weekTotal).ToString("N2");
        }

        private void LoadMonthlySales()
        {
            string query = @"SELECT 
                             DATENAME(MONTH, OrderDate) AS Month,
                             YEAR(OrderDate) AS Year,
                             COUNT(*) AS Orders,
                             ISNULL(SUM(TotalAmount), 0) AS Revenue
                             FROM Orders
                             WHERE OrderDate >= DATEADD(MONTH, -12, GETDATE())
                             AND PaymentStatus = 'Paid'
                             GROUP BY DATENAME(MONTH, OrderDate), MONTH(OrderDate), YEAR(OrderDate)
                             ORDER BY YEAR(OrderDate), MONTH(OrderDate)";
            dgvMonthly.DataSource = DBHelper.ExecuteQuery(query);

            object monthTotal = DBHelper.ExecuteScalar(@"SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders 
                                WHERE MONTH(OrderDate) = MONTH(GETDATE()) 
                                AND YEAR(OrderDate) = YEAR(GETDATE())
                                AND PaymentStatus = 'Paid'");
            lblMonthTotal.Text = "This Month: ৳" + Convert.ToDecimal(monthTotal).ToString("N2");
        }

        private void LoadTopProducts()
        {
            string query = @"SELECT TOP 5
                             p.ProductName,
                             SUM(od.Quantity) AS TotalSold,
                             SUM(od.Quantity * od.UnitPrice) AS Revenue
                             FROM Order_Details od
                             JOIN Product p ON od.ProductID = p.ProductID
                             JOIN Orders o ON od.OrderID = o.OrderID
                             WHERE o.PaymentStatus = 'Paid'
                             GROUP BY p.ProductName
                             ORDER BY TotalSold DESC";
            dgvTopProducts.DataSource = DBHelper.ExecuteQuery(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadWeeklySales();
            LoadMonthlySales();
            LoadTopProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
