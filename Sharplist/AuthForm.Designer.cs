using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sharplist
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ToSCheckbox = new System.Windows.Forms.CheckBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.CreateAnAccountLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.DontYouHaveAnAccountLabel = new System.Windows.Forms.Label();
            this.InvalidEmailLabel = new System.Windows.Forms.Label();
            this.InvalidPasswordLabel = new System.Windows.Forms.Label();
            this.LoginInfoLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordsNotMatchLabel = new System.Windows.Forms.Label();
            this.GoBackToLoginLabel = new System.Windows.Forms.LinkLabel();
            this.AuthInfoLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceTextbox = new System.Windows.Forms.TextBox();
            this.InvalidBalanceLabel = new System.Windows.Forms.Label();
            this.ChangePasswordLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(205, 74);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(34, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(187, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // ToSCheckbox
            // 
            this.ToSCheckbox.AutoSize = true;
            this.ToSCheckbox.Location = new System.Drawing.Point(262, 271);
            this.ToSCheckbox.Name = "ToSCheckbox";
            this.ToSCheckbox.Size = new System.Drawing.Size(149, 17);
            this.ToSCheckbox.TabIndex = 2;
            this.ToSCheckbox.Text = "I accept Terms of Service";
            this.ToSCheckbox.UseVisualStyleBackColor = true;
            this.ToSCheckbox.Visible = false;
            this.ToSCheckbox.CheckStateChanged += new System.EventHandler(this.ToSCheckbox_CheckStateChanged);
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AuthButton.Location = new System.Drawing.Point(262, 181);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(171, 27);
            this.AuthButton.TabIndex = 3;
            this.AuthButton.Text = "Login";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(262, 71);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(171, 22);
            this.EmailTextbox.TabIndex = 4;
            this.EmailTextbox.TextChanged += new System.EventHandler(this.EmailTextbox_TextChanged);
            this.EmailTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextbox_KeyPress);
            this.EmailTextbox.Leave += new System.EventHandler(this.EmailTextbox_Leave);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(262, 121);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(171, 22);
            this.PasswordTextbox.TabIndex = 5;
            this.PasswordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextbox_KeyPress);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // CreateAnAccountLinkedLabel
            // 
            this.CreateAnAccountLinkedLabel.AutoSize = true;
            this.CreateAnAccountLinkedLabel.Location = new System.Drawing.Point(300, 267);
            this.CreateAnAccountLinkedLabel.Name = "CreateAnAccountLinkedLabel";
            this.CreateAnAccountLinkedLabel.Size = new System.Drawing.Size(100, 13);
            this.CreateAnAccountLinkedLabel.TabIndex = 6;
            this.CreateAnAccountLinkedLabel.TabStop = true;
            this.CreateAnAccountLinkedLabel.Text = "Create an account";
            this.CreateAnAccountLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAnAccountLinkedLabel_LinkClicked);
            // 
            // DontYouHaveAnAccountLabel
            // 
            this.DontYouHaveAnAccountLabel.AutoSize = true;
            this.DontYouHaveAnAccountLabel.Location = new System.Drawing.Point(274, 244);
            this.DontYouHaveAnAccountLabel.Name = "DontYouHaveAnAccountLabel";
            this.DontYouHaveAnAccountLabel.Size = new System.Drawing.Size(153, 13);
            this.DontYouHaveAnAccountLabel.TabIndex = 7;
            this.DontYouHaveAnAccountLabel.Text = "Don\'t you have an account ?";
            // 
            // InvalidEmailLabel
            // 
            this.InvalidEmailLabel.AutoSize = true;
            this.InvalidEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailLabel.Location = new System.Drawing.Point(262, 94);
            this.InvalidEmailLabel.Name = "InvalidEmailLabel";
            this.InvalidEmailLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidEmailLabel.TabIndex = 12;
            this.InvalidEmailLabel.Visible = false;
            // 
            // InvalidPasswordLabel
            // 
            this.InvalidPasswordLabel.AutoSize = true;
            this.InvalidPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasswordLabel.Location = new System.Drawing.Point(262, 144);
            this.InvalidPasswordLabel.Name = "InvalidPasswordLabel";
            this.InvalidPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidPasswordLabel.TabIndex = 13;
            this.InvalidPasswordLabel.Visible = false;
            // 
            // LoginInfoLabel
            // 
            this.LoginInfoLabel.AutoSize = true;
            this.LoginInfoLabel.Location = new System.Drawing.Point(274, 42);
            this.LoginInfoLabel.Name = "LoginInfoLabel";
            this.LoginInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.LoginInfoLabel.TabIndex = 14;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(147, 174);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.ConfirmPasswordLabel.TabIndex = 15;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            this.ConfirmPasswordLabel.Visible = false;
            // 
            // ConfirmPasswordTextbox
            // 
            this.ConfirmPasswordTextbox.Location = new System.Drawing.Point(262, 171);
            this.ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            this.ConfirmPasswordTextbox.PasswordChar = '*';
            this.ConfirmPasswordTextbox.Size = new System.Drawing.Size(171, 22);
            this.ConfirmPasswordTextbox.TabIndex = 16;
            this.ConfirmPasswordTextbox.Visible = false;
            this.ConfirmPasswordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPasswordTextbox_KeyPress);
            this.ConfirmPasswordTextbox.Leave += new System.EventHandler(this.ConfirmPasswordTextbox_Leave);
            // 
            // PasswordsNotMatchLabel
            // 
            this.PasswordsNotMatchLabel.AutoSize = true;
            this.PasswordsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordsNotMatchLabel.Location = new System.Drawing.Point(262, 194);
            this.PasswordsNotMatchLabel.Name = "PasswordsNotMatchLabel";
            this.PasswordsNotMatchLabel.Size = new System.Drawing.Size(0, 13);
            this.PasswordsNotMatchLabel.TabIndex = 17;
            this.PasswordsNotMatchLabel.Visible = false;
            // 
            // GoBackToLoginLabel
            // 
            this.GoBackToLoginLabel.AutoSize = true;
            this.GoBackToLoginLabel.Location = new System.Drawing.Point(331, 344);
            this.GoBackToLoginLabel.Name = "GoBackToLoginLabel";
            this.GoBackToLoginLabel.Size = new System.Drawing.Size(36, 13);
            this.GoBackToLoginLabel.TabIndex = 18;
            this.GoBackToLoginLabel.TabStop = true;
            this.GoBackToLoginLabel.Text = "Login";
            this.GoBackToLoginLabel.Visible = false;
            this.GoBackToLoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBackToLoginLabel_LinkClicked);
            // 
            // AuthInfoLabel
            // 
            this.AuthInfoLabel.AutoSize = true;
            this.AuthInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AuthInfoLabel.Location = new System.Drawing.Point(324, 8);
            this.AuthInfoLabel.Name = "AuthInfoLabel";
            this.AuthInfoLabel.Size = new System.Drawing.Size(53, 21);
            this.AuthInfoLabel.TabIndex = 19;
            this.AuthInfoLabel.Text = "Login";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(187, 222);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 20;
            this.BalanceLabel.Text = "Balance";
            this.BalanceLabel.Visible = false;
            // 
            // BalanceTextbox
            // 
            this.BalanceTextbox.Location = new System.Drawing.Point(262, 221);
            this.BalanceTextbox.Name = "BalanceTextbox";
            this.BalanceTextbox.Size = new System.Drawing.Size(171, 22);
            this.BalanceTextbox.TabIndex = 21;
            this.BalanceTextbox.Visible = false;
            this.BalanceTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BalanceTextbox_KeyPress);
            // 
            // InvalidBalanceLabel
            // 
            this.InvalidBalanceLabel.AutoSize = true;
            this.InvalidBalanceLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidBalanceLabel.Location = new System.Drawing.Point(262, 244);
            this.InvalidBalanceLabel.Name = "InvalidBalanceLabel";
            this.InvalidBalanceLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidBalanceLabel.TabIndex = 22;
            this.InvalidBalanceLabel.Visible = false;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(330, 146);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(103, 13);
            this.ChangePasswordLabel.TabIndex = 23;
            this.ChangePasswordLabel.TabStop = true;
            this.ChangePasswordLabel.Text = "Forgot password ?";
            this.ChangePasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePasswordLabel_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.InvalidBalanceLabel);
            this.Controls.Add(this.BalanceTextbox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.AuthInfoLabel);
            this.Controls.Add(this.GoBackToLoginLabel);
            this.Controls.Add(this.PasswordsNotMatchLabel);
            this.Controls.Add(this.ConfirmPasswordTextbox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.LoginInfoLabel);
            this.Controls.Add(this.InvalidPasswordLabel);
            this.Controls.Add(this.InvalidEmailLabel);
            this.Controls.Add(this.DontYouHaveAnAccountLabel);
            this.Controls.Add(this.CreateAnAccountLinkedLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.ToSCheckbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharplist - Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmailLabel;
        private Label PasswordLabel;
        private CheckBox ToSCheckbox;
        private Button AuthButton;
        private TextBox EmailTextbox;
        private TextBox PasswordTextbox;
        private LinkLabel CreateAnAccountLinkedLabel;
        private Label DontYouHaveAnAccountLabel;
        private Label LoginLabel;
        private Label InvalidEmailLabel;
        private Label InvalidPasswordLabel;
        private Label LoginInfoLabel;
        private Label ConfirmPasswordLabel;
        private TextBox ConfirmPasswordTextbox;
        private Label PasswordsNotMatchLabel;
        private LinkLabel GoBackToLoginLabel;
        private Label AuthInfoLabel;
        private Label BalanceLabel;
        private TextBox BalanceTextbox;
        private Label InvalidBalanceLabel;
        private LinkLabel ChangePasswordLabel;
    }
}