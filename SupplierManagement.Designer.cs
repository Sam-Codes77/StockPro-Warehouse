namespace StockPro
{
    partial class SupplierManagement
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
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Supplier Management";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Panel
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(20, 55);
            this.panelForm.Size = new System.Drawing.Size(320, 280);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // Supplier Name
            this.lblSupplierName.Text = "Supplier Name:";
            this.lblSupplierName.Location = new System.Drawing.Point(10, 15);
            this.lblSupplierName.Size = new System.Drawing.Size(120, 20);
            this.txtSupplierName.Location = new System.Drawing.Point(10, 38);
            this.txtSupplierName.Size = new System.Drawing.Size(295, 23);
            this.txtSupplierName.Name = "txtSupplierName";

            // Contact
            this.lblContact.Text = "Contact Number:";
            this.lblContact.Location = new System.Drawing.Point(10, 70);
            this.lblContact.Size = new System.Drawing.Size(120, 20);
            this.txtContact.Location = new System.Drawing.Point(10, 93);
            this.txtContact.Size = new System.Drawing.Size(295, 23);
            this.txtContact.Name = "txtContact";

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(10, 125);
            this.lblEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.Location = new System.Drawing.Point(10, 148);
            this.txtEmail.Size = new System.Drawing.Size(295, 23);
            this.txtEmail.Name = "txtEmail";

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(10, 190);
            this.btnAdd.Size = new System.Drawing.Size(65, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(85, 190);
            this.btnUpdate.Size = new System.Drawing.Size(65, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(160, 190);
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(235, 190);
            this.btnClear.Size = new System.Drawing.Size(65, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelForm.Controls.Add(this.lblSupplierName);
            this.panelForm.Controls.Add(this.txtSupplierName);
            this.panelForm.Controls.Add(this.lblContact);
            this.panelForm.Controls.Add(this.txtContact);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);

            // DataGridView
            this.dgvSuppliers.Location = new System.Drawing.Point(20, 350);
            this.dgvSuppliers.Size = new System.Drawing.Size(760, 250);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.SelectionChanged += new System.EventHandler(this.dgvSuppliers_SelectionChanged);

            // Back Button
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(20, 615);
            this.btnBack.Size = new System.Drawing.Size(160, 30);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Supplier Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Panel panelForm;
    }
}