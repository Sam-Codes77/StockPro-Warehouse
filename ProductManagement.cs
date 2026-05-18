using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
            LoadProducts();
        }

        private void LoadProducts()
        {
            string query = @"SELECT p.ProductID, p.ProductName, c.CategoryName, 
                             s.SupplierName, p.Price, p.Quantity, p.LowStockThreshold
                             FROM Product p
                             JOIN Category c ON p.CategoryID = c.CategoryID
                             JOIN Supplier s ON p.SupplierID = s.SupplierID";
            DataTable dt = DBHelper.ExecuteQuery(query);
            dgvProducts.DataSource = dt;
        }

        private void LoadCategories()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT CategoryID, CategoryName FROM Category");
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void LoadSuppliers()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT SupplierID, SupplierName FROM Supplier");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Product (ProductName, CategoryID, SupplierID, Price, Quantity, LowStockThreshold)
                             VALUES (@name, @catID, @supID, @price, @qty, @threshold)";
            SqlParameter[] p = {
                new SqlParameter("@name",      txtProductName.Text.Trim()),
                new SqlParameter("@catID",     cmbCategory.SelectedValue),
                new SqlParameter("@supID",     cmbSupplier.SelectedValue),
                new SqlParameter("@price",     decimal.Parse(txtPrice.Text)),
                new SqlParameter("@qty",       int.Parse(txtQuantity.Text)),
                new SqlParameter("@threshold", string.IsNullOrEmpty(txtThreshold.Text) ? 10 : int.Parse(txtThreshold.Text))
            };

            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

            string query = @"UPDATE Product SET ProductName=@name, CategoryID=@catID, SupplierID=@supID,
                             Price=@price, Quantity=@qty, LowStockThreshold=@threshold
                             WHERE ProductID=@id";
            SqlParameter[] p = {
                new SqlParameter("@name",      txtProductName.Text.Trim()),
                new SqlParameter("@catID",     cmbCategory.SelectedValue),
                new SqlParameter("@supID",     cmbSupplier.SelectedValue),
                new SqlParameter("@price",     decimal.Parse(txtPrice.Text)),
                new SqlParameter("@qty",       int.Parse(txtQuantity.Text)),
                new SqlParameter("@threshold", string.IsNullOrEmpty(txtThreshold.Text) ? 10 : int.Parse(txtThreshold.Text)),
                new SqlParameter("@id",        productID)
            };

            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete \"" + productName + "\"?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DBHelper.ExecuteNonQuery("DELETE FROM Product WHERE ProductID = @id",
                    new SqlParameter[] { new SqlParameter("@id", productID) });
                MessageBox.Show("Product deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadProducts();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string query = @"SELECT p.ProductID, p.ProductName, c.CategoryName, 
                             s.SupplierName, p.Price, p.Quantity, p.LowStockThreshold
                             FROM Product p
                             JOIN Category c ON p.CategoryID = c.CategoryID
                             JOIN Supplier s ON p.SupplierID = s.SupplierID
                             WHERE p.ProductName LIKE @search OR c.CategoryName LIKE @search";
            SqlParameter[] p = { new SqlParameter("@search", "%" + search + "%") };
            dgvProducts.DataSource = DBHelper.ExecuteQuery(query, p);
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtThreshold.Text = row.Cells["LowStockThreshold"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtThreshold.Text = "";
            txtSearch.Text = "";
            LoadProducts();
        }
    }
}