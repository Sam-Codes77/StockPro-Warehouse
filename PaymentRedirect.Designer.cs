namespace StockPro
{
    partial class PaymentRedirect
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
            this.panelGateway = new System.Windows.Forms.Panel();
            this.lblGatewayTitle = new System.Windows.Forms.Label();
            this.lblMethodLabel = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblAmountLabel = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOrderLabel = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Gateway Panel
            this.panelGateway.Location = new System.Drawing.Point(0, 0);
            this.panelGateway.Size = new System.Drawing.Size(460, 80);
            this.panelGateway.BackColor = System.Drawing.Color.SteelBlue;

            this.lblGatewayTitle.Text = "Payment Gateway";
            this.lblGatewayTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblGatewayTitle.ForeColor = System.Drawing.Color.White;
            this.lblGatewayTitle.Location = new System.Drawing.Point(10, 20);
            this.lblGatewayTitle.Size = new System.Drawing.Size(440, 40);
            this.lblGatewayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelGateway.Controls.Add(this.lblGatewayTitle);

            // Order info
            this.lblOrderLabel.Text = "Order:";
            this.lblOrderLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblOrderLabel.Location = new System.Drawing.Point(30, 100);
            this.lblOrderLabel.Size = new System.Drawing.Size(100, 25);

            this.lblOrderID.Text = "#0";
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.Location = new System.Drawing.Point(140, 100);
            this.lblOrderID.Size = new System.Drawing.Size(200, 25);

            this.lblMethodLabel.Text = "Method:";
            this.lblMethodLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMethodLabel.Location = new System.Drawing.Point(30, 135);
            this.lblMethodLabel.Size = new System.Drawing.Size(100, 25);

            this.lblMethod.Text = "--";
            this.lblMethod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMethod.Location = new System.Drawing.Point(140, 135);
            this.lblMethod.Size = new System.Drawing.Size(200, 25);

            this.lblAmountLabel.Text = "Amount:";
            this.lblAmountLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAmountLabel.Location = new System.Drawing.Point(30, 170);
            this.lblAmountLabel.Size = new System.Drawing.Size(100, 25);

            this.lblAmount.Text = "৳0.00";
            this.lblAmount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAmount.Location = new System.Drawing.Point(140, 165);
            this.lblAmount.Size = new System.Drawing.Size(200, 30);

            // Progress
            this.progressBar.Location = new System.Drawing.Point(30, 220);
            this.progressBar.Size = new System.Drawing.Size(400, 25);
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 100;
            this.progressBar.Value = 0;

            this.lblCountdown.Text = "Processing payment in 5 seconds...";
            this.lblCountdown.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCountdown.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCountdown.Location = new System.Drawing.Point(30, 255);
            this.lblCountdown.Size = new System.Drawing.Size(400, 25);
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Buttons
            this.btnConfirm.Text = "✔ Done";
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(30, 300);
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancel.Text = "✖ Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(200, 300);
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.panelGateway);
            this.Controls.Add(this.lblOrderLabel);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblMethodLabel);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblAmountLabel);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Text = "StockPro - Payment Processing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelGateway;
        private System.Windows.Forms.Label lblGatewayTitle;
        private System.Windows.Forms.Label lblMethodLabel;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblAmountLabel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOrderLabel;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}