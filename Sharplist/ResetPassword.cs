using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sharplist
{
    public partial class ResetPassword : Form
    {
        private readonly IDatabaseOperations _db;
        private readonly INotifier _notifier;
        private readonly ICodeGenerator _codeGenerator;
        private int _verificationCode;
        private readonly IValidation _validation;
        public ResetPassword(IDatabaseOperations db, INotifier notifier, ICodeGenerator codeGenerator, IValidation validation)
        {
            _db = db;
            _notifier = notifier;
            _codeGenerator = codeGenerator;
            _validation = validation;
            InitializeComponent();
        }
        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            string email = EnterEmailTextbox.Text;
            if (!IsUserExist(email))
            {
                InvalidEmailLabel.Text = "This user is not exist";
            }
            else
            {
                int verificationCode = _codeGenerator.Generate();
                _verificationCode = verificationCode;
                Cursor = Cursors.WaitCursor;
                SendEmailButton.Enabled = false;
                _notifier.Send(email, "Reset your password", $"Your verification code: {_verificationCode}");
                Cursor = Cursors.Default;
                SendEmailButton.Enabled = true;

                EnterEmailLabel.Visible = false;
                EnterEmailTextbox.Visible = false;
                SendEmailButton.Visible = false;
                CodeLabel.Visible = true;
                CodeTextbox.Visible = true;
                NewPasswordLabel.Visible = true;
                NewPasswordTextbox.Visible = true;
                ConfirmNewPasswordLabel.Visible = true;
                ConfirmNewPasswordTextbox.Visible = true;
                ChangePasswordButton.Visible = true;
            }
        }
        private void MoveToAuth()
        {
            AuthForm auth = new AuthForm(new DatabaseOperations(new SqlServerConnection()), new EmailNotifier(), new Validation());
            auth.Show();
            this.Hide();
        }
        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToAuth();
        }
        private void EnterEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void EnterEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValidEmail(EnterEmailTextbox.Text))
            {
                EnterEmailTextbox.ForeColor = Color.Black;
                InvalidEmailLabel.Visible = false;
                InvalidEmailLabel.Text = "";
            }
        }
        private void EnterEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (!_validation.IsValidEmail(EnterEmailTextbox.Text))
            {
                InvalidEmailLabel.Visible = true;
                InvalidEmailLabel.Text = "Invalid email";
            }
            else
            {
                EnterEmailTextbox.ForeColor = Color.Black;
                InvalidEmailLabel.Visible = false;
                InvalidEmailLabel.Text = "";
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
        private bool IsValidCode()
        {
            if(CodeTextbox.Text == "")
            {
                InvalidCodeLabel.Visible = true;
                InvalidCodeLabel.Text = "Please enter the code we sent to your email address.";
                return false;
            }
            int parsedCode = int.Parse(CodeTextbox.Text);
            if (parsedCode == _verificationCode)
            {
                InvalidCodeLabel.Visible = false;
                return true;
            }
            else
            {
                InvalidCodeLabel.Visible = true;
                InvalidCodeLabel.Text = "Invalid code";
                return false;
            }
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
                string email = EnterEmailTextbox.Text;
                string newPassword = NewPasswordTextbox.Text;
                string confirmNewPassword = ConfirmNewPasswordTextbox.Text;
                string hashedNewPw = GetHashedPassword(newPassword);

            if(IsValidCode() && 
                _validation.IsValidPassword(newPassword) &&
                _validation.IsMatch(newPassword, confirmNewPassword))
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    ChangePasswordButton.Enabled = false;
                    _db.ChangePassword(email, hashedNewPw);
                    Cursor = Cursors.Default;
                    ChangePasswordButton.Enabled = true;
                    MessageBox.Show("Password has changed");
                    MoveToAuth();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Password has not been changed");
                }
            }
            return;
        }
        private void NewPasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void NewPasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (!_validation.IsValidPassword(NewPasswordTextbox.Text))
            {
                NewPasswordTextbox.ForeColor = Color.Red;
                InvalidPasswordLabel.ForeColor = Color.Red;
                InvalidPasswordLabel.Visible = true;
                InvalidPasswordLabel.Text = "Password length must be between 8-16 characters.";
            }
            else
            {
                NewPasswordTextbox.ForeColor = Color.Black;
                InvalidPasswordLabel.ForeColor = Color.Black;
                InvalidPasswordLabel.Visible = false;
                InvalidPasswordLabel.Text = "";
            }
        }
        private void ConfirmNewPasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validation.IgnoreWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ConfirmNewPasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (!_validation.IsMatch(NewPasswordTextbox.Text, ConfirmNewPasswordTextbox.Text))
            {
                ConfirmNewPasswordTextbox.ForeColor = Color.Red;
                PasswordsNotMatchLabel.Visible = true;
                PasswordsNotMatchLabel.ForeColor = Color.Red;
                PasswordsNotMatchLabel.Text = "Passwords did not match";
            }
            else
            {
                ConfirmNewPasswordTextbox.ForeColor = DefaultForeColor;
                PasswordsNotMatchLabel.ForeColor = Color.Black;
                PasswordsNotMatchLabel.Visible = false;
                PasswordsNotMatchLabel.Text = "";
            }
        }
        private void CodeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_validation.IsValidInput(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}