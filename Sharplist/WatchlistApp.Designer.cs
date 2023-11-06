using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sharplist
{
    partial class Watchlist
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WelcomeEmailLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ShowsView = new System.Windows.Forms.ListView();
            this.AddLabel = new System.Windows.Forms.Label();
            this.AddTextbox = new System.Windows.Forms.TextBox();
            this.WatchlistLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PlanReminderLabel = new System.Windows.Forms.Label();
            this.BalanceInfoLabel = new System.Windows.Forms.Label();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.RemoveTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.WatchlistView = new System.Windows.Forms.ListView();
            this.CurrentWatchlistLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PlanInfoLabel = new System.Windows.Forms.Label();
            this.SelectedShowDescriptionLabel = new System.Windows.Forms.Label();
            this.DetailsTextbox = new System.Windows.Forms.TextBox();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.SelectedShowDetailsLabel = new System.Windows.Forms.Label();
            this.CurrentPlanLabel = new System.Windows.Forms.Label();
            this.PlanDateLabel = new System.Windows.Forms.Label();
            this.ShowDetailbox = new System.Windows.Forms.RichTextBox();
            this.RenewPlanLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(261, 8);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome,";
            // 
            // WelcomeEmailLabel
            // 
            this.WelcomeEmailLabel.AutoSize = true;
            this.WelcomeEmailLabel.Location = new System.Drawing.Point(317, 8);
            this.WelcomeEmailLabel.Name = "WelcomeEmailLabel";
            this.WelcomeEmailLabel.Size = new System.Drawing.Size(52, 13);
            this.WelcomeEmailLabel.TabIndex = 1;
            this.WelcomeEmailLabel.Text = "userEmail";
            this.WelcomeEmailLabel.MouseHover += new System.EventHandler(this.WelcomeEmailLabel_MouseHover);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(313, 23);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(73, 26);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ShowsView
            // 
            this.ShowsView.HideSelection = false;
            this.ShowsView.Location = new System.Drawing.Point(10, 8);
            this.ShowsView.Name = "ShowsView";
            this.ShowsView.Size = new System.Drawing.Size(248, 373);
            this.ShowsView.TabIndex = 3;
            this.ShowsView.UseCompatibleStateImageBehavior = false;
            this.ShowsView.View = System.Windows.Forms.View.Details;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddLabel.Location = new System.Drawing.Point(263, 133);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(35, 15);
            this.AddLabel.TabIndex = 5;
            this.AddLabel.Text = "Add :";
            // 
            // AddTextbox
            // 
            this.AddTextbox.Location = new System.Drawing.Point(297, 131);
            this.AddTextbox.Name = "AddTextbox";
            this.AddTextbox.Size = new System.Drawing.Size(65, 20);
            this.AddTextbox.TabIndex = 6;
            this.AddTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddTextbox_KeyPress);
            // 
            // WatchlistLabel
            // 
            this.WatchlistLabel.AutoSize = true;
            this.WatchlistLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.WatchlistLabel.Location = new System.Drawing.Point(259, 83);
            this.WatchlistLabel.Name = "WatchlistLabel";
            this.WatchlistLabel.Size = new System.Drawing.Size(104, 30);
            this.WatchlistLabel.TabIndex = 7;
            this.WatchlistLabel.Text = "Sharplist";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(263, 159);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 8;
            // 
            // PlanReminderLabel
            // 
            this.PlanReminderLabel.AutoSize = true;
            this.PlanReminderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlanReminderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.PlanReminderLabel.ForeColor = System.Drawing.Color.Red;
            this.PlanReminderLabel.Location = new System.Drawing.Point(656, 8);
            this.PlanReminderLabel.Name = "PlanReminderLabel";
            this.PlanReminderLabel.Size = new System.Drawing.Size(18, 25);
            this.PlanReminderLabel.TabIndex = 10;
            this.PlanReminderLabel.Text = "!";
            this.PlanReminderLabel.Visible = false;
            this.PlanReminderLabel.MouseEnter += new System.EventHandler(this.PlanReminderLabel_MouseEnter);
            this.PlanReminderLabel.MouseLeave += new System.EventHandler(this.PlanReminderLabel_MouseLeave);
            // 
            // BalanceInfoLabel
            // 
            this.BalanceInfoLabel.AutoSize = true;
            this.BalanceInfoLabel.Location = new System.Drawing.Point(264, 61);
            this.BalanceInfoLabel.Name = "BalanceInfoLabel";
            this.BalanceInfoLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceInfoLabel.TabIndex = 11;
            this.BalanceInfoLabel.Text = "Balance";
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RemoveLabel.Location = new System.Drawing.Point(365, 133);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(60, 15);
            this.RemoveLabel.TabIndex = 13;
            this.RemoveLabel.Text = "Remove :";
            // 
            // RemoveTextbox
            // 
            this.RemoveTextbox.Location = new System.Drawing.Point(424, 131);
            this.RemoveTextbox.Name = "RemoveTextbox";
            this.RemoveTextbox.Size = new System.Drawing.Size(65, 20);
            this.RemoveTextbox.TabIndex = 14;
            this.RemoveTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveTextbox_KeyPress);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(263, 113);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(212, 13);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Enter a show ID to add/remove to watchlist";
            // 
            // WatchlistView
            // 
            this.WatchlistView.HideSelection = false;
            this.WatchlistView.Location = new System.Drawing.Point(264, 195);
            this.WatchlistView.Name = "WatchlistView";
            this.WatchlistView.Size = new System.Drawing.Size(223, 154);
            this.WatchlistView.TabIndex = 16;
            this.WatchlistView.UseCompatibleStateImageBehavior = false;
            this.WatchlistView.View = System.Windows.Forms.View.Details;
            // 
            // CurrentWatchlistLabel
            // 
            this.CurrentWatchlistLabel.AutoSize = true;
            this.CurrentWatchlistLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CurrentWatchlistLabel.Location = new System.Drawing.Point(263, 179);
            this.CurrentWatchlistLabel.Name = "CurrentWatchlistLabel";
            this.CurrentWatchlistLabel.Size = new System.Drawing.Size(107, 15);
            this.CurrentWatchlistLabel.TabIndex = 17;
            this.CurrentWatchlistLabel.Text = "Current Sharplist :";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(299, 355);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(71, 26);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.Location = new System.Drawing.Point(381, 355);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(71, 26);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PlanInfoLabel
            // 
            this.PlanInfoLabel.AutoSize = true;
            this.PlanInfoLabel.Location = new System.Drawing.Point(527, 36);
            this.PlanInfoLabel.Name = "PlanInfoLabel";
            this.PlanInfoLabel.Size = new System.Drawing.Size(48, 13);
            this.PlanInfoLabel.TabIndex = 22;
            this.PlanInfoLabel.Text = "Plan info";
            this.PlanInfoLabel.Visible = false;
            // 
            // SelectedShowDescriptionLabel
            // 
            this.SelectedShowDescriptionLabel.AutoSize = true;
            this.SelectedShowDescriptionLabel.Location = new System.Drawing.Point(496, 113);
            this.SelectedShowDescriptionLabel.Name = "SelectedShowDescriptionLabel";
            this.SelectedShowDescriptionLabel.Size = new System.Drawing.Size(131, 13);
            this.SelectedShowDescriptionLabel.TabIndex = 24;
            this.SelectedShowDescriptionLabel.Text = "Enter a show ID for details";
            // 
            // DetailsTextbox
            // 
            this.DetailsTextbox.Location = new System.Drawing.Point(552, 131);
            this.DetailsTextbox.Name = "DetailsTextbox";
            this.DetailsTextbox.Size = new System.Drawing.Size(65, 20);
            this.DetailsTextbox.TabIndex = 25;
            this.DetailsTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetailsTextbox_KeyPress);
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DetailLabel.Location = new System.Drawing.Point(495, 133);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(51, 15);
            this.DetailLabel.TabIndex = 26;
            this.DetailLabel.Text = "Details :";
            // 
            // SelectedShowDetailsLabel
            // 
            this.SelectedShowDetailsLabel.AutoSize = true;
            this.SelectedShowDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SelectedShowDetailsLabel.Location = new System.Drawing.Point(496, 179);
            this.SelectedShowDetailsLabel.Name = "SelectedShowDetailsLabel";
            this.SelectedShowDetailsLabel.Size = new System.Drawing.Size(137, 15);
            this.SelectedShowDetailsLabel.TabIndex = 27;
            this.SelectedShowDetailsLabel.Text = "Selected Show Details :";
            // 
            // CurrentPlanLabel
            // 
            this.CurrentPlanLabel.AutoSize = true;
            this.CurrentPlanLabel.Location = new System.Drawing.Point(468, 9);
            this.CurrentPlanLabel.Name = "CurrentPlanLabel";
            this.CurrentPlanLabel.Size = new System.Drawing.Size(61, 13);
            this.CurrentPlanLabel.TabIndex = 29;
            this.CurrentPlanLabel.Text = "currentPlan";
            this.CurrentPlanLabel.MouseEnter += new System.EventHandler(this.CurrentPlanLabel_MouseEnter);
            this.CurrentPlanLabel.MouseLeave += new System.EventHandler(this.CurrentPlanLabel_MouseLeave);
            // 
            // PlanDateLabel
            // 
            this.PlanDateLabel.AutoSize = true;
            this.PlanDateLabel.Location = new System.Drawing.Point(468, 23);
            this.PlanDateLabel.Name = "PlanDateLabel";
            this.PlanDateLabel.Size = new System.Drawing.Size(52, 13);
            this.PlanDateLabel.TabIndex = 30;
            this.PlanDateLabel.Text = "Plan date";
            this.PlanDateLabel.Visible = false;
            // 
            // ShowDetailbox
            // 
            this.ShowDetailbox.BackColor = System.Drawing.Color.White;
            this.ShowDetailbox.Location = new System.Drawing.Point(493, 195);
            this.ShowDetailbox.Name = "ShowDetailbox";
            this.ShowDetailbox.ReadOnly = true;
            this.ShowDetailbox.Size = new System.Drawing.Size(181, 186);
            this.ShowDetailbox.TabIndex = 31;
            this.ShowDetailbox.Text = "";
            // 
            // RenewPlanLabel
            // 
            this.RenewPlanLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.RenewPlanLabel.AutoSize = true;
            this.RenewPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RenewPlanLabel.LinkColor = System.Drawing.Color.Red;
            this.RenewPlanLabel.Location = new System.Drawing.Point(585, 17);
            this.RenewPlanLabel.Name = "RenewPlanLabel";
            this.RenewPlanLabel.Size = new System.Drawing.Size(65, 13);
            this.RenewPlanLabel.TabIndex = 32;
            this.RenewPlanLabel.TabStop = true;
            this.RenewPlanLabel.Text = "Renew Plan";
            this.RenewPlanLabel.Visible = false;
            this.RenewPlanLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RenewPlanLabel_LinkClicked);
            // 
            // Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.RenewPlanLabel);
            this.Controls.Add(this.ShowDetailbox);
            this.Controls.Add(this.PlanDateLabel);
            this.Controls.Add(this.CurrentPlanLabel);
            this.Controls.Add(this.SelectedShowDetailsLabel);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.DetailsTextbox);
            this.Controls.Add(this.SelectedShowDescriptionLabel);
            this.Controls.Add(this.PlanInfoLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CurrentWatchlistLabel);
            this.Controls.Add(this.WatchlistView);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.RemoveTextbox);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.BalanceInfoLabel);
            this.Controls.Add(this.PlanReminderLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.WatchlistLabel);
            this.Controls.Add(this.AddTextbox);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.ShowsView);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.WelcomeEmailLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Watchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharplist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Watchlist_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WelcomeLabel;
        private Label WelcomeEmailLabel;
        private Button LogoutButton;
        private ListView ShowsView;
        private Label AddLabel;
        private TextBox AddTextbox;
        private Label WatchlistLabel;
        private Label InfoLabel;
        private Label PlanReminderLabel;
        private Label BalanceInfoLabel;
        private Label RemoveLabel;
        private TextBox RemoveTextbox;
        private Label DescriptionLabel;
        private ListView WatchlistView;
        private Label CurrentWatchlistLabel;
        private Button SaveButton;
        private Button DeleteButton;
        private Label PlanInfoLabel;
        private Label SelectedShowDescriptionLabel;
        private TextBox DetailsTextbox;
        private Label DetailLabel;
        private Label SelectedShowDetailsLabel;
        private Label CurrentPlanLabel;
        private Label PlanDateLabel;
        private RichTextBox ShowDetailbox;
        private LinkLabel RenewPlanLabel;
    }
}