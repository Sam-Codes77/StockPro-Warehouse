namespace StockPro
{
    partial class ProductManagement
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // ── Title ──
            this.lblTitle.Text = "Product Management";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // ── Left Form Panel ──
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(20, 55);
            this.panelForm.Size = new System.Drawing.Size(320, 480);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // Product Name
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.Location = new System.Drawing.Point(10, 15);
            this.lblProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.Location = new System.Drawing.Point(10, 38);
            this.txtProductName.Size = new System.Drawing.Size(295, 23);
            this.txtProductName.Name = "txtProductName";

            // Category
            this.lblCategory.Text = "Category:";
            this.lblCategory.Location = new System.Drawing.Point(10, 70);
            this.lblCategory.Size = new System.Drawing.Size(100, 20);
            this.cmbCategory.Location = new System.Drawing.Point(10, 93);
            this.cmbCategory.Size = new System.Drawing.Size(295, 23);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Supplier
            this.lblSupplier.Text = "Supplier:";
            this.lblSupplier.Location = new System.Drawing.Point(10, 125);
            this.lblSupplier.Size = new System.Drawing.Size(100, 20);
            this.cmbSupplier.Location = new System.Drawing.Point(10, 148);
            this.cmbSupplier.Size = new System.Drawing.Size(295, 23);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Price
            this.lblPrice.Text = "Price:";
            this.lblPrice.Location = new System.Drawing.Point(10, 180);
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.Location = new System.Drawing.Point(10, 203);
            this.txtPrice.Size = new System.Drawing.Size(295, 23);
            this.txtPrice.Name = "txtPrice";

            // Quantity
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Location = new System.Drawing.Point(10, 235);
            this.lblQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.Location = new System.Drawing.Point(10, 258);
            this.txtQuantity.Size = new System.Drawing.Size(295, 23);
            this.txtQuantity.Name = "txtQuantity";

            // Low Stock Threshold
            this.lblThreshold.Text = "Low Stock Threshold:";
            this.lblThreshold.Location = new System.Drawing.Point(10, 290);
            this.lblThreshold.Size = new System.Drawing.Size(150, 20);
            this.txtThreshold.Location = new System.Drawing.Point(10, 313);
            this.txtThreshold.Size = new System.Drawing.Size(295, 23);
            this.txtThreshold.Name = "txtThreshold";

            // Buttons
            this.btnAdd.Text = "Add Product";
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 355);
            this.btnAdd.Size = new System.Drawing.Size(135, 35);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(155, 355);
            this.btnUpdate.Size = new System.Drawing.Size(150, 35);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 400);
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(155, 400);
            this.btnClear.Size = new System.Drawing.Size(150, 35);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelForm.Controls.Add(this.lblProductName);
            this.panelForm.Controls.Add(this.txtProductName);
            this.panelForm.Controls.Add(this.lblCategory);
            this.panelForm.Controls.Add(this.cmbCategory);
            this.panelForm.Controls.Add(this.lblSupplier);
            this.panelForm.Controls.Add(this.cmbSupplier);
            this.panelForm.Controls.Add(this.lblPrice);
            this.panelForm.Controls.Add(this.txtPrice);
            this.panelForm.Controls.Add(this.lblQuantity);
            this.panelForm.Controls.Add(this.txtQuantity);
            this.panelForm.Controls.Add(this.lblThreshold);
            this.panelForm.Controls.Add(this.txtThreshold);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);

            // ── Search ──
            this.lblSearch.Text = "Search:";
            this.lblSearch.Location = new System.Drawing.Point(360, 60);
            this.lblSearch.Size = new System.Drawing.Size(60, 23);
            this.txtSearch.Location = new System.Drawing.Point(420, 57);
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.Name = "txtSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(680, 55);
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // ── DataGridView ──
            this.dgvProducts.Location = new System.Drawing.Point(360, 95);
            this.dgvProducts.Size = new System.Drawing.Size(720, 430);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

            // ── Back Button ──
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(20, 550);
            this.btnBack.Size = new System.Drawing.Size(160, 30);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ── Form ──
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Product Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelForm;
    }
}