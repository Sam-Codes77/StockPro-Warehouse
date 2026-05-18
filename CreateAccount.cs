using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtConfirm.Clear();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            SqlParameter[] checkParams = { new SqlParameter("@username", username) };
            int exists = Convert.ToInt32(DBHelper.ExecuteScalar(checkQuery, checkParams));

            if (exists > 0)
            {
                MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                return;
            }

            // Insert new user
            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
            SqlParameter[] p = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@role",     role)
            };

            DBHelper.ExecuteNonQuery(query, p);
            MessageBox.Show("Account created successfully!\nUsername: " + username + "\nRole: " + role,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
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
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            cmbRole.SelectedIndex = 0;
        }
    }
}
