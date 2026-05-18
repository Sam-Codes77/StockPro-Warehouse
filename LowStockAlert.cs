using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class LowStockAlert : Form
    {
        public LowStockAlert()
        {
            InitializeComponent();
            LoadLowStockItems();
        }

        private void LoadLowStockItems()
        {
            string query = @"SELECT p.ProductID, p.ProductName, c.CategoryName, 
                             s.SupplierName, p.Quantity, p.LowStockThreshold,
                             (p.LowStockThreshold - p.Quantity) AS Shortage
                             FROM Product p
                             JOIN Category c ON p.CategoryID = c.CategoryID
                             JOIN Supplier s ON p.SupplierID = s.SupplierID
                             WHERE p.Quantity < p.LowStockThreshold
                             ORDER BY p.Quantity ASC";

            DataTable dt = DBHelper.ExecuteQuery(query);
            dgvLowStock.DataSource = dt;

            lblCount.Text = "Total Low Stock Items: " + dt.Rows.Count;

            // Color rows red if out of stock, orange if low
            foreach (DataGridViewRow row in dgvLowStock.Rows)
            {
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                if (qty == 0)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                else
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLowStockItems();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvLowStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to restock.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productID = Convert.ToInt32(dgvLowStock.SelectedRows[0].Cells["ProductID"].Value);
            string name = dgvLowStock.SelectedRows[0].Cells["ProductName"].Value.ToString();
            int currentQty = Convert.ToInt32(dgvLowStock.SelectedRows[0].Cells["Quantity"].Value);

            using (Form prompt = new Form())
            {
                prompt.Text = "Restock: " + name;
                prompt.Size = new System.Drawing.Size(320, 150);
                prompt.StartPosition = FormStartPosition.CenterParent;

                Label lbl = new Label() { Text = "Current: " + currentQty + "  |  Add quantity:", Left = 10, Top = 15, Width = 280 };
                TextBox tb = new TextBox() { Left = 10, Top = 40, Width = 280, Text = "0" };
                Button ok = new Button() { Text = "Restock", Left = 10, Top = 75, Width = 100, DialogResult = DialogResult.OK };
                Button cancel = new Button() { Text = "Cancel", Left = 120, Top = 75, Width = 100, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(lbl);
                prompt.Controls.Add(tb);
                prompt.Controls.Add(ok);
                prompt.Controls.Add(cancel);
                prompt.AcceptButton = ok;

                if (prompt.ShowDialog() == DialogResult.OK && int.TryParse(tb.Text, out int addQty) && addQty > 0)
                {
                    string query = "UPDATE Product SET Quantity = Quantity + @qty WHERE ProductID = @id";
                    SqlParameter[] p = {
                new SqlParameter("@qty", addQty),
                new SqlParameter("@id",  productID)
            };
                    DBHelper.ExecuteNonQuery(query, p);
                    MessageBox.Show(name + " restocked by " + addQty + " units.", "Restocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLowStockItems();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}