using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockPro
{
    public partial class PaymentRedirect : Form
    {
        private string _paymentMethod;
        private decimal _amount;
        private int _orderID;
        private System.Windows.Forms.Timer _timer;
        private int _countdown = 5;

        public bool PaymentSuccessful { get; private set; } = false;

        public PaymentRedirect(string paymentMethod, decimal amount, int orderID)
        {
            InitializeComponent();
            _paymentMethod = paymentMethod;
            _amount = amount;
            _orderID = orderID;

            SetupUI();
            StartRedirect();
        }

        private void SetupUI()
        {
            lblMethod.Text = _paymentMethod;
            lblAmount.Text = "৳" + _amount.ToString("N2");
            lblOrderID.Text = "Order #" + _orderID;

            // Change color/icon based on method
            switch (_paymentMethod)
            {
                case "bKash":
                    panelGateway.BackColor = System.Drawing.Color.FromArgb(220, 53, 130);
                    lblGatewayTitle.Text = "bKash Payment";
                    lblGatewayTitle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Nagad":
                    panelGateway.BackColor = System.Drawing.Color.FromArgb(240, 100, 30);
                    lblGatewayTitle.Text = "Nagad Payment";
                    lblGatewayTitle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Visa":
                case "Credit Card":
                    panelGateway.BackColor = System.Drawing.Color.FromArgb(26, 86, 163);
                    lblGatewayTitle.Text = "Visa / Credit Card";
                    lblGatewayTitle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Debit Card":
                    panelGateway.BackColor = System.Drawing.Color.FromArgb(40, 120, 70);
                    lblGatewayTitle.Text = "Debit Card Payment";
                    lblGatewayTitle.ForeColor = System.Drawing.Color.White;
                    break;
                default:
                    panelGateway.BackColor = System.Drawing.Color.Gray;
                    lblGatewayTitle.Text = "Cash Payment";
                    lblGatewayTitle.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }

        private void StartRedirect()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _countdown--;
            lblCountdown.Text = "Processing payment in " + _countdown + " seconds...";
            progressBar.Value = Math.Min(100, (5 - _countdown) * 20);

            if (_countdown <= 0)
            {
                _timer.Stop();
                ShowResult();
            }
        }

        private void ShowResult()
        {
            // Simulate successful payment
            lblCountdown.Text = "✔ Payment Successful!";
            lblCountdown.ForeColor = System.Drawing.Color.SeaGreen;
            lblCountdown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            progressBar.Value = 100;
            btnConfirm.Enabled = true;
            btnCancel.Enabled = false;
            PaymentSuccessful = true;

            // Update order status to Paid
            System.Data.SqlClient.SqlParameter[] p = {
                new System.Data.SqlClient.SqlParameter("@id", _orderID)
            };
            DBHelper.ExecuteNonQuery("UPDATE Orders SET PaymentStatus = 'Paid' WHERE OrderID = @id", p);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            PaymentSuccessful = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}