namespace StockPro
{
    partial class CreateAccount
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Create New Account";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);

            // Panel
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(20, 55);
            this.panelForm.Size = new System.Drawing.Size(360, 340);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // Username
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(10, 15);
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.Location = new System.Drawing.Point(10, 38);
            this.txtUsername.Size = new System.Drawing.Size(335, 23);
            this.txtUsername.Name = "txtUsername";

            // Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(10, 70);
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.Location = new System.Drawing.Point(10, 93);
            this.txtPassword.Size = new System.Drawing.Size(335, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';

            // Confirm Password
            this.lblConfirm.Text = "Confirm Password:";
            this.lblConfirm.Location = new System.Drawing.Point(10, 125);
            this.lblConfirm.Size = new System.Drawing.Size(130, 20);
            this.txtConfirm.Location = new System.Drawing.Point(10, 148);
            this.txtConfirm.Size = new System.Drawing.Size(335, 23);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';

            // Role
            this.lblRole.Text = "Role:";
            this.lblRole.Location = new System.Drawing.Point(10, 180);
            this.lblRole.Size = new System.Drawing.Size(100, 20);
            this.cmbRole.Location = new System.Drawing.Point(10, 203);
            this.cmbRole.Size = new System.Drawing.Size(335, 23);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Manager", "Logistics" });
            this.cmbRole.SelectedIndex = 2;

            // Buttons
            this.btnCreate.Text = "Create Account";
            this.btnCreate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(10, 250);
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(170, 250);
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.lblConfirm);
            this.panelForm.Controls.Add(this.txtConfirm);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.cmbRole);
            this.panelForm.Controls.Add(this.btnCreate);
            this.panelForm.Controls.Add(this.btnClear);

            // Back Button
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(20, 410);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Create Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelForm;
    }
}