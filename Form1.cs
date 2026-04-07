using System;
using System.Drawing;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDownPaymentMode();
        }

        private void DownPaymentModeChanged(object sender, EventArgs e)
        {
            UpdateDownPaymentMode();
        }

        private void UpdateDownPaymentMode()
        {
            bool usePercent = rdoDownPercent.Checked;

            txtDownRate.Enabled = usePercent;
            lblDownRateText.Enabled = usePercent;

            txtDownAmount.Enabled = !usePercent;
            lblDownAmountText.Enabled = !usePercent;

            txtDownRate.BackColor = usePercent ? Color.White : Color.Gainsboro;
            txtDownAmount.BackColor = usePercent ? Color.Gainsboro : Color.White;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHousePrice.Text, out double housePrice) || housePrice <= 0)
            {
                MessageBox.Show("房屋總價必須是大於 0 的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHousePrice.Focus();
                return;
            }

            if (!double.TryParse(txtInterest.Text, out double annualRatePercent) || annualRatePercent < 0)
            {
                MessageBox.Show("年利率必須是大於或等於 0 的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInterest.Focus();
                return;
            }

            if (!int.TryParse(txtYears.Text, out int years) || years <= 0)
            {
                MessageBox.Show("貸款年限必須是大於 0 的整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYears.Focus();
                return;
            }

            if (!int.TryParse(txtGrace.Text, out int graceYears) || graceYears < 0)
            {
                MessageBox.Show("寬限期必須是大於或等於 0 的整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrace.Focus();
                return;
            }

            if (graceYears >= years)
            {
                MessageBox.Show("寬限期必須小於貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrace.Focus();
                return;
            }

            double downPayment;
            double downRatePercent = 0;

            if (rdoDownPercent.Checked)
            {
                if (!double.TryParse(txtDownRate.Text, out downRatePercent) || downRatePercent < 0 || downRatePercent >= 100)
                {
                    MessageBox.Show("自備款比例必須介於 0 到 100 之間，且不能等於 100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDownRate.Focus();
                    return;
                }

                downPayment = housePrice * (downRatePercent / 100.0);
            }
            else
            {
                if (!double.TryParse(txtDownAmount.Text, out downPayment) || downPayment < 0 || downPayment >= housePrice)
                {
                    MessageBox.Show("自備款金額必須大於或等於 0，且小於房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDownAmount.Focus();
                    return;
                }

                downRatePercent = downPayment / housePrice * 100.0;
            }

            double loanAmount = housePrice - downPayment;
            double annualRate = annualRatePercent / 100.0;
            double monthlyRate = annualRate / 12.0;

            int totalMonths = years * 12;
            int graceMonths = graceYears * 12;
            int repayMonths = totalMonths - graceMonths;

            if (loanAmount <= 0)
            {
                MessageBox.Show("貸款金額必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double monthlyPayment = 0;
            double graceMonthlyPayment = 0;
            double firstInterest = 0;
            double firstPrincipal = 0;
            double totalInterest = 0;
            double totalPayment = 0;

            if (monthlyRate == 0)
            {
                if (graceMonths > 0)
                {
                    graceMonthlyPayment = 0;
                    monthlyPayment = loanAmount / repayMonths;
                    firstInterest = 0;
                    firstPrincipal = 0;
                    totalPayment = monthlyPayment * repayMonths;
                    totalInterest = 0;
                }
                else
                {
                    monthlyPayment = loanAmount / totalMonths;
                    graceMonthlyPayment = 0;
                    firstInterest = 0;
                    firstPrincipal = monthlyPayment;
                    totalPayment = loanAmount;
                    totalInterest = 0;
                }
            }
            else
            {
                if (graceMonths > 0)
                {
                    graceMonthlyPayment = loanAmount * monthlyRate;
                    monthlyPayment = CalculateAmortizedPayment(loanAmount, monthlyRate, repayMonths);

                    firstInterest = graceMonthlyPayment;
                    firstPrincipal = 0;

                    totalPayment = (graceMonthlyPayment * graceMonths) + (monthlyPayment * repayMonths);
                    totalInterest = totalPayment - loanAmount;
                }
                else
                {
                    monthlyPayment = CalculateAmortizedPayment(loanAmount, monthlyRate, totalMonths);

                    firstInterest = loanAmount * monthlyRate;
                    firstPrincipal = monthlyPayment - firstInterest;

                    totalPayment = monthlyPayment * totalMonths;
                    totalInterest = totalPayment - loanAmount;
                }
            }

            lblLoan.Text = FormatMoney(loanAmount);
            lblMonthly.Text = FormatMoney(monthlyPayment);
            lblGraceMonthly.Text = graceMonths > 0 ? FormatMoney(graceMonthlyPayment) : "無";
            lblFirstInterest.Text = FormatMoney(firstInterest);
            lblFirstPrincipal.Text = FormatMoney(firstPrincipal);
            lblTotalInt.Text = FormatMoney(totalInterest);
            lblTotalPay.Text = FormatMoney(totalPayment);
        }

        private double CalculateAmortizedPayment(double principal, double monthlyRate, int months)
        {
            double factor = Math.Pow(1 + monthlyRate, months);
            return principal * (monthlyRate * factor) / (factor - 1);
        }

        private string FormatMoney(double value)
        {
            return "NT$ " + value.ToString("N2");
        }
    }
}