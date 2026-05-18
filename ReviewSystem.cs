using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class ReviewSystem : Form
    {
        public ReviewSystem()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadReviews();
        }

        private void LoadSuppliers()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT SupplierID, SupplierName FROM Supplier");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
        }

        private void LoadReviews()
        {
            string query = @"SELECT r.ReviewID, s.SupplierName, r.Rating, r.Comments, 
                             CONVERT(VARCHAR, r.ReviewDate, 103) AS ReviewDate
                             FROM Reviews r
                             JOIN Supplier s ON r.SupplierID = s.SupplierID
                             ORDER BY r.ReviewDate DESC";
            dgvReviews.DataSource = DBHelper.ExecuteQuery(query);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue == null)
            {
                MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtComments.Text))
            {
                MessageBox.Show("Please enter a comment.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Reviews (SupplierID, Rating, Comments, ReviewDate) VALUES (@supID, @rating, @comments, GETDATE())";
            SqlParameter[] p = {
               new SqlParameter("@supID", int.Parse(cmbSupplier.SelectedValue.ToString())),
                new SqlParameter("@rating",   (int)nudRating.Value),
                new SqlParameter("@comments", txtComments.Text.Trim())
            };

            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Review submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtComments.Text = "";
            nudRating.Value = 5;
            LoadReviews();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reviewID = Convert.ToInt32(dgvReviews.SelectedRows[0].Cells["ReviewID"].Value);
            DialogResult confirm = MessageBox.Show("Delete this review?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DBHelper.ExecuteNonQuery("DELETE FROM Reviews WHERE ReviewID = @id",
                    new SqlParameter[] { new SqlParameter("@id", reviewID) });
                MessageBox.Show("Review deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReviews();
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue == null) return;

            int supplierID;
            if (!int.TryParse(cmbSupplier.SelectedValue.ToString(), out supplierID)) return;

            string query = "SELECT AVG(CAST(Rating AS FLOAT)) FROM Reviews WHERE SupplierID = @id";
            SqlParameter[] p = { new SqlParameter("@id", supplierID) };
            object avg = DBHelper.ExecuteScalar(query, p);

            if (avg != DBNull.Value && avg != null)
                lblAvgRating.Text = "Avg Rating: " + Convert.ToDouble(avg).ToString("0.0") + " ⭐";
            else
                lblAvgRating.Text = "Avg Rating: No reviews yet";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
