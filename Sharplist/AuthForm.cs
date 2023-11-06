using System.Drawing;
using System.Windows.Forms;
using System;

using Sharplist.Shows;
using System.Collections.Generic;

namespace Sharplist
{
    public partial class AuthForm : Form
    {
        private readonly IDatabaseOperations _db;
        private readonly INotifier _notifier;
        private bool _hasPlan;
        private readonly IValidation _validation;
        public AuthForm(IDatabaseOperations db, INotifier notifier, IValidation validation)
        {
            _db = db;
            _notifier = notifier;
            _validation = validation;
            InitializeComponent();
        }
        private void ToSCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (AuthButton.Text == "Signup")
            {
                if (ToSCheckbox.Checked)
                {
                    AuthButton.Enabled = true;
                }
                else
                {
                    AuthButton.Enabled = false;
                }
            }
        }
        private void CreateAnAccountLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InvalidEmailLabel.Visible = true;
            InvalidPasswordLabel.Visible = true;
            ChangePasswordLabel.Visible = false;
            ConfirmPasswordLabel.Visible = true;
            ConfirmPasswordTextbox.Visible = true;
            ConfirmPasswordLabel.Visible = true;
            ToSCheckbox.Visible = true;
            ToSCheckbox.Checked = false;
            AuthButton.Text = "Signup";
            AuthButton.Enabled = false;
            DontYouHaveAnAccountLabel.Visible = false;
            CreateAnAccountLinkedLabel.Visible = false;
            ToSCheckbox.Checked = false;
            AuthButton.Enabled = false;
            AuthButton.Location = new System.Drawing.Point(262, 294);
            GoBackToLoginLabel.Visible = true;
            AuthInfoLabel.Text = "Signup";
            BalanceLabel.Visible = true;
            BalanceTextbox.Visible = true;
            InvalidBalanceLabel.Visible = true;
            LoginInfoLabel.Text = "";
        }
        private void GoBackToLoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InvalidEmailLabel.Visible = false;
            InvalidPasswordLabel.Visible = false;
            ChangePasswordLabel.Visible = true;
            ConfirmPasswordTextbox.Text = "";
            PasswordsNotMatchLabel.Text = "";
            ConfirmPasswordLabel.Visible = false;
            ConfirmPasswordTextbox.Visible = false;
            PasswordsNotMatchLabel.Visible = false;
            ToSCheckbox.Visible = false;
            ToSCheckbox.Checked = false;
            AuthButton.Text = "Login";
            AuthButton.Enabled = true;
            DontYouHaveAnAccountLabel.Visible = true;
            CreateAnAccountLinkedLabel.Visible = true;
            AuthButton.Location = new System.Drawing.Point(262, 171);
            GoBackToLoginLabel.Visible = false;
            AuthInfoLabel.Text = "Login";
            BalanceLabel.Visible = false;
            BalanceTextbox.Visible = false;
            InvalidBalanceLabel.Visible = false;
            LoginInfoLabel.Text = "";
        }
        private void EmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValidEmail(EmailTextbox.Text))
            {
                EmailTextbox.ForeColor = Color.Black;
                InvalidEmailLabel.Visible = false;
                InvalidEmailLabel.Text = "";
            }
        }
        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (!_validation.IsValidEmail(EmailTextbox.Text) && AuthButton.Text == "Signup")
            {
                EmailTextbox.ForeColor = Color.Red;
                InvalidEmailLabel.Visible = true;
                InvalidEmailLabel.Text = "Invalid email";
            }
            else
            {
                EmailTextbox.ForeColor = Color.Black;
                InvalidEmailLabel.Visible = false;
                InvalidEmailLabel.Text = "";
            }
        }
        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
            if (!_validation.IsValidPassword(PasswordTextbox.Text) && AuthButton.Text == "Signup")
            {
                PasswordTextbox.ForeColor = Color.Red;
                InvalidPasswordLabel.Visible = true;
                InvalidPasswordLabel.Text = "Password length must be between 8-16 characters.";
            }
            else
            {
                PasswordTextbox.ForeColor = Color.Black;
                InvalidPasswordLabel.Visible = false;
                InvalidPasswordLabel.Text = "";
            }
        }
        private string GetHashedPassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
        }
        private bool IsUserExist(string email)
        {
            if (_db.CheckIfUserExist(email))
            {
                return true;
            }
            return false;
        }
        private void AuthButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextbox.Text;
            string password = PasswordTextbox.Text;
            string confirmPassword = ConfirmPasswordTextbox.Text;
            string hashedPw = GetHashedPassword(password);
            if (!_validation.IsValidEmail(email) || !_validation.IsValidPassword(password))
            {
                return;
            }
            if (AuthButton.Text == "Signup" && 
            _validation.IsValidEmail(email) &&
            _validation.IsValidPassword(password) &&
            _validation.IsMatch(password, confirmPassword))
            {
                if (!_validation.IsValidEmail(email) || 
                    !_validation.IsValidPassword(password) || 
                    !_validation.IsMatch(password, confirmPassword))
                {
                    return;
                }
                decimal balance = decimal.Parse(BalanceTextbox.Text);
                try
                {
                    if (IsUserExist(email))
                    {
                        InvalidEmailLabel.Visible = true;
                        InvalidEmailLabel.Text = "User already exist";
                        return;
                    }
                        Cursor = Cursors.WaitCursor;
                        AuthButton.Enabled = false;
                        _db.Register(email, hashedPw, balance);
                        List<string> messageList = new List<string>() {
                        "Welcome to Sharplist", "Make a sharplist, watch later."};
                        string message = string.Join(Environment.NewLine, messageList);
                        _notifier.Send(email, "Welcome to Sharplist", message);
                        Cursor = Cursors.Default;
                        AuthButton.Enabled = true;
                        LoginInfoLabel.ForeColor = DefaultForeColor;
                        LoginInfoLabel.Text = "Successfully signed up";
                        GoBackToLoginLabel_LinkClicked(this, null);
                        return;
                    }catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (AuthButton.Text == "Login" && _validation.IsValidEmail(email))
                {
                Cursor = Cursors.WaitCursor;
                AuthButton.Enabled = false;
                if (!IsUserExist(email))
                {
                    LoginInfoLabel.Text = "This user does not exist";
                    Cursor = Cursors.Default;
                    AuthButton.Enabled = true;
                    return;
                }
                if (_db.Login(email, password))
                {
                    var userInfo = _db.GetUserInfoByEmail(email);
                    Cursor = Cursors.Default;
                    AuthButton.Enabled = true;
                    _hasPlan = (bool)userInfo["hasPlan"];
                    DateTime endDate = userInfo["plan_end_date"];

                    if (!IsValidPlan(email, endDate))
                    {
                        MessageBox.Show($"Your subscription is ended in {endDate.Date}");
                        return;
                    }

                    if (_hasPlan)
                    {
                        IShowsRegister showsRegister = new ShowsRegister();
                        Watchlist watchlist = new Watchlist(
                            email,
                            (decimal)userInfo["user_balance"],
                            showsRegister,
                            new WatchListsRepository(showsRegister, new SqlServerConnection()),
                            userInfo["current_plan"],
                            userInfo["plan_start_date"],
                            userInfo["plan_end_date"],
                            new DatabaseOperations(new SqlServerConnection()));
                        watchlist.Show();
                        this.Hide();
                    }
                    else
                    {
                        Payment payment = new Payment(
                            email,
                            (decimal)userInfo["user_balance"],
                            new DatabaseOperations(new SqlServerConnection()),
                            new EmailNotifier());
                        payment.Show();
                        this.Hide();
                    }
                }
                else
                {
                    LoginInfoLabel.Text = "Wrong password";
                    Cursor = Cursors.Default;
                    AuthButton.Enabled = true;
                }
            }
        }
        private bool IsValidPlan(string email, DateTime endDate)
        {
            if (!_hasPlan)
            {
                return true;
            }
            DateTime now = DateTime.Now;
            if (now.Date > endDate.Date)
            {
                _db.ResetOutdatedPlan(email);
                return false;
            }
            return true;
        }
        private void ConfirmPasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ConfirmPasswordTextbox_Leave(object sender, EventArgs e)
        {
            ConfirmPasswordTextbox.PasswordChar = '*';
            if (!_validation.IsMatch(PasswordTextbox.Text, ConfirmPasswordTextbox.Text))
            {
                ConfirmPasswordTextbox.ForeColor = Color.Red;
                PasswordsNotMatchLabel.Visible = true;
                PasswordsNotMatchLabel.Text = "Passwords did not match";
            }
            else
            {
                ConfirmPasswordTextbox.ForeColor = DefaultForeColor;
                PasswordsNotMatchLabel.Visible = false;
                PasswordsNotMatchLabel.Text = "";
            }
        }
        private void BalanceTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_validation.IsValidInput(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                InvalidBalanceLabel.Text = "Minimum balance can be 0";
            }
        }
        private void ChangePasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(
                new DatabaseOperations(new SqlServerConnection()), 
                new EmailNotifier(),
                new CodeGenerator(),
                new Validation());
            resetPassword.Show();
            this.Hide();
        }
    }
}