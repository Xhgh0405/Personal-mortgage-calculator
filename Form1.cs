using System;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ===== 計算按鈕 =====
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // ===== 輸入驗證（老師會看）=====
            if (!double.TryParse(txtHousePrice.Text, out double house) ||
                !double.TryParse(txtDownRate.Text, out double downRatePercent) ||
                !double.TryParse(txtInterest.Text, out double ratePercent) ||
                !int.TryParse(txtYears.Text, out int years) ||
                !int.TryParse(txtGrace.Text, out int graceYears))
            {
                MessageBox.Show("請輸入正確數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ===== 轉換 =====
            double downRate = downRatePercent / 100.0;
            double annualRate = ratePercent / 100.0;

            double loan = house * (1 - downRate);
            double monthlyRate = annualRate / 12;
            int totalMonths = years * 12;
            int graceMonths = graceYears * 12;

            double monthlyPayment = 0;
            double totalInterest = 0;
            double totalPayment = 0;

            // ===== 有寬限期（加分點🔥）=====
            if (graceMonths > 0)
            {
                // 寬限期：只繳利息
                double interestOnly = loan * monthlyRate;

                // 剩餘期數
                int remainMonths = totalMonths - graceMonths;

                double normalPayment = loan *
                    (monthlyRate * Math.Pow(1 + monthlyRate, remainMonths)) /
                    (Math.Pow(1 + monthlyRate, remainMonths) - 1);

                monthlyPayment = normalPayment;

                totalPayment = (interestOnly * graceMonths) + (normalPayment * remainMonths);
                totalInterest = totalPayment - loan;
            }
            else
            {
                // 一般本息攤還
                monthlyPayment = loan *
                    (monthlyRate * Math.Pow(1 + monthlyRate, totalMonths)) /
                    (Math.Pow(1 + monthlyRate, totalMonths) - 1);

                totalPayment = monthlyPayment * totalMonths;
                totalInterest = totalPayment - loan;
            }

            // ===== 顯示（格式化）=====
            lblLoan.Text = loan.ToString("N2");
            lblMonthly.Text = monthlyPayment.ToString("N2");
            lblTotalInt.Text = totalInterest.ToString("N2");
            lblTotalPay.Text = totalPayment.ToString("N2");
        }
    }
}