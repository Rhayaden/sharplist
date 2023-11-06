using Sharplist.Shows;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Sharplist
{
    public partial class Payment : Form
    {
        private readonly IDatabaseOperations _db;
        private readonly INotifier _notifier;
        private readonly string _userEmail;
        private decimal _userBalance;
        const string freeTrial = "Free";
        const string monthlyPlan = "Monthly";
        const string annualPlan = "Annual";
        const decimal monthlyPayment = 10m;
        const decimal yearlyPayment = 90m;
        public Payment(string userEmail, decimal userBalance, IDatabaseOperations db, INotifier notifier)
        {
            _userEmail = userEmail;
            _userBalance = userBalance;
            _db = db;
            _notifier = notifier;
            InitializeComponent();
            try
            {
                if (_db.CheckIfFreeTrialUsed(userEmail))
                {
                    FreeTrialButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            BalanceInfoLabel.Text = $"Your balance is: $ {_userBalance}";
            if (_userBalance < monthlyPayment)
            {
                MonthlyPlanButton.Enabled = false;
                AnnualPlanButton.Enabled = false;
            }
            else if (_userBalance > monthlyPayment && _userBalance < yearlyPayment)
            {
                AnnualPlanButton.Enabled = false;
            }
        }
        private void MoveToWatchList(string plan, DateTime startDate, DateTime endDate)
        {
            IShowsRegister showsRegister = new ShowsRegister();
            Watchlist watchlist = new Watchlist(
                _userEmail, 
                _userBalance, 
                showsRegister, 
                new WatchListsRepository(showsRegister, new SqlServerConnection()), 
                plan, 
                startDate, 
                endDate,
                new DatabaseOperations(new SqlServerConnection()));
            watchlist.Show();
            this.Hide();
        }
        private void SendEmail(string email, string plan, DateTime startDate, DateTime endDate)
        {
            string subject = "Your subscription information";
            List<string> messageList = new List<string>() {
            "Thank you for your purchase.",
                $"Your {plan.ToLower()} plan started in { startDate.Date.ToString("dd/M/yyyy")} and will end in { endDate.Date.ToString("dd/M/yyyy")}",
                "Stay Sharp o/"
            };
            string message = string.Join(Environment.NewLine, messageList);
            _notifier.Send(email, subject, message);
        }
        private void UpdateButtonsAccordingToBalance()
        {
            if (_userBalance >= monthlyPayment && _userBalance < yearlyPayment)
            {
                MonthlyPlanButton.Enabled = true;
            }
            else if (_userBalance >= yearlyPayment)
            {
                MonthlyPlanButton.Enabled = true;
                AnnualPlanButton.Enabled = true;
            }
        }
        private void PaymentPlanner(string plan, int time)
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddMonths(time);
            try
            {
                Cursor = Cursors.WaitCursor;
                FreeTrialButton.Enabled = false;
                MonthlyPlanButton.Enabled = false;
                AnnualPlanButton.Enabled = false;
                _db.UpdatePlan(plan, startDate, endDate, _userEmail);
                SendEmail(_userEmail, plan, startDate, endDate);
                Cursor = Cursors.Default;
                UpdateButtonsAccordingToBalance();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
            MoveToWatchList(plan, startDate, endDate);
        }
        private void BalanceCalculator(decimal plan)
        {
            if ( _userBalance < plan)
                {
                MessageBox.Show("Not enough balance to purchase any plan");
                return;
                }
            _userBalance -= plan;
            try
            {
                Cursor = Cursors.WaitCursor;
                AddBalanceButton.Enabled = false;
                _db.UpdateBalance(_userBalance, _userEmail);
                Cursor = Cursors.Default;
                AddBalanceButton.Enabled = true;
            }catch(Exception ex)
            {
                _userBalance += plan;
                MessageBox.Show(ex.Message, "Balance did not updated");
            }
        }
        private void FreeTrialButton_Click(object sender, EventArgs e)
        {
            PaymentPlanner(freeTrial, 1);
        }
        private void MonthlyPlanButton_Click(object sender, EventArgs e)
        {
            BalanceCalculator(monthlyPayment);
            PaymentPlanner(monthlyPlan, 1);
        }

        private void AnnualPlanButton_Click(object sender, EventArgs e)
        {
            BalanceCalculator(yearlyPayment);
            PaymentPlanner(annualPlan, 12);
        }

        private void AddBalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidBalance(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool IsValidBalance(char keyChar)
        {
            return char.IsControl(keyChar) || char.IsDigit(keyChar);
        }
        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            decimal addedBalance = decimal.Parse(AddBalanceTextBox.Text);
            _userBalance += addedBalance;
            try
            {
                _db.UpdateBalance(_userBalance, _userEmail);
                BalanceInfoLabel.Text = $"Your balance is : {_userBalance}";
                UpdateButtonsAccordingToBalance();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Balance did not added");
            }
        }
    }
}