using System.Drawing;

namespace Sharplist
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.EnterEmailLabel = new System.Windows.Forms.Label();
            this.EnterEmailTextbox = new System.Windows.Forms.TextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.CodeTextbox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmNewPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.LinkLabel();
            this.InvalidEmailLabel = new System.Windows.Forms.Label();
            this.InvalidCodeLabel = new System.Windows.Forms.Label();
            this.InvalidPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordsNotMatchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(252, 124);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(87, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Verification Code";
            this.CodeLabel.Visible = false;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(252, 184);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.NewPasswordLabel.TabIndex = 1;
            this.NewPasswordLabel.Text = "New Password";
            this.NewPasswordLabel.Visible = false;
            // 
            // ConfirmNewPasswordLabel
            // 
            this.ConfirmNewPasswordLabel.AutoSize = true;
            this.ConfirmNewPasswordLabel.Location = new System.Drawing.Point(252, 244);
            this.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel";
            this.ConfirmNewPasswordLabel.Size = new System.Drawing.Size(116, 13);
            this.ConfirmNewPasswordLabel.TabIndex = 2;
            this.ConfirmNewPasswordLabel.Text = "Confirm New Password";
            this.ConfirmNewPasswordLabel.Visible = false;
            // 
            // EnterEmailLabel
            // 
            this.EnterEmailLabel.AutoSize = true;
            this.EnterEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnterEmailLabel.Location = new System.Drawing.Point(252, 70);
            this.EnterEmailLabel.Name = "EnterEmailLabel";
            this.EnterEmailLabel.Size = new System.Drawing.Size(159, 15);
            this.EnterEmailLabel.TabIndex = 3;
            this.EnterEmailLabel.Text = "Please enter your email";
            // 
            // EnterEmailTextbox
            // 
            this.EnterEmailTextbox.Location = new System.Drawing.Point(255, 100);
            this.EnterEmailTextbox.Name = "EnterEmailTextbox";
            this.EnterEmailTextbox.Size = new System.Drawing.Size(159, 20);
            this.EnterEmailTextbox.TabIndex = 4;
            this.EnterEmailTextbox.TextChanged += new System.EventHandler(this.EnterEmailTextbox_TextChanged);
            this.EnterEmailTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterEmailTextbox_KeyPress);
            this.EnterEmailTextbox.Leave += new System.EventHandler(this.EnterEmailTextbox_Leave);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(293, 150);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(85, 23);
            this.SendEmailButton.TabIndex = 5;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Location = new System.Drawing.Point(255, 140);
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.Size = new System.Drawing.Size(159, 20);
            this.CodeTextbox.TabIndex = 6;
            this.CodeTextbox.Visible = false;
            this.CodeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTextbox_KeyPress);
            // 
            // NewPasswordTextbox
            // 
            this.NewPasswordTextbox.Location = new System.Drawing.Point(255, 200);
            this.NewPasswordTextbox.Name = "NewPasswordTextbox";
            this.NewPasswordTextbox.PasswordChar = '*';
            this.NewPasswordTextbox.Size = new System.Drawing.Size(159, 20);
            this.NewPasswordTextbox.TabIndex = 7;
            this.NewPasswordTextbox.Visible = false;
            this.NewPasswordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPasswordTextbox_KeyPress);
            this.NewPasswordTextbox.Leave += new System.EventHandler(this.NewPasswordTextbox_Leave);
            // 
            // ConfirmNewPasswordTextbox
            // 
            this.ConfirmNewPasswordTextbox.Location = new System.Drawing.Point(255, 260);
            this.ConfirmNewPasswordTextbox.Name = "ConfirmNewPasswordTextbox";
            this.ConfirmNewPasswordTextbox.PasswordChar = '*';
            this.ConfirmNewPasswordTextbox.Size = new System.Drawing.Size(159, 20);
            this.ConfirmNewPasswordTextbox.TabIndex = 8;
            this.ConfirmNewPasswordTextbox.Visible = false;
            this.ConfirmNewPasswordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmNewPasswordTextbox_KeyPress);
            this.ConfirmNewPasswordTextbox.Leave += new System.EventHandler(this.ConfirmNewPasswordTextbox_Leave);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(277, 314);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(114, 23);
            this.ChangePasswordButton.TabIndex = 9;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Visible = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(318, 340);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.TabStop = true;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLabel_LinkClicked);
            // 
            // InvalidEmailLabel
            // 
            this.InvalidEmailLabel.AutoSize = true;
            this.InvalidEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailLabel.Location = new System.Drawing.Point(255, 123);
            this.InvalidEmailLabel.Name = "InvalidEmailLabel";
            this.InvalidEmailLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidEmailLabel.TabIndex = 11;
            this.InvalidEmailLabel.Visible = false;
            // 
            // InvalidCodeLabel
            // 
            this.InvalidCodeLabel.AutoSize = true;
            this.InvalidCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidCodeLabel.Location = new System.Drawing.Point(255, 163);
            this.InvalidCodeLabel.Name = "InvalidCodeLabel";
            this.InvalidCodeLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidCodeLabel.TabIndex = 12;
            this.InvalidCodeLabel.Visible = false;
            // 
            // InvalidPasswordLabel
            // 
            this.InvalidPasswordLabel.AutoSize = true;
            this.InvalidPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasswordLabel.Location = new System.Drawing.Point(255, 223);
            this.InvalidPasswordLabel.Name = "InvalidPasswordLabel";
            this.InvalidPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.InvalidPasswordLabel.TabIndex = 13;
            this.InvalidPasswordLabel.Visible = false;
            // 
            // PasswordsNotMatchLabel
            // 
            this.PasswordsNotMatchLabel.AutoSize = true;
            this.PasswordsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordsNotMatchLabel.Location = new System.Drawing.Point(255, 283);
            this.PasswordsNotMatchLabel.Name = "PasswordsNotMatchLabel";
            this.PasswordsNotMatchLabel.Size = new System.Drawing.Size(0, 13);
            this.PasswordsNotMatchLabel.TabIndex = 14;
            this.PasswordsNotMatchLabel.Visible = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.PasswordsNotMatchLabel);
            this.Controls.Add(this.InvalidPasswordLabel);
            this.Controls.Add(this.InvalidCodeLabel);
            this.Controls.Add(this.InvalidEmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ConfirmNewPasswordTextbox);
            this.Controls.Add(this.NewPasswordTextbox);
            this.Controls.Add(this.CodeTextbox);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.EnterEmailTextbox);
            this.Controls.Add(this.EnterEmailLabel);
            this.Controls.Add(this.ConfirmNewPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.CodeLabel);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharplist - Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label ConfirmNewPasswordLabel;
        private System.Windows.Forms.Label EnterEmailLabel;
        private System.Windows.Forms.TextBox EnterEmailTextbox;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.TextBox NewPasswordTextbox;
        private System.Windows.Forms.TextBox ConfirmNewPasswordTextbox;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.LinkLabel LoginLabel;
        private System.Windows.Forms.Label InvalidEmailLabel;
        private System.Windows.Forms.Label InvalidCodeLabel;
        private System.Windows.Forms.Label InvalidPasswordLabel;
        private System.Windows.Forms.Label PasswordsNotMatchLabel;
    }
}