using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            DataTable dt = DBHelper.ExecuteQuery("SELECT SupplierID, SupplierName, ContactNumber, Email FROM Supplier");
            dgvSuppliers.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Supplier (SupplierName, ContactNumber, Email) VALUES (@name, @contact, @email)";
            SqlParameter[] p = {
                new SqlParameter("@name",    txtSupplierName.Text.Trim()),
                new SqlParameter("@contact", txtContact.Text.Trim()),
                new SqlParameter("@email",   txtEmail.Text.Trim())
            };
            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Supplier added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadSuppliers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
            string query = "UPDATE Supplier SET SupplierName=@name, ContactNumber=@contact, Email=@email WHERE SupplierID=@id";
            SqlParameter[] p = {
                new SqlParameter("@name",    txtSupplierName.Text.Trim()),
                new SqlParameter("@contact", txtContact.Text.Trim()),
                new SqlParameter("@email",   txtEmail.Text.Trim()),
                new SqlParameter("@id",      id)
            };
            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Supplier updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
            string name = dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value.ToString();

            DialogResult confirm = MessageBox.Show("Delete \"" + name + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    DBHelper.ExecuteNonQuery("DELETE FROM Supplier WHERE SupplierID = @id",
                        new SqlParameter[] { new SqlParameter("@id", id) });
                    MessageBox.Show("Supplier deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadSuppliers();
                }
                catch
                {
                    MessageBox.Show("Cannot delete — this supplier has products linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSuppliers.SelectedRows[0];
                txtSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                txtContact.Text = row.Cells["ContactNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtSupplierName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }
    }
}