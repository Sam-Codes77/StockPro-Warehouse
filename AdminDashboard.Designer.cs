namespace StockPro
{
    partial class AdminDashboard
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblNav = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavSuppliers = new System.Windows.Forms.Button();
            this.btnNavCategories = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavReviews = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.lblQuickInfo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();

            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnNewOrder = new System.Windows.Forms.ToolStripButton();
            this.btnAddProduct = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();

            this.panelMain = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();

            // Summary Cards
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Num = new System.Windows.Forms.Label();
            this.lblCard1Text = new System.Windows.Forms.Label();

            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Num = new System.Windows.Forms.Label();
            this.lblCard2Text = new System.Windows.Forms.Label();

            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Num = new System.Windows.Forms.Label();
            this.lblCard3Text = new System.Windows.Forms.Label();

            this.panelCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Num = new System.Windows.Forms.Label();
            this.lblCard4Text = new System.Windows.Forms.Label();

            this.panelCard5 = new System.Windows.Forms.Panel();
            this.lblCard5Num = new System.Windows.Forms.Label();
            this.lblCard5Text = new System.Windows.Forms.Label();

            // Recent Orders
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnNewOrderMain = new System.Windows.Forms.Button();

            // Stock Alerts
            this.lblStockAlerts = new System.Windows.Forms.Label();
            this.lstStockAlerts = new System.Windows.Forms.ListBox();
            this.btnManageStock = new System.Windows.Forms.Button();

            // Status bar
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusProducts = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusRefresh = new System.Windows.Forms.ToolStripStatusLabel();

            this.timer1 = new System.Windows.Forms.Timer();

            this.SuspendLayout();

            // ── Menu Strip ──
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenu, this.editMenu, this.viewMenu,
                this.reportsMenu, this.toolsMenu, this.helpMenu });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.fileMenu.Text = "File";
            this.editMenu.Text = "Edit";
            this.viewMenu.Text = "View";
            this.reportsMenu.Text = "Reports";
            this.toolsMenu.Text = "Tools";
            this.helpMenu.Text = "Help";

            // ── Tool Strip ──
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnHome, this.btnNewOrder, this.btnAddProduct,
                this.btnPrint, this.btnRefresh });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Size = new System.Drawing.Size(1100, 25);
            this.btnHome.Text = "🏠 Home";
            this.btnNewOrder.Text = "+ New Order";
            this.btnAddProduct.Text = "+ Add Product";
            this.btnPrint.Text = "🖨 Print";
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // ── Left Panel ──
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Size = new System.Drawing.Size(160, 580);

            this.lblNav.Text = "Navigation";
            this.lblNav.ForeColor = System.Drawing.Color.Orange;
            this.lblNav.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNav.Location = new System.Drawing.Point(10, 10);
            this.lblNav.Size = new System.Drawing.Size(140, 20);

            // Nav Buttons
            System.Drawing.Color navFore = System.Drawing.Color.White;
            System.Drawing.Color navBack = System.Drawing.Color.FromArgb(30, 30, 60);
            System.Drawing.Font navFont = new System.Drawing.Font("Arial", 9F);

            this.btnNavDashboard.Text = "📊 Dashboard";
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 35);
            this.btnNavDashboard.Size = new System.Drawing.Size(160, 35);
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.ForeColor = navFore;
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(50, 50, 100);
            this.btnNavDashboard.Font = navFont;

            this.btnNavProducts.Text = "📦 Products";
            this.btnNavProducts.Location = new System.Drawing.Point(0, 75);
            this.btnNavProducts.Size = new System.Drawing.Size(160, 35);
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.ForeColor = navFore;
            this.btnNavProducts.BackColor = navBack;
            this.btnNavProducts.Font = navFont;
            this.btnNavProducts.Click += new System.EventHandler(this.btnNavProducts_Click);

            this.btnNavOrders.Text = "🛒 Orders";
            this.btnNavOrders.Location = new System.Drawing.Point(0, 115);
            this.btnNavOrders.Size = new System.Drawing.Size(160, 35);
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.ForeColor = navFore;
            this.btnNavOrders.BackColor = navBack;
            this.btnNavOrders.Font = navFont;
            this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);

            this.btnNavSuppliers.Text = "🏭 Suppliers";
            this.btnNavSuppliers.Location = new System.Drawing.Point(0, 155);
            this.btnNavSuppliers.Size = new System.Drawing.Size(160, 35);
            this.btnNavSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSuppliers.ForeColor = navFore;
            this.btnNavSuppliers.BackColor = navBack;
            this.btnNavSuppliers.Font = navFont;
            this.btnNavSuppliers.Click += new System.EventHandler(this.btnNavSuppliers_Click);

            this.btnNavCategories.Text = "🗂 Categories";
            this.btnNavCategories.Location = new System.Drawing.Point(0, 195);
            this.btnNavCategories.Size = new System.Drawing.Size(160, 35);
            this.btnNavCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCategories.ForeColor = navFore;
            this.btnNavCategories.BackColor = navBack;
            this.btnNavCategories.Font = navFont;
            this.btnNavCategories.Click += new System.EventHandler(this.btnNavCategories_Click);

            this.btnNavUsers.Text = "👤 Users";
            this.btnNavUsers.Location = new System.Drawing.Point(0, 235);
            this.btnNavUsers.Size = new System.Drawing.Size(160, 35);
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.ForeColor = navFore;
            this.btnNavUsers.BackColor = navBack;
            this.btnNavUsers.Font = navFont;
            this.btnNavUsers.Click += new System.EventHandler(this.btnNavUsers_Click);

            this.btnNavReviews.Text = "⭐ Reviews";
            this.btnNavReviews.Location = new System.Drawing.Point(0, 275);
            this.btnNavReviews.Size = new System.Drawing.Size(160, 35);
            this.btnNavReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReviews.ForeColor = navFore;
            this.btnNavReviews.BackColor = navBack;
            this.btnNavReviews.Font = navFont;
            this.btnNavReviews.Click += new System.EventHandler(this.btnNavReviews_Click);

            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavHistory.Text = "📋 History";
            this.btnNavHistory.Location = new System.Drawing.Point(0, 315);
            this.btnNavHistory.Size = new System.Drawing.Size(160, 35);
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.ForeColor = System.Drawing.Color.White;
            this.btnNavHistory.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.btnNavHistory.Font = navFont;
            this.btnNavHistory.Click += new System.EventHandler(this.btnNavHistory_Click);

            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavReports.Text = "📊 Sales Report";
            this.btnNavReports.Location = new System.Drawing.Point(0, 395);
            this.btnNavReports.Size = new System.Drawing.Size(160, 35);
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.ForeColor = System.Drawing.Color.White;
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(30, 30, 60);
            this.btnNavReports.Font = navFont;
            this.btnNavReports.Click += new System.EventHandler(this.btnNavReports_Click);

            this.btnNavSettings.Text = "⚙ Settings";
            this.btnNavSettings.Location = new System.Drawing.Point(0, 355);
            this.btnNavSettings.Size = new System.Drawing.Size(160, 35);
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.ForeColor = navFore;
            this.btnNavSettings.BackColor = navBack;
            this.btnNavSettings.Font = navFont;

            this.lblQuickInfo.Text = "Quick Info";
            this.lblQuickInfo.ForeColor = System.Drawing.Color.Orange;
            this.lblQuickInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuickInfo.Location = new System.Drawing.Point(10, 370);
            this.lblQuickInfo.Size = new System.Drawing.Size(140, 20);

            this.lblDateTime.Text = "";
            this.lblDateTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 8F);
            this.lblDateTime.Location = new System.Drawing.Point(10, 395);
            this.lblDateTime.Size = new System.Drawing.Size(140, 40);

            this.panelLeft.Controls.Add(this.lblNav);
            this.panelLeft.Controls.Add(this.btnNavDashboard);
            this.panelLeft.Controls.Add(this.btnNavProducts);
            this.panelLeft.Controls.Add(this.btnNavOrders);
            this.panelLeft.Controls.Add(this.btnNavSuppliers);
            this.panelLeft.Controls.Add(this.btnNavCategories);
            this.panelLeft.Controls.Add(this.btnNavUsers);
            this.panelLeft.Controls.Add(this.btnNavReviews);
            this.panelLeft.Controls.Add(this.btnNavHistory);
            this.panelLeft.Controls.Add(this.btnNavSettings);
            this.panelLeft.Controls.Add(this.lblQuickInfo);
            this.panelLeft.Controls.Add(this.lblDateTime);

            // ── Main Panel ──
            this.panelMain.Location = new System.Drawing.Point(160, 49);
            this.panelMain.Size = new System.Drawing.Size(940, 580);
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;

            // Summary Label
            this.lblSummary.Text = "Summary";
            this.lblSummary.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Location = new System.Drawing.Point(10, 10);
            this.lblSummary.Size = new System.Drawing.Size(100, 20);

            // ── Summary Cards ──
            int cardY = 35;
            int cardW = 160, cardH = 70;

            // Card 1 - Total Products
            this.panelCard1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCard1.Location = new System.Drawing.Point(10, cardY);
            this.panelCard1.Size = new System.Drawing.Size(cardW, cardH);
            this.lblCard1Num.Text = "0";
            this.lblCard1Num.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard1Num.ForeColor = System.Drawing.Color.White;
            this.lblCard1Num.Location = new System.Drawing.Point(10, 5);
            this.lblCard1Num.Size = new System.Drawing.Size(140, 35);
            this.lblCard1Text.Text = "Total Products";
            this.lblCard1Text.ForeColor = System.Drawing.Color.White;
            this.lblCard1Text.Location = new System.Drawing.Point(10, 42);
            this.lblCard1Text.Size = new System.Drawing.Size(140, 20);
            this.panelCard1.Controls.Add(this.lblCard1Num);
            this.panelCard1.Controls.Add(this.lblCard1Text);

            // Card 2 - Total Orders
            this.panelCard2.BackColor = System.Drawing.Color.SeaGreen;
            this.panelCard2.Location = new System.Drawing.Point(180, cardY);
            this.panelCard2.Size = new System.Drawing.Size(cardW, cardH);
            this.lblCard2Num.Text = "0";
            this.lblCard2Num.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard2Num.ForeColor = System.Drawing.Color.White;
            this.lblCard2Num.Location = new System.Drawing.Point(10, 5);
            this.lblCard2Num.Size = new System.Drawing.Size(140, 35);
            this.lblCard2Text.Text = "Total Orders";
            this.lblCard2Text.ForeColor = System.Drawing.Color.White;
            this.lblCard2Text.Location = new System.Drawing.Point(10, 42);
            this.lblCard2Text.Size = new System.Drawing.Size(140, 20);
            this.panelCard2.Controls.Add(this.lblCard2Num);
            this.panelCard2.Controls.Add(this.lblCard2Text);

            // Card 3 - Low Stock
            this.panelCard3.BackColor = System.Drawing.Color.Crimson;
            this.panelCard3.Location = new System.Drawing.Point(350, cardY);
            this.panelCard3.Size = new System.Drawing.Size(cardW, cardH);
            this.lblCard3Num.Text = "0";
            this.lblCard3Num.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard3Num.ForeColor = System.Drawing.Color.White;
            this.lblCard3Num.Location = new System.Drawing.Point(10, 5);
            this.lblCard3Num.Size = new System.Drawing.Size(140, 35);
            this.lblCard3Text.Text = "Low Stock";
            this.lblCard3Text.ForeColor = System.Drawing.Color.White;
            this.lblCard3Text.Location = new System.Drawing.Point(10, 42);
            this.lblCard3Text.Size = new System.Drawing.Size(140, 20);
            this.panelCard3.Controls.Add(this.lblCard3Num);
            this.panelCard3.Controls.Add(this.lblCard3Text);

            // Card 4 - Suppliers
            this.panelCard4.BackColor = System.Drawing.Color.DarkOrange;
            this.panelCard4.Location = new System.Drawing.Point(520, cardY);
            this.panelCard4.Size = new System.Drawing.Size(cardW, cardH);
            this.lblCard4Num.Text = "0";
            this.lblCard4Num.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard4Num.ForeColor = System.Drawing.Color.White;
            this.lblCard4Num.Location = new System.Drawing.Point(10, 5);
            this.lblCard4Num.Size = new System.Drawing.Size(140, 35);
            this.lblCard4Text.Text = "Suppliers";
            this.lblCard4Text.ForeColor = System.Drawing.Color.White;
            this.lblCard4Text.Location = new System.Drawing.Point(10, 42);
            this.lblCard4Text.Size = new System.Drawing.Size(140, 20);
            this.panelCard4.Controls.Add(this.lblCard4Num);
            this.panelCard4.Controls.Add(this.lblCard4Text);

            // Card 5 - Categories
            this.panelCard5.BackColor = System.Drawing.Color.SlateBlue;
            this.panelCard5.Location = new System.Drawing.Point(690, cardY);
            this.panelCard5.Size = new System.Drawing.Size(cardW, cardH);
            this.lblCard5Num.Text = "0";
            this.lblCard5Num.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblCard5Num.ForeColor = System.Drawing.Color.White;
            this.lblCard5Num.Location = new System.Drawing.Point(10, 5);
            this.lblCard5Num.Size = new System.Drawing.Size(140, 35);
            this.lblCard5Text.Text = "Categories";
            this.lblCard5Text.ForeColor = System.Drawing.Color.White;
            this.lblCard5Text.Location = new System.Drawing.Point(10, 42);
            this.lblCard5Text.Size = new System.Drawing.Size(140, 20);
            this.panelCard5.Controls.Add(this.lblCard5Num);
            this.panelCard5.Controls.Add(this.lblCard5Text);

            // ── Recent Orders ──
            this.lblRecentOrders.Text = "Recent Orders";
            this.lblRecentOrders.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrders.Location = new System.Drawing.Point(10, 120);
            this.lblRecentOrders.Size = new System.Drawing.Size(150, 20);

            this.dgvRecentOrders.Location = new System.Drawing.Point(10, 145);
            this.dgvRecentOrders.Size = new System.Drawing.Size(480, 180);
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.btnViewAll.Text = "View All";
            this.btnViewAll.Location = new System.Drawing.Point(10, 335);
            this.btnViewAll.Size = new System.Drawing.Size(100, 30);
            this.btnViewAll.Click += new System.EventHandler(this.btnNavOrders_Click);

            this.btnNewOrderMain.Text = "New Order";
            this.btnNewOrderMain.Location = new System.Drawing.Point(120, 335);
            this.btnNewOrderMain.Size = new System.Drawing.Size(100, 30);

            // ── Stock Alerts ──
            this.lblStockAlerts.Text = "Stock Alerts";
            this.lblStockAlerts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockAlerts.Location = new System.Drawing.Point(10, 380);
            this.lblStockAlerts.Size = new System.Drawing.Size(150, 20);

            this.lstStockAlerts.Location = new System.Drawing.Point(10, 405);
            this.lstStockAlerts.Size = new System.Drawing.Size(480, 120);

            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.Location = new System.Drawing.Point(10, 535);
            this.btnManageStock.Size = new System.Drawing.Size(120, 30);
            this.btnManageStock.Click += new System.EventHandler(this.btnNavProducts_Click);

            // Add to main panel
            this.panelMain.Controls.Add(this.lblSummary);
            this.panelMain.Controls.Add(this.panelCard1);
            this.panelMain.Controls.Add(this.panelCard2);
            this.panelMain.Controls.Add(this.panelCard3);
            this.panelMain.Controls.Add(this.panelCard4);
            this.panelMain.Controls.Add(this.panelCard5);
            this.panelMain.Controls.Add(this.lblRecentOrders);
            this.panelMain.Controls.Add(this.dgvRecentOrders);
            this.panelMain.Controls.Add(this.btnViewAll);
            this.panelMain.Controls.Add(this.btnNewOrderMain);
            this.panelMain.Controls.Add(this.lblStockAlerts);
            this.panelMain.Controls.Add(this.lstStockAlerts);
            this.panelMain.Controls.Add(this.btnManageStock);

            // ── Status Strip ──
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusReady, this.lblStatusUser,
                this.lblStatusProducts, this.lblStatusOrders, this.lblStatusRefresh });
            this.lblStatusReady.Text = "Ready";
            this.lblStatusUser.Text = "User: Admin";
            this.lblStatusProducts.Text = "Products: 0";
            this.lblStatusOrders.Text = "Orders: 0";
            this.lblStatusRefresh.Text = "Last refresh: --";

            // ── Timer ──
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();

            // ── Form ──
            this.MainMenuStrip = this.menuStrip1;
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip1);
            this.Text = "Inventory Management System - Admin Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Controls
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavSuppliers;
        private System.Windows.Forms.Button btnNavCategories;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavReviews;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Label lblQuickInfo;
        private System.Windows.Forms.Label lblDateTime;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnNewOrder;
        private System.Windows.Forms.ToolStripButton btnAddProduct;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnRefresh;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblSummary;

        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblCard1Num;
        private System.Windows.Forms.Label lblCard1Text;

        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblCard2Num;
        private System.Windows.Forms.Label lblCard2Text;

        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblCard3Num;
        private System.Windows.Forms.Label lblCard3Text;

        private System.Windows.Forms.Panel panelCard4;
        private System.Windows.Forms.Label lblCard4Num;
        private System.Windows.Forms.Label lblCard4Text;

        private System.Windows.Forms.Panel panelCard5;
        private System.Windows.Forms.Label lblCard5Num;
        private System.Windows.Forms.Label lblCard5Text;

        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnNewOrderMain;

        private System.Windows.Forms.Label lblStockAlerts;
        private System.Windows.Forms.ListBox lstStockAlerts;
        private System.Windows.Forms.Button btnManageStock;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusReady;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusProducts;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusRefresh;

        private System.Windows.Forms.Timer timer1;
    }
}