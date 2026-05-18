namespace StockPro
{
    partial class CategoryManagement
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Category Management";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Panel
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(20, 55);
            this.panelForm.Size = new System.Drawing.Size(300, 200);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // Category Name
            this.lblCategoryName.Text = "Category Name:";
            this.lblCategoryName.Location = new System.Drawing.Point(10, 15);
            this.lblCategoryName.Size = new System.Drawing.Size(120, 20);

            this.txtCategoryName.Location = new System.Drawing.Point(10, 38);
            this.txtCategoryName.Size = new System.Drawing.Size(275, 23);
            this.txtCategoryName.Name = "txtCategoryName";

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(10, 80);
            this.btnAdd.Size = new System.Drawing.Size(85, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(105, 80);
            this.btnUpdate.Size = new System.Drawing.Size(85, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(200, 80);
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.panelForm.Controls.Add(this.lblCategoryName);
            this.panelForm.Controls.Add(this.txtCategoryName);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);

            // DataGridView
            this.dgvCategories.Location = new System.Drawing.Point(20, 270);
            this.dgvCategories.Size = new System.Drawing.Size(660, 300);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.SelectionChanged += new System.EventHandler(this.dgvCategories_SelectionChanged);

            // Back Button
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(20, 585);
            this.btnBack.Size = new System.Drawing.Size(160, 30);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(700, 630);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Category Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel panelForm;
    }
}