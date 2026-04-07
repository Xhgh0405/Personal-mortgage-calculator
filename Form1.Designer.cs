namespace 個人房貸試算器
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownRate;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtGrace;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblHousePriceText;
        private System.Windows.Forms.Label lblDownRateText;
        private System.Windows.Forms.Label lblInterestText;
        private System.Windows.Forms.Label lblYearsText;
        private System.Windows.Forms.Label lblGraceText;

        private System.Windows.Forms.Label lblLoanText;
        private System.Windows.Forms.Label lblMonthlyText;
        private System.Windows.Forms.Label lblTotalIntText;
        private System.Windows.Forms.Label lblTotalPayText;

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblTotalInt;
        private System.Windows.Forms.Label lblTotalPay;

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.lblHousePriceText = new System.Windows.Forms.Label();
            this.lblDownRateText = new System.Windows.Forms.Label();
            this.lblInterestText = new System.Windows.Forms.Label();
            this.lblYearsText = new System.Windows.Forms.Label();
            this.lblGraceText = new System.Windows.Forms.Label();

            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownRate = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtGrace = new System.Windows.Forms.TextBox();

            this.btnCalc = new System.Windows.Forms.Button();

            this.lblLoanText = new System.Windows.Forms.Label();
            this.lblMonthlyText = new System.Windows.Forms.Label();
            this.lblTotalIntText = new System.Windows.Forms.Label();
            this.lblTotalPayText = new System.Windows.Forms.Label();

            this.lblLoan = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblTotalInt = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房貸試算器";

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(250, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "個人房貸試算器";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSubTitle.Location = new System.Drawing.Point(230, 68);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(248, 18);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "輸入房價、頭期款、利率與年限後開始試算";

            // panelInput
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Location = new System.Drawing.Point(55, 110);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(610, 230);
            this.panelInput.TabIndex = 2;

            // 輸入標籤
            this.lblHousePriceText.AutoSize = true;
            this.lblHousePriceText.Location = new System.Drawing.Point(40, 25);
            this.lblHousePriceText.Name = "lblHousePriceText";
            this.lblHousePriceText.Size = new System.Drawing.Size(73, 18);
            this.lblHousePriceText.TabIndex = 0;
            this.lblHousePriceText.Text = "房屋總價：";

            this.lblDownRateText.AutoSize = true;
            this.lblDownRateText.Location = new System.Drawing.Point(40, 60);
            this.lblDownRateText.Name = "lblDownRateText";
            this.lblDownRateText.Size = new System.Drawing.Size(105, 18);
            this.lblDownRateText.TabIndex = 1;
            this.lblDownRateText.Text = "頭期款比例(%)：";

            this.lblInterestText.AutoSize = true;
            this.lblInterestText.Location = new System.Drawing.Point(40, 95);
            this.lblInterestText.Name = "lblInterestText";
            this.lblInterestText.Size = new System.Drawing.Size(78, 18);
            this.lblInterestText.TabIndex = 2;
            this.lblInterestText.Text = "年利率(%)：";

            this.lblYearsText.AutoSize = true;
            this.lblYearsText.Location = new System.Drawing.Point(40, 130);
            this.lblYearsText.Name = "lblYearsText";
            this.lblYearsText.Size = new System.Drawing.Size(73, 18);
            this.lblYearsText.TabIndex = 3;
            this.lblYearsText.Text = "貸款年限：";

            this.lblGraceText.AutoSize = true;
            this.lblGraceText.Location = new System.Drawing.Point(40, 165);
            this.lblGraceText.Name = "lblGraceText";
            this.lblGraceText.Size = new System.Drawing.Size(78, 18);
            this.lblGraceText.TabIndex = 4;
            this.lblGraceText.Text = "寬限期(年)：";

            // TextBox
            this.txtHousePrice.Location = new System.Drawing.Point(190, 22);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(320, 25);
            this.txtHousePrice.TabIndex = 5;
            this.txtHousePrice.Text = "10000000";

            this.txtDownRate.Location = new System.Drawing.Point(190, 57);
            this.txtDownRate.Name = "txtDownRate";
            this.txtDownRate.Size = new System.Drawing.Size(320, 25);
            this.txtDownRate.TabIndex = 6;
            this.txtDownRate.Text = "20";

            this.txtInterest.Location = new System.Drawing.Point(190, 92);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(320, 25);
            this.txtInterest.TabIndex = 7;
            this.txtInterest.Text = "2";

            this.txtYears.Location = new System.Drawing.Point(190, 127);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(320, 25);
            this.txtYears.TabIndex = 8;
            this.txtYears.Text = "30";

            this.txtGrace.Location = new System.Drawing.Point(190, 162);
            this.txtGrace.Name = "txtGrace";
            this.txtGrace.Size = new System.Drawing.Size(320, 25);
            this.txtGrace.TabIndex = 9;
            this.txtGrace.Text = "0";

            // Button
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(230, 355);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(250, 48);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "開始計算";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);

            // panelResult
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Location = new System.Drawing.Point(55, 425);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(610, 150);
            this.panelResult.TabIndex = 4;

            // 結果標題
            this.lblLoanText.AutoSize = true;
            this.lblLoanText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoanText.Location = new System.Drawing.Point(40, 20);
            this.lblLoanText.Name = "lblLoanText";
            this.lblLoanText.Size = new System.Drawing.Size(73, 18);
            this.lblLoanText.TabIndex = 0;
            this.lblLoanText.Text = "貸款金額：";

            this.lblMonthlyText.AutoSize = true;
            this.lblMonthlyText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyText.Location = new System.Drawing.Point(40, 50);
            this.lblMonthlyText.Name = "lblMonthlyText";
            this.lblMonthlyText.Size = new System.Drawing.Size(73, 18);
            this.lblMonthlyText.TabIndex = 1;
            this.lblMonthlyText.Text = "每月應繳：";

            this.lblTotalIntText.AutoSize = true;
            this.lblTotalIntText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalIntText.Location = new System.Drawing.Point(40, 80);
            this.lblTotalIntText.Name = "lblTotalIntText";
            this.lblTotalIntText.Size = new System.Drawing.Size(59, 18);
            this.lblTotalIntText.TabIndex = 2;
            this.lblTotalIntText.Text = "總利息：";

            this.lblTotalPayText.AutoSize = true;
            this.lblTotalPayText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPayText.Location = new System.Drawing.Point(40, 110);
            this.lblTotalPayText.Name = "lblTotalPayText";
            this.lblTotalPayText.Size = new System.Drawing.Size(87, 18);
            this.lblTotalPayText.TabIndex = 3;
            this.lblTotalPayText.Text = "總還款金額：";

            // 結果值
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblLoan.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblLoan.Location = new System.Drawing.Point(180, 20);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(15, 18);
            this.lblLoan.TabIndex = 4;
            this.lblLoan.Text = "0";

            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblMonthly.Location = new System.Drawing.Point(180, 50);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(15, 18);
            this.lblMonthly.TabIndex = 5;
            this.lblMonthly.Text = "0";

            this.lblTotalInt.AutoSize = true;
            this.lblTotalInt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblTotalInt.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblTotalInt.Location = new System.Drawing.Point(180, 80);
            this.lblTotalInt.Name = "lblTotalInt";
            this.lblTotalInt.Size = new System.Drawing.Size(15, 18);
            this.lblTotalInt.TabIndex = 6;
            this.lblTotalInt.Text = "0";

            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.lblTotalPay.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblTotalPay.Location = new System.Drawing.Point(180, 110);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(15, 18);
            this.lblTotalPay.TabIndex = 7;
            this.lblTotalPay.Text = "0";

            // 加入 panelInput
            this.panelInput.Controls.Add(this.lblHousePriceText);
            this.panelInput.Controls.Add(this.lblDownRateText);
            this.panelInput.Controls.Add(this.lblInterestText);
            this.panelInput.Controls.Add(this.lblYearsText);
            this.panelInput.Controls.Add(this.lblGraceText);
            this.panelInput.Controls.Add(this.txtHousePrice);
            this.panelInput.Controls.Add(this.txtDownRate);
            this.panelInput.Controls.Add(this.txtInterest);
            this.panelInput.Controls.Add(this.txtYears);
            this.panelInput.Controls.Add(this.txtGrace);

            // 加入 panelResult
            this.panelResult.Controls.Add(this.lblLoanText);
            this.panelResult.Controls.Add(this.lblMonthlyText);
            this.panelResult.Controls.Add(this.lblTotalIntText);
            this.panelResult.Controls.Add(this.lblTotalPayText);
            this.panelResult.Controls.Add(this.lblLoan);
            this.panelResult.Controls.Add(this.lblMonthly);
            this.panelResult.Controls.Add(this.lblTotalInt);
            this.panelResult.Controls.Add(this.lblTotalPay);

            // 加入 Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.panelResult);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}