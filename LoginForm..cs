using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockPro
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            string query = "SELECT UserID, Role FROM Users WHERE Username = @username AND Password = @password";
            SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password)
    };

            DataTable result = DBHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count == 1)
            {
                int userID = Convert.ToInt32(result.Rows[0]["UserID"]);
                string role = result.Rows[0]["Role"].ToString();

                Session.UserID = userID;
                Session.Username = username;
                Session.Role = role;

                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                txtPassword.Clear();
            }
        }
    }
}