using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT CategoryID, CategoryName FROM Category");
            dgvCategories.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Category (CategoryName) VALUES (@name)";
            SqlParameter[] p = { new SqlParameter("@name", txtCategoryName.Text.Trim()) };
            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Category added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCategoryName.Text = "";
            LoadCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
            string query = "UPDATE Category SET CategoryName = @name WHERE CategoryID = @id";
            SqlParameter[] p = {
                new SqlParameter("@name", txtCategoryName.Text.Trim()),
                new SqlParameter("@id",   id)
            };
            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Category updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCategoryName.Text = "";
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
            string name = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Delete \"" + name + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DBHelper.ExecuteNonQuery("DELETE FROM Category WHERE CategoryID = @id",
                        new SqlParameter[] { new SqlParameter("@id", id) });
                    MessageBox.Show("Category deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoryName.Text = "";
                    LoadCategories();
                }
                catch
                {
                    MessageBox.Show("Cannot delete — this category has products linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
                txtCategoryName.Text = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}