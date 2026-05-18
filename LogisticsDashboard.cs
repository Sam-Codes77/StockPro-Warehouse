using System.Windows.Forms;

namespace StockPro
{
    public partial class LogisticsDashboard : Form
    {
        public LogisticsDashboard()
        {
            InitializeComponent();
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}