namespace StockPro
{
    partial class PurchaseHistory
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
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "📋 Purchase History";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Filter Panel
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Location = new System.Drawing.Point(20, 55);
            this.panelFilter.Size = new System.Drawing.Size(1060, 70);

            // User filter
            this.lblUser.Text = "Customer:";
            this.lblUser.Location = new System.Drawing.Point(10, 25);
            this.lblUser.Size = new System.Drawing.Size(70, 20);

            this.cmbUser.Location = new System.Drawing.Point(85, 22);
            this.cmbUser.Size = new System.Drawing.Size(180, 23);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // From date
            this.lblFrom.Text = "From:";
            this.lblFrom.Location = new System.Drawing.Point(280, 25);
            this.lblFrom.Size = new System.Drawing.Size(40, 20);

            this.dtpFrom.Location = new System.Drawing.Point(325, 22);
            this.dtpFrom.Size = new System.Drawing.Size(150, 23);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Checked = false;

            // To date
            this.lblTo.Text = "To:";
            this.lblTo.Location = new System.Drawing.Point(490, 25);
            this.lblTo.Size = new System.Drawing.Size(30, 20);

            this.dtpTo.Location = new System.Drawing.Point(525, 22);
            this.dtpTo.Size = new System.Drawing.Size(150, 23);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Checked = false;

            // Filter buttons
            this.btnFilter.Text = "Filter";
            this.btnFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(690, 20);
            this.btnFilter.Size = new System.Drawing.Size(80, 30);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Location = new System.Drawing.Point(780, 20);
            this.btnClearFilter.Size = new System.Drawing.Size(80, 30);
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);

            this.panelFilter.Controls.Add(this.lblUser);
            this.panelFilter.Controls.Add(this.cmbUser);
            this.panelFilter.Controls.Add(this.lblFrom);
            this.panelFilter.Controls.Add(this.dtpFrom);
            this.panelFilter.Controls.Add(this.lblTo);
            this.panelFilter.Controls.Add(this.dtpTo);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnClearFilter);

            // Summary labels
            this.lblTotalOrders.Text = "Showing: 0 records";
            this.lblTotalOrders.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.Location = new System.Drawing.Point(20, 135);
            this.lblTotalOrders.Size = new System.Drawing.Size(200, 20);

            this.lblTotalRevenue.Text = "Total Revenue: ৳0.00";
            this.lblTotalRevenue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalRevenue.Location = new System.Drawing.Point(250, 135);
            this.lblTotalRevenue.Size = new System.Drawing.Size(250, 20);

            // DataGridView
            this.dgvHistory.Location = new System.Drawing.Point(20, 160);
            this.dgvHistory.Size = new System.Drawing.Size(1060, 430);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;

            // Back button
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(20, 605);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Purchase History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelFilter;
    }
}