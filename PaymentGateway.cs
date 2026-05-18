using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class PaymentGateway : Form
    {
        public PaymentGateway()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = @"SELECT o.OrderID, u.Username AS Customer, 
                 o.TotalAmount, o.PaymentStatus, o.PaymentMethod,
                 CONVERT(VARCHAR, o.OrderDate, 103) AS OrderDate
                             FROM Orders o
                             JOIN Users u ON o.UserID = u.UserID
                             ORDER BY o.OrderDate DESC";
            dgvOrders.DataSource = DBHelper.ExecuteQuery(query);

            // Color rows by payment status
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                string status = row.Cells["PaymentStatus"].Value?.ToString();
                if (status == "Paid")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                else if (status == "Failed")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                else
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            object total = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Orders");
            object paid = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Orders WHERE PaymentStatus = 'Paid'");
            object pending = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Orders WHERE PaymentStatus = 'Pending'");
            object failed = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM Orders WHERE PaymentStatus = 'Failed'");
            object revenue = DBHelper.ExecuteScalar("SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE PaymentStatus = 'Paid'");

            lblTotal.Text = "Total Orders: " + total;
            lblPaid.Text = "Paid: " + paid;
            lblPending.Text = "Pending: " + pending;
            lblFailed.Text = "Failed: " + failed;
            lblRevenue.Text = "Total Revenue: ৳" + Convert.ToDecimal(revenue).ToString("N2");
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            UpdateStatus("Paid");
        }

        private void btnMarkFailed_Click(object sender, EventArgs e)
        {
            UpdateStatus("Failed");
        }

        private void btnMarkPending_Click(object sender, EventArgs e)
        {
            UpdateStatus("Pending");
        }

        private void UpdateStatus(string status)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);
            string query = "UPDATE Orders SET PaymentStatus = @status WHERE OrderID = @id";
            SqlParameter[] p = {
                new SqlParameter("@status", status),
                new SqlParameter("@id",     orderID)
            };
            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Order #" + orderID + " marked as " + status + ".", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadOrders();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            string productQuery = "SELECT ProductID, ProductName, Price FROM Product WHERE Quantity > 0";
            DataTable products = DBHelper.ExecuteQuery(productQuery);

            if (products.Rows.Count == 0)
            {
                MessageBox.Show("No products in stock to order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Form orderForm = new Form())
            {
                orderForm.Text = "New Order";
                orderForm.Size = new System.Drawing.Size(420, 380);
                orderForm.StartPosition = FormStartPosition.CenterParent;

                Label lblProduct = new Label() { Text = "Product:", Left = 10, Top = 15, Width = 100 };
                ComboBox cmbProduct = new ComboBox() { Left = 10, Top = 38, Width = 380, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbProduct.DataSource = products;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";

                Label lblQty = new Label() { Text = "Quantity:", Left = 10, Top = 75, Width = 100 };
                NumericUpDown nudQty = new NumericUpDown() { Left = 10, Top = 98, Width = 100, Minimum = 1, Maximum = 1000, Value = 1 };

                Label lblPayMethod = new Label() { Text = "Payment Method:", Left = 10, Top = 135, Width = 130 };
                ComboBox cmbPayMethod = new ComboBox() { Left = 10, Top = 158, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbPayMethod.Items.AddRange(new object[] { "Cash", "Debit Card", "Credit Card", "bKash", "Nagad" });
                cmbPayMethod.SelectedIndex = 0;

                Label lblStatus = new Label() { Text = "Payment Status:", Left = 10, Top = 195, Width = 130 };
                ComboBox cmbStatus = new ComboBox() { Left = 10, Top = 218, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbStatus.Items.AddRange(new object[] { "Pending", "Paid", "Failed" });
                cmbStatus.SelectedIndex = 0;

                Button btnOK = new Button() { Text = "Create Order", Left = 10, Top = 270, Width = 130, DialogResult = DialogResult.OK };
                Button btnCancel = new Button() { Text = "Cancel", Left = 150, Top = 270, Width = 80, DialogResult = DialogResult.Cancel };

                orderForm.Controls.AddRange(new System.Windows.Forms.Control[] {
            lblProduct, cmbProduct, lblQty, nudQty,
            lblPayMethod, cmbPayMethod,
            lblStatus, cmbStatus,
            btnOK, btnCancel });
                orderForm.AcceptButton = btnOK;

                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    int productID = Convert.ToInt32(cmbProduct.SelectedValue);
                    int qty = (int)nudQty.Value;
                    string status = cmbStatus.SelectedItem.ToString();
                    string payMethod = cmbPayMethod.SelectedItem.ToString();

                    object price = DBHelper.ExecuteScalar("SELECT Price FROM Product WHERE ProductID = @id",
                        new SqlParameter[] { new SqlParameter("@id", productID) });

                    decimal total = Convert.ToDecimal(price) * qty;

                    // Insert order with payment method
                    string insertOrder = @"INSERT INTO Orders (OrderDate, TotalAmount, PaymentStatus, PaymentMethod, UserID) 
                                   VALUES (GETDATE(), @total, @status, @payMethod, @userID)";
                    SqlParameter[] op = {
                new SqlParameter("@total",     total),
                new SqlParameter("@status",    status),
                new SqlParameter("@payMethod", payMethod),
                new SqlParameter("@userID",    Session.UserID)
            };
                    DBHelper.ExecuteNonQuery(insertOrder, op);

                    int newOrderID = Convert.ToInt32(DBHelper.ExecuteScalar("SELECT MAX(OrderID) FROM Orders"));

                    string insertDetail = "INSERT INTO Order_Details (OrderID, ProductID, Quantity, UnitPrice) VALUES (@orderID, @productID, @qty, @price)";
                    SqlParameter[] dp = {
                new SqlParameter("@orderID",   newOrderID),
                new SqlParameter("@productID", productID),
                new SqlParameter("@qty",       qty),
                new SqlParameter("@price",     Convert.ToDecimal(price))
            };
                    DBHelper.ExecuteNonQuery(insertDetail, dp);

                    DBHelper.ExecuteNonQuery("UPDATE Product SET Quantity = Quantity - @qty WHERE ProductID = @id",
                        new SqlParameter[] {
                    new SqlParameter("@qty", qty),
                    new SqlParameter("@id",  productID)
                        });

                    PaymentRedirect pr = new PaymentRedirect(payMethod, total, newOrderID);
                    pr.ShowDialog();
                    LoadOrders();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
