namespace StockPro
{
    partial class PaymentGateway
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.btnMarkPending = new System.Windows.Forms.Button();
            this.btnMarkFailed = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "💳 Payment Gateway";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Summary Panel
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.Location = new System.Drawing.Point(20, 55);
            this.panelSummary.Size = new System.Drawing.Size(960, 60);

            this.lblTotal.Text = "Total Orders: 0";
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(10, 20);
            this.lblTotal.Size = new System.Drawing.Size(150, 20);

            this.lblPaid.Text = "Paid: 0";
            this.lblPaid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaid.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPaid.Location = new System.Drawing.Point(170, 20);
            this.lblPaid.Size = new System.Drawing.Size(100, 20);

            this.lblPending.Text = "Pending: 0";
            this.lblPending.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPending.Location = new System.Drawing.Point(280, 20);
            this.lblPending.Size = new System.Drawing.Size(100, 20);

            this.lblFailed.Text = "Failed: 0";
            this.lblFailed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFailed.ForeColor = System.Drawing.Color.Crimson;
            this.lblFailed.Location = new System.Drawing.Point(390, 20);
            this.lblFailed.Size = new System.Drawing.Size(100, 20);

            this.lblRevenue.Text = "Total Revenue: ৳0.00";
            this.lblRevenue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRevenue.Location = new System.Drawing.Point(500, 20);
            this.lblRevenue.Size = new System.Drawing.Size(200, 20);

            this.panelSummary.Controls.Add(this.lblTotal);
            this.panelSummary.Controls.Add(this.lblPaid);
            this.panelSummary.Controls.Add(this.lblPending);
            this.panelSummary.Controls.Add(this.lblFailed);
            this.panelSummary.Controls.Add(this.lblRevenue);

            // DataGridView
            this.dgvOrders.Location = new System.Drawing.Point(20, 130);
            this.dgvOrders.Size = new System.Drawing.Size(960, 420);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;

            // Buttons
            this.btnNewOrder.Text = "+ New Order";
            this.btnNewOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Location = new System.Drawing.Point(20, 565);
            this.btnNewOrder.Size = new System.Drawing.Size(120, 35);
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);

            this.btnMarkPaid.Text = "✔ Mark Paid";
            this.btnMarkPaid.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMarkPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPaid.Location = new System.Drawing.Point(150, 565);
            this.btnMarkPaid.Size = new System.Drawing.Size(110, 35);
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);

            this.btnMarkPending.Text = "⏳ Mark Pending";
            this.btnMarkPending.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMarkPending.ForeColor = System.Drawing.Color.White;
            this.btnMarkPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPending.Location = new System.Drawing.Point(270, 565);
            this.btnMarkPending.Size = new System.Drawing.Size(120, 35);
            this.btnMarkPending.Click += new System.EventHandler(this.btnMarkPending_Click);

            this.btnMarkFailed.Text = "✖ Mark Failed";
            this.btnMarkFailed.BackColor = System.Drawing.Color.Crimson;
            this.btnMarkFailed.ForeColor = System.Drawing.Color.White;
            this.btnMarkFailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkFailed.Location = new System.Drawing.Point(400, 565);
            this.btnMarkFailed.Size = new System.Drawing.Size(110, 35);
            this.btnMarkFailed.Click += new System.EventHandler(this.btnMarkFailed_Click);

            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(520, 565);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnBack.Text = "← Back";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(630, 565);
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.btnMarkPending);
            this.Controls.Add(this.btnMarkFailed);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Payment Gateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnMarkPaid;
        private System.Windows.Forms.Button btnMarkPending;
        private System.Windows.Forms.Button btnMarkFailed;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}