namespace StockPro
{
    partial class LowStockAlert
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
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLegend1 = new System.Windows.Forms.Label();
            this.lblLegend2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "⚠ Low Stock Alert";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Count
            this.lblCount.Text = "Total Low Stock Items: 0";
            this.lblCount.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCount.Location = new System.Drawing.Point(20, 50);
            this.lblCount.Size = new System.Drawing.Size(300, 23);

            // Legend
            this.lblLegend1.Text = "🔴 Out of Stock";
            this.lblLegend1.ForeColor = System.Drawing.Color.Crimson;
            this.lblLegend1.Location = new System.Drawing.Point(400, 50);
            this.lblLegend1.Size = new System.Drawing.Size(120, 20);

            this.lblLegend2.Text = "🟡 Low Stock";
            this.lblLegend2.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLegend2.Location = new System.Drawing.Point(530, 50);
            this.lblLegend2.Size = new System.Drawing.Size(120, 20);

            // DataGridView
            this.dgvLowStock.Location = new System.Drawing.Point(20, 80);
            this.dgvLowStock.Size = new System.Drawing.Size(860, 450);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.White;

            // Buttons
            this.btnRestock.Text = "Restock Selected";
            this.btnRestock.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Location = new System.Drawing.Point(20, 545);
            this.btnRestock.Size = new System.Drawing.Size(150, 35);
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);

            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(180, 545);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(290, 545);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblLegend1);
            this.Controls.Add(this.lblLegend2);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Low Stock Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblLegend1;
        private System.Windows.Forms.Label lblLegend2;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnBack;
    }
}