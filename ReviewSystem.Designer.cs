namespace StockPro
{
    partial class ReviewSystem
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblAvgRating = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "⭐ Supplier Review System";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);

            // Panel
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(20, 55);
            this.panelForm.Size = new System.Drawing.Size(360, 320);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // Supplier
            this.lblSupplier.Text = "Select Supplier:";
            this.lblSupplier.Location = new System.Drawing.Point(10, 15);
            this.lblSupplier.Size = new System.Drawing.Size(120, 20);

            this.cmbSupplier.Location = new System.Drawing.Point(10, 38);
            this.cmbSupplier.Size = new System.Drawing.Size(335, 23);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);

            // Avg Rating
            this.lblAvgRating.Text = "Avg Rating: --";
            this.lblAvgRating.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgRating.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAvgRating.Location = new System.Drawing.Point(10, 68);
            this.lblAvgRating.Size = new System.Drawing.Size(200, 20);

            // Rating
            this.lblRating.Text = "Rating (1-5):";
            this.lblRating.Location = new System.Drawing.Point(10, 100);
            this.lblRating.Size = new System.Drawing.Size(100, 20);

            this.nudRating.Location = new System.Drawing.Point(10, 123);
            this.nudRating.Size = new System.Drawing.Size(60, 23);
            this.nudRating.Name = "nudRating";
            this.nudRating.Minimum = 1;
            this.nudRating.Maximum = 5;
            this.nudRating.Value = 5;

            // Comments
            this.lblComments.Text = "Comments:";
            this.lblComments.Location = new System.Drawing.Point(10, 158);
            this.lblComments.Size = new System.Drawing.Size(100, 20);

            this.txtComments.Location = new System.Drawing.Point(10, 180);
            this.txtComments.Size = new System.Drawing.Size(335, 80);
            this.txtComments.Name = "txtComments";
            this.txtComments.Multiline = true;

            // Submit Button
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(10, 270);
            this.btnSubmit.Size = new System.Drawing.Size(150, 35);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.panelForm.Controls.Add(this.lblSupplier);
            this.panelForm.Controls.Add(this.cmbSupplier);
            this.panelForm.Controls.Add(this.lblAvgRating);
            this.panelForm.Controls.Add(this.lblRating);
            this.panelForm.Controls.Add(this.nudRating);
            this.panelForm.Controls.Add(this.lblComments);
            this.panelForm.Controls.Add(this.txtComments);
            this.panelForm.Controls.Add(this.btnSubmit);

            // DataGridView
            this.dgvReviews.Location = new System.Drawing.Point(20, 390);
            this.dgvReviews.Size = new System.Drawing.Size(860, 280);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;

            // Delete & Back
            this.btnDelete.Text = "Delete Review";
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(20, 685);
            this.btnDelete.Size = new System.Drawing.Size(130, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(160, 685);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Text = "StockPro - Supplier Review System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblAvgRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Panel panelForm;
    }
}