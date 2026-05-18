namespace StockPro
{
    partial class LoginForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1 - Title
            this.label1.Text = "StockPro";
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 30);
            this.label1.Size = new System.Drawing.Size(150, 35);

            // label2 - Username
            this.label2.Text = "Username";
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Size = new System.Drawing.Size(80, 23);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(140, 97);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            this.txtUsername.Name = "txtUsername";

            // label3 - Password
            this.label3.Text = "Password";
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Size = new System.Drawing.Size(80, 23);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(140, 137);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(140, 180);
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblError
            this.lblError.Text = "";
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 230);
            this.lblError.Size = new System.Drawing.Size(300, 23);
            this.lblError.Name = "lblError";

            // LoginForm
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblError);
            this.Text = "StockPro - Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}