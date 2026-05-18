namespace StockPro
{
    partial class SalesReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWeekly = new System.Windows.Forms.Label();
            this.lblWeekTotal = new System.Windows.Forms.Label();
            this.dgvWeekly = new System.Windows.Forms.DataGridView();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblMonthTotal = new System.Windows.Forms.Label();
            this.dgvMonthly = new System.Windows.Forms.DataGridView();
            this.lblTopProducts = new System.Windows.Forms.Label();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "📊 Sales Report";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Weekly
            this.lblWeekly.Text = "Weekly Sales (Last 7 Days)";
            this.lblWeekly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeekly.Location = new System.Drawing.Point(20, 55);
            this.lblWeekly.Size = new System.Drawing.Size(250, 20);

            this.lblWeekTotal.Text = "This Week: ৳0.00";
            this.lblWeekTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblWeekTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblWeekTotal.Location = new System.Drawing.Point(300, 55);
            this.lblWeekTotal.Size = new System.Drawing.Size(200, 20);

            this.dgvWeekly.Location = new System.Drawing.Point(20, 80);
            this.dgvWeekly.Size = new System.Drawing.Size(500, 180);
            this.dgvWeekly.ReadOnly = true;
            this.dgvWeekly.AllowUserToAddRows = false;
            this.dgvWeekly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeekly.BackgroundColor = System.Drawing.Color.White;
            this.dgvWeekly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Monthly
            this.lblMonthly.Text = "Monthly Sales (Last 12 Months)";
            this.lblMonthly.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonthly.Location = new System.Drawing.Point(20, 275);
            this.lblMonthly.Size = new System.Drawing.Size(280, 20);

            this.lblMonthTotal.Text = "This Month: ৳0.00";
            this.lblMonthTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonthTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMonthTotal.Location = new System.Drawing.Point(320, 275);
            this.lblMonthTotal.Size = new System.Drawing.Size(200, 20);

            this.dgvMonthly.Location = new System.Drawing.Point(20, 300);
            this.dgvMonthly.Size = new System.Drawing.Size(500, 250);
            this.dgvMonthly.ReadOnly = true;
            this.dgvMonthly.AllowUserToAddRows = false;
            this.dgvMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthly.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Top Products
            this.lblTopProducts.Text = "Top 5 Best Selling Products";
            this.lblTopProducts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTopProducts.Location = new System.Drawing.Point(560, 55);
            this.lblTopProducts.Size = new System.Drawing.Size(280, 20);

            this.dgvTopProducts.Location = new System.Drawing.Point(560, 80);
            this.dgvTopProducts.Size = new System.Drawing.Size(500, 470);
            this.dgvTopProducts.ReadOnly = true;
            this.dgvTopProducts.AllowUserToAddRows = false;
            this.dgvTopProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Buttons
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(20, 570);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(130, 570);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(1100, 625);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWeekly);
            this.Controls.Add(this.lblWeekTotal);
            this.Controls.Add(this.dgvWeekly);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblMonthTotal);
            this.Controls.Add(this.dgvMonthly);
            this.Controls.Add(this.lblTopProducts);
            this.Controls.Add(this.dgvTopProducts);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Sales Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeekly;
        private System.Windows.Forms.Label lblWeekTotal;
        private System.Windows.Forms.DataGridView dgvWeekly;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblMonthTotal;
        private System.Windows.Forms.DataGridView dgvMonthly;
        private System.Windows.Forms.Label lblTopProducts;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}