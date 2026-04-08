namespace 個人房貸試算器
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelResult;

        private System.Windows.Forms.Label lblHousePriceText;
        private System.Windows.Forms.Label lblDownModeText;
        private System.Windows.Forms.RadioButton rdoDownPercent;
        private System.Windows.Forms.RadioButton rdoDownAmount;
        private System.Windows.Forms.Label lblDownRateText;
        private System.Windows.Forms.Label lblDownAmountText;
        private System.Windows.Forms.Label lblInterestText;
        private System.Windows.Forms.Label lblYearsText;
        private System.Windows.Forms.Label lblGraceText;

        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownRate;
        private System.Windows.Forms.TextBox txtDownAmount;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtGrace;

        private System.Windows.Forms.Button btnCalc;

        private System.Windows.Forms.Label lblLoanText;
        private System.Windows.Forms.Label lblMonthlyText;
        private System.Windows.Forms.Label lblGraceMonthlyText;
        private System.Windows.Forms.Label lblFirstInterestText;
        private System.Windows.Forms.Label lblFirstPrincipalText;
        private System.Windows.Forms.Label lblTotalIntText;
        private System.Windows.Forms.Label lblTotalPayText;

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblGraceMonthly;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblTotalInt;
        private System.Windows.Forms.Label lblTotalPay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.panelInput = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();

            this.lblHousePriceText = new System.Windows.Forms.Label();
            this.lblDownModeText = new System.Windows.Forms.Label();
            this.rdoDownPercent = new System.Windows.Forms.RadioButton();
            this.rdoDownAmount = new System.Windows.Forms.RadioButton();
            this.lblDownRateText = new System.Windows.Forms.Label();
            this.lblDownAmountText = new System.Windows.Forms.Label();
            this.lblInterestText = new System.Windows.Forms.Label();
            this.lblYearsText = new System.Windows.Forms.Label();
            this.lblGraceText = new System.Windows.Forms.Label();

            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownRate = new System.Windows.Forms.TextBox();
            this.txtDownAmount = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtGrace = new System.Windows.Forms.TextBox();

            this.btnCalc = new System.Windows.Forms.Button();

            this.lblLoanText = new System.Windows.Forms.Label();
            this.lblMonthlyText = new System.Windows.Forms.Label();
            this.lblGraceMonthlyText = new System.Windows.Forms.Label();
            this.lblFirstInterestText = new System.Windows.Forms.Label();
            this.lblFirstPrincipalText = new System.Windows.Forms.Label();
            this.lblTotalIntText = new System.Windows.Forms.Label();
            this.lblTotalPayText = new System.Windows.Forms.Label();

            this.lblLoan = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblGraceMonthly = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInt = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();

            this.panelInput.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 249, 224);
            this.ClientSize = new System.Drawing.Size(1180, 560);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblTitle.Location = new System.Drawing.Point(430, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "個人房貸試算器";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(140, 110, 35);
            this.lblSubTitle.Location = new System.Drawing.Point(332, 67);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(464, 18);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "";

            // panelInput
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.lblHousePriceText);
            this.panelInput.Controls.Add(this.lblDownModeText);
            this.panelInput.Controls.Add(this.rdoDownPercent);
            this.panelInput.Controls.Add(this.rdoDownAmount);
            this.panelInput.Controls.Add(this.lblDownRateText);
            this.panelInput.Controls.Add(this.lblDownAmountText);
            this.panelInput.Controls.Add(this.lblInterestText);
            this.panelInput.Controls.Add(this.lblYearsText);
            this.panelInput.Controls.Add(this.lblGraceText);
            this.panelInput.Controls.Add(this.txtHousePrice);
            this.panelInput.Controls.Add(this.txtDownRate);
            this.panelInput.Controls.Add(this.txtDownAmount);
            this.panelInput.Controls.Add(this.txtInterest);
            this.panelInput.Controls.Add(this.txtYears);
            this.panelInput.Controls.Add(this.txtGrace);
            this.panelInput.Location = new System.Drawing.Point(40, 110);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(520, 400);
            this.panelInput.TabIndex = 2;

            // panelResult
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.lblLoanText);
            this.panelResult.Controls.Add(this.lblMonthlyText);
            this.panelResult.Controls.Add(this.lblGraceMonthlyText);
            this.panelResult.Controls.Add(this.lblFirstInterestText);
            this.panelResult.Controls.Add(this.lblFirstPrincipalText);
            this.panelResult.Controls.Add(this.lblTotalIntText);
            this.panelResult.Controls.Add(this.lblTotalPayText);
            this.panelResult.Controls.Add(this.lblLoan);
            this.panelResult.Controls.Add(this.lblMonthly);
            this.panelResult.Controls.Add(this.lblGraceMonthly);
            this.panelResult.Controls.Add(this.lblFirstInterest);
            this.panelResult.Controls.Add(this.lblFirstPrincipal);
            this.panelResult.Controls.Add(this.lblTotalInt);
            this.panelResult.Controls.Add(this.lblTotalPay);
            this.panelResult.Location = new System.Drawing.Point(600, 110);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(540, 400);
            this.panelResult.TabIndex = 3;

            // lblHousePriceText
            this.lblHousePriceText.AutoSize = true;
            this.lblHousePriceText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHousePriceText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblHousePriceText.Location = new System.Drawing.Point(28, 28);
            this.lblHousePriceText.Name = "lblHousePriceText";
            this.lblHousePriceText.Size = new System.Drawing.Size(102, 18);
            this.lblHousePriceText.TabIndex = 0;
            this.lblHousePriceText.Text = "房屋總價（元）";

            // lblDownModeText
            this.lblDownModeText.AutoSize = true;
            this.lblDownModeText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDownModeText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblDownModeText.Location = new System.Drawing.Point(28, 78);
            this.lblDownModeText.Name = "lblDownModeText";
            this.lblDownModeText.Size = new System.Drawing.Size(116, 18);
            this.lblDownModeText.TabIndex = 1;
            this.lblDownModeText.Text = "自備款輸入方式";

            // rdoDownPercent
            this.rdoDownPercent.AutoSize = true;
            this.rdoDownPercent.Checked = true;
            this.rdoDownPercent.ForeColor = System.Drawing.Color.FromArgb(90, 70, 20);
            this.rdoDownPercent.Location = new System.Drawing.Point(190, 76);
            this.rdoDownPercent.Name = "rdoDownPercent";
            this.rdoDownPercent.Size = new System.Drawing.Size(85, 22);
            this.rdoDownPercent.TabIndex = 2;
            this.rdoDownPercent.TabStop = true;
            this.rdoDownPercent.Text = "比例（%）";
            this.rdoDownPercent.UseVisualStyleBackColor = true;
            this.rdoDownPercent.CheckedChanged += new System.EventHandler(this.DownPaymentModeChanged);

            // rdoDownAmount
            this.rdoDownAmount.AutoSize = true;
            this.rdoDownAmount.ForeColor = System.Drawing.Color.FromArgb(90, 70, 20);
            this.rdoDownAmount.Location = new System.Drawing.Point(305, 76);
            this.rdoDownAmount.Name = "rdoDownAmount";
            this.rdoDownAmount.Size = new System.Drawing.Size(91, 22);
            this.rdoDownAmount.TabIndex = 3;
            this.rdoDownAmount.Text = "金額（元）";
            this.rdoDownAmount.UseVisualStyleBackColor = true;
            this.rdoDownAmount.CheckedChanged += new System.EventHandler(this.DownPaymentModeChanged);

            // lblDownRateText
            this.lblDownRateText.AutoSize = true;
            this.lblDownRateText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDownRateText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblDownRateText.Location = new System.Drawing.Point(28, 130);
            this.lblDownRateText.Name = "lblDownRateText";
            this.lblDownRateText.Size = new System.Drawing.Size(116, 18);
            this.lblDownRateText.TabIndex = 4;
            this.lblDownRateText.Text = "自備款比例（%）";

            // lblDownAmountText
            this.lblDownAmountText.AutoSize = true;
            this.lblDownAmountText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDownAmountText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblDownAmountText.Location = new System.Drawing.Point(28, 180);
            this.lblDownAmountText.Name = "lblDownAmountText";
            this.lblDownAmountText.Size = new System.Drawing.Size(102, 18);
            this.lblDownAmountText.TabIndex = 5;
            this.lblDownAmountText.Text = "自備款金額（元）";

            // lblInterestText
            this.lblInterestText.AutoSize = true;
            this.lblInterestText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInterestText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblInterestText.Location = new System.Drawing.Point(28, 230);
            this.lblInterestText.Name = "lblInterestText";
            this.lblInterestText.Size = new System.Drawing.Size(88, 18);
            this.lblInterestText.TabIndex = 6;
            this.lblInterestText.Text = "年利率（%）";

            // lblYearsText
            this.lblYearsText.AutoSize = true;
            this.lblYearsText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYearsText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblYearsText.Location = new System.Drawing.Point(28, 280);
            this.lblYearsText.Name = "lblYearsText";
            this.lblYearsText.Size = new System.Drawing.Size(88, 18);
            this.lblYearsText.TabIndex = 7;
            this.lblYearsText.Text = "貸款年限（年）";

            // lblGraceText
            this.lblGraceText.AutoSize = true;
            this.lblGraceText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraceText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblGraceText.Location = new System.Drawing.Point(28, 330);
            this.lblGraceText.Name = "lblGraceText";
            this.lblGraceText.Size = new System.Drawing.Size(138, 18);
            this.lblGraceText.TabIndex = 8;
            this.lblGraceText.Text = "寬限期（年，可填 0）";

            // txtHousePrice
            this.txtHousePrice.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtHousePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHousePrice.Location = new System.Drawing.Point(190, 24);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(280, 25);
            this.txtHousePrice.TabIndex = 9;
            this.txtHousePrice.Text = "10000000";

            // txtDownRate
            this.txtDownRate.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtDownRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownRate.Location = new System.Drawing.Point(190, 126);
            this.txtDownRate.Name = "txtDownRate";
            this.txtDownRate.Size = new System.Drawing.Size(280, 25);
            this.txtDownRate.TabIndex = 10;
            this.txtDownRate.Text = "20";

            // txtDownAmount
            this.txtDownAmount.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtDownAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownAmount.Location = new System.Drawing.Point(190, 176);
            this.txtDownAmount.Name = "txtDownAmount";
            this.txtDownAmount.Size = new System.Drawing.Size(280, 25);
            this.txtDownAmount.TabIndex = 11;
            this.txtDownAmount.Text = "2000000";

            // txtInterest
            this.txtInterest.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterest.Location = new System.Drawing.Point(190, 226);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(280, 25);
            this.txtInterest.TabIndex = 12;
            this.txtInterest.Text = "2.15";

            // txtYears
            this.txtYears.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYears.Location = new System.Drawing.Point(190, 276);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(280, 25);
            this.txtYears.TabIndex = 13;
            this.txtYears.Text = "30";

            // txtGrace
            this.txtGrace.BackColor = System.Drawing.Color.FromArgb(255, 252, 242);
            this.txtGrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrace.Location = new System.Drawing.Point(190, 326);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(280, 25);
            this.txtGrace.TabIndex = 14;
            this.txtGrace.Text = "0";

            // btnCalc
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(244, 196, 48);
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(90, 70, 20);
            this.btnCalc.Location = new System.Drawing.Point(190, 365);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(280, 42);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "開始計算";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            this.panelInput.Controls.Add(this.btnCalc);

            // lblLoanText
            this.lblLoanText.AutoSize = true;
            this.lblLoanText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoanText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblLoanText.Location = new System.Drawing.Point(30, 30);
            this.lblLoanText.Name = "lblLoanText";
            this.lblLoanText.Size = new System.Drawing.Size(102, 18);
            this.lblLoanText.TabIndex = 0;
            this.lblLoanText.Text = "貸款總金額：";

            // lblMonthlyText
            this.lblMonthlyText.AutoSize = true;
            this.lblMonthlyText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblMonthlyText.Location = new System.Drawing.Point(30, 78);
            this.lblMonthlyText.Name = "lblMonthlyText";
            this.lblMonthlyText.Size = new System.Drawing.Size(165, 18);
            this.lblMonthlyText.TabIndex = 1;
            this.lblMonthlyText.Text = "每月應繳金額（本 + 息）：";

            // lblGraceMonthlyText
            this.lblGraceMonthlyText.AutoSize = true;
            this.lblGraceMonthlyText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraceMonthlyText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblGraceMonthlyText.Location = new System.Drawing.Point(30, 126);
            this.lblGraceMonthlyText.Name = "lblGraceMonthlyText";
            this.lblGraceMonthlyText.Size = new System.Drawing.Size(179, 18);
            this.lblGraceMonthlyText.TabIndex = 2;
            this.lblGraceMonthlyText.Text = "寬限期每月應繳（僅利息）：";

            // lblFirstInterestText
            this.lblFirstInterestText.AutoSize = true;
            this.lblFirstInterestText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstInterestText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblFirstInterestText.Location = new System.Drawing.Point(30, 174);
            this.lblFirstInterestText.Name = "lblFirstInterestText";
            this.lblFirstInterestText.Size = new System.Drawing.Size(74, 18);
            this.lblFirstInterestText.TabIndex = 3;
            this.lblFirstInterestText.Text = "首期利息：";

            // lblFirstPrincipalText
            this.lblFirstPrincipalText.AutoSize = true;
            this.lblFirstPrincipalText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstPrincipalText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblFirstPrincipalText.Location = new System.Drawing.Point(30, 222);
            this.lblFirstPrincipalText.Name = "lblFirstPrincipalText";
            this.lblFirstPrincipalText.Size = new System.Drawing.Size(74, 18);
            this.lblFirstPrincipalText.TabIndex = 4;
            this.lblFirstPrincipalText.Text = "首期本金：";

            // lblTotalIntText
            this.lblTotalIntText.AutoSize = true;
            this.lblTotalIntText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalIntText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblTotalIntText.Location = new System.Drawing.Point(30, 270);
            this.lblTotalIntText.Name = "lblTotalIntText";
            this.lblTotalIntText.Size = new System.Drawing.Size(88, 18);
            this.lblTotalIntText.TabIndex = 5;
            this.lblTotalIntText.Text = "總利息支出：";

            // lblTotalPayText
            this.lblTotalPayText.AutoSize = true;
            this.lblTotalPayText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayText.ForeColor = System.Drawing.Color.FromArgb(120, 90, 20);
            this.lblTotalPayText.Location = new System.Drawing.Point(30, 318);
            this.lblTotalPayText.Name = "lblTotalPayText";
            this.lblTotalPayText.Size = new System.Drawing.Size(88, 18);
            this.lblTotalPayText.TabIndex = 6;
            this.lblTotalPayText.Text = "總還款金額：";

            // lblLoan
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLoan.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblLoan.Location = new System.Drawing.Point(250, 30);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(71, 19);
            this.lblLoan.TabIndex = 7;
            this.lblLoan.Text = "NT$ 0.00";

            // lblMonthly
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblMonthly.Location = new System.Drawing.Point(250, 78);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(71, 19);
            this.lblMonthly.TabIndex = 8;
            this.lblMonthly.Text = "NT$ 0.00";

            // lblGraceMonthly
            this.lblGraceMonthly.AutoSize = true;
            this.lblGraceMonthly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGraceMonthly.ForeColor = System.Drawing.Color.FromArgb(180, 120, 0);
            this.lblGraceMonthly.Location = new System.Drawing.Point(250, 126);
            this.lblGraceMonthly.Name = "lblGraceMonthly";
            this.lblGraceMonthly.Size = new System.Drawing.Size(27, 19);
            this.lblGraceMonthly.TabIndex = 9;
            this.lblGraceMonthly.Text = "無";

            // lblFirstInterest
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstInterest.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblFirstInterest.Location = new System.Drawing.Point(250, 174);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(71, 19);
            this.lblFirstInterest.TabIndex = 10;
            this.lblFirstInterest.Text = "NT$ 0.00";

            // lblFirstPrincipal
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstPrincipal.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblFirstPrincipal.Location = new System.Drawing.Point(250, 222);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(71, 19);
            this.lblFirstPrincipal.TabIndex = 11;
            this.lblFirstPrincipal.Text = "NT$ 0.00";

            // lblTotalInt
            this.lblTotalInt.AutoSize = true;
            this.lblTotalInt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalInt.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblTotalInt.Location = new System.Drawing.Point(250, 270);
            this.lblTotalInt.Name = "lblTotalInt";
            this.lblTotalInt.Size = new System.Drawing.Size(71, 19);
            this.lblTotalInt.TabIndex = 12;
            this.lblTotalInt.Text = "NT$ 0.00";

            // lblTotalPay
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPay.ForeColor = System.Drawing.Color.FromArgb(90, 70, 20);
            this.lblTotalPay.Location = new System.Drawing.Point(250, 318);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(71, 19);
            this.lblTotalPay.TabIndex = 13;
            this.lblTotalPay.Text = "NT$ 0.00";

            // Add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelResult);

            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}