namespace 個人房貸試算器
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ===== 控制項宣告（你缺的就在這🔥）=====
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownRate;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtGrace;

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblTotalInt;
        private System.Windows.Forms.Label lblTotalPay;

        private System.Windows.Forms.Button btnCalc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // ===== Form =====
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Text = "房貸試算器";

            // ===== TextBox =====
            txtHousePrice = new System.Windows.Forms.TextBox();
            txtDownRate = new System.Windows.Forms.TextBox();
            txtInterest = new System.Windows.Forms.TextBox();
            txtYears = new System.Windows.Forms.TextBox();
            txtGrace = new System.Windows.Forms.TextBox();

            txtHousePrice.Location = new System.Drawing.Point(200, 100);
            txtDownRate.Location = new System.Drawing.Point(200, 130);
            txtInterest.Location = new System.Drawing.Point(200, 160);
            txtYears.Location = new System.Drawing.Point(200, 190);
            txtGrace.Location = new System.Drawing.Point(200, 220);

            txtHousePrice.Text = "10000000";
            txtDownRate.Text = "20";
            txtInterest.Text = "2";
            txtYears.Text = "30";
            txtGrace.Text = "0";

            // ===== Button =====
            btnCalc = new System.Windows.Forms.Button();
            btnCalc.Text = "開始計算";
            btnCalc.Location = new System.Drawing.Point(200, 260);
            btnCalc.Size = new System.Drawing.Size(120, 40);
            btnCalc.Click += new System.EventHandler(this.btnCalc_Click);

            // ===== Labels（結果）=====
            lblLoan = new System.Windows.Forms.Label();
            lblMonthly = new System.Windows.Forms.Label();
            lblTotalInt = new System.Windows.Forms.Label();
            lblTotalPay = new System.Windows.Forms.Label();

            lblLoan.Location = new System.Drawing.Point(200, 320);
            lblMonthly.Location = new System.Drawing.Point(200, 350);
            lblTotalInt.Location = new System.Drawing.Point(200, 380);
            lblTotalPay.Location = new System.Drawing.Point(200, 410);

            lblLoan.Text = "0";
            lblMonthly.Text = "0";
            lblTotalInt.Text = "0";
            lblTotalPay.Text = "0";

            // ===== 加入控制項 =====
            this.Controls.Add(txtHousePrice);
            this.Controls.Add(txtDownRate);
            this.Controls.Add(txtInterest);
            this.Controls.Add(txtYears);
            this.Controls.Add(txtGrace);

            this.Controls.Add(btnCalc);

            this.Controls.Add(lblLoan);
            this.Controls.Add(lblMonthly);
            this.Controls.Add(lblTotalInt);
            this.Controls.Add(lblTotalPay);

            this.ResumeLayout(false);
        }
    }
}