using System.Drawing;
using System.Windows.Forms;

namespace Sharplist
{
    partial class Payment
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
            this.FreeTrialView = new System.Windows.Forms.ListView();
            this.AnnualPlanView = new System.Windows.Forms.ListView();
            this.MonthlyPlanView = new System.Windows.Forms.ListView();
            this.FreeTrialLabel = new System.Windows.Forms.Label();
            this.FreeTrialButton = new System.Windows.Forms.Button();
            this.MonthlyPlanButton = new System.Windows.Forms.Button();
            this.AnnualPlanButton = new System.Windows.Forms.Button();
            this.MonthlyPlanLabel = new System.Windows.Forms.Label();
            this.AnnualPlanLabel = new System.Windows.Forms.Label();
            this.RecommendedLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.FreePlanInfoLabel1 = new System.Windows.Forms.Label();
            this.MonthlyPlanInfoLabel1 = new System.Windows.Forms.Label();
            this.AnnualPlanInfoLabel1 = new System.Windows.Forms.Label();
            this.FreePlanInfoLabel2 = new System.Windows.Forms.Label();
            this.MonthlyPlanInfoLabel2 = new System.Windows.Forms.Label();
            this.AnnualPlanInfoLabel2 = new System.Windows.Forms.Label();
            this.AnnualPlanInfoLabel3 = new System.Windows.Forms.Label();
            this.BalanceInfoLabel = new System.Windows.Forms.Label();
            this.AddBalanceTextBox = new System.Windows.Forms.TextBox();
            this.AddBalanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FreeTrialView
            // 
            this.FreeTrialView.HideSelection = false;
            this.FreeTrialView.Location = new System.Drawing.Point(95, 62);
            this.FreeTrialView.Name = "FreeTrialView";
            this.FreeTrialView.Size = new System.Drawing.Size(164, 283);
            this.FreeTrialView.TabIndex = 0;
            this.FreeTrialView.UseCompatibleStateImageBehavior = false;
            // 
            // AnnualPlanView
            // 
            this.AnnualPlanView.HideSelection = false;
            this.AnnualPlanView.Location = new System.Drawing.Point(432, 62);
            this.AnnualPlanView.Name = "AnnualPlanView";
            this.AnnualPlanView.Size = new System.Drawing.Size(164, 283);
            this.AnnualPlanView.TabIndex = 1;
            this.AnnualPlanView.UseCompatibleStateImageBehavior = false;
            // 
            // MonthlyPlanView
            // 
            this.MonthlyPlanView.HideSelection = false;
            this.MonthlyPlanView.Location = new System.Drawing.Point(264, 51);
            this.MonthlyPlanView.Name = "MonthlyPlanView";
            this.MonthlyPlanView.Size = new System.Drawing.Size(164, 304);
            this.MonthlyPlanView.TabIndex = 2;
            this.MonthlyPlanView.UseCompatibleStateImageBehavior = false;
            // 
            // FreeTrialLabel
            // 
            this.FreeTrialLabel.AutoSize = true;
            this.FreeTrialLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FreeTrialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FreeTrialLabel.Location = new System.Drawing.Point(145, 73);
            this.FreeTrialLabel.Name = "FreeTrialLabel";
            this.FreeTrialLabel.Size = new System.Drawing.Size(79, 21);
            this.FreeTrialLabel.TabIndex = 3;
            this.FreeTrialLabel.Text = "Free Trial";
            // 
            // FreeTrialButton
            // 
            this.FreeTrialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FreeTrialButton.Location = new System.Drawing.Point(95, 312);
            this.FreeTrialButton.Name = "FreeTrialButton";
            this.FreeTrialButton.Size = new System.Drawing.Size(164, 33);
            this.FreeTrialButton.TabIndex = 4;
            this.FreeTrialButton.Text = "Start your Free Trial";
            this.FreeTrialButton.UseVisualStyleBackColor = true;
            this.FreeTrialButton.Click += new System.EventHandler(this.FreeTrialButton_Click);
            // 
            // MonthlyPlanButton
            // 
            this.MonthlyPlanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthlyPlanButton.Location = new System.Drawing.Point(264, 312);
            this.MonthlyPlanButton.Name = "MonthlyPlanButton";
            this.MonthlyPlanButton.Size = new System.Drawing.Size(164, 43);
            this.MonthlyPlanButton.TabIndex = 5;
            this.MonthlyPlanButton.Text = "Get Started";
            this.MonthlyPlanButton.UseVisualStyleBackColor = true;
            this.MonthlyPlanButton.Click += new System.EventHandler(this.MonthlyPlanButton_Click);
            // 
            // AnnualPlanButton
            // 
            this.AnnualPlanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnnualPlanButton.Location = new System.Drawing.Point(432, 312);
            this.AnnualPlanButton.Name = "AnnualPlanButton";
            this.AnnualPlanButton.Size = new System.Drawing.Size(164, 33);
            this.AnnualPlanButton.TabIndex = 6;
            this.AnnualPlanButton.Text = "Get Started";
            this.AnnualPlanButton.UseVisualStyleBackColor = true;
            this.AnnualPlanButton.Click += new System.EventHandler(this.AnnualPlanButton_Click);
            // 
            // MonthlyPlanLabel
            // 
            this.MonthlyPlanLabel.AutoSize = true;
            this.MonthlyPlanLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthlyPlanLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MonthlyPlanLabel.Location = new System.Drawing.Point(289, 73);
            this.MonthlyPlanLabel.Name = "MonthlyPlanLabel";
            this.MonthlyPlanLabel.Size = new System.Drawing.Size(113, 21);
            this.MonthlyPlanLabel.TabIndex = 7;
            this.MonthlyPlanLabel.Text = "Monthly Plan";
            // 
            // AnnualPlanLabel
            // 
            this.AnnualPlanLabel.AutoSize = true;
            this.AnnualPlanLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnualPlanLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AnnualPlanLabel.Location = new System.Drawing.Point(469, 73);
            this.AnnualPlanLabel.Name = "AnnualPlanLabel";
            this.AnnualPlanLabel.Size = new System.Drawing.Size(103, 21);
            this.AnnualPlanLabel.TabIndex = 8;
            this.AnnualPlanLabel.Text = "Annual Plan";
            // 
            // RecommendedLabel
            // 
            this.RecommendedLabel.AutoSize = true;
            this.RecommendedLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RecommendedLabel.ForeColor = System.Drawing.Color.Red;
            this.RecommendedLabel.Location = new System.Drawing.Point(462, 40);
            this.RecommendedLabel.Name = "RecommendedLabel";
            this.RecommendedLabel.Size = new System.Drawing.Size(110, 19);
            this.RecommendedLabel.TabIndex = 9;
            this.RecommendedLabel.Text = "Recommended";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(95, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(164, 214);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(264, 101);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(164, 214);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(432, 101);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(164, 214);
            this.listView3.TabIndex = 12;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // FreePlanInfoLabel1
            // 
            this.FreePlanInfoLabel1.AutoSize = true;
            this.FreePlanInfoLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FreePlanInfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FreePlanInfoLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FreePlanInfoLabel1.Location = new System.Drawing.Point(156, 141);
            this.FreePlanInfoLabel1.Name = "FreePlanInfoLabel1";
            this.FreePlanInfoLabel1.Size = new System.Drawing.Size(45, 26);
            this.FreePlanInfoLabel1.TabIndex = 13;
            this.FreePlanInfoLabel1.Text = "$ 0";
            // 
            // MonthlyPlanInfoLabel1
            // 
            this.MonthlyPlanInfoLabel1.AutoSize = true;
            this.MonthlyPlanInfoLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthlyPlanInfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlyPlanInfoLabel1.Location = new System.Drawing.Point(316, 141);
            this.MonthlyPlanInfoLabel1.Name = "MonthlyPlanInfoLabel1";
            this.MonthlyPlanInfoLabel1.Size = new System.Drawing.Size(58, 26);
            this.MonthlyPlanInfoLabel1.TabIndex = 14;
            this.MonthlyPlanInfoLabel1.Text = "$ 10";
            // 
            // AnnualPlanInfoLabel1
            // 
            this.AnnualPlanInfoLabel1.AutoSize = true;
            this.AnnualPlanInfoLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnualPlanInfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnnualPlanInfoLabel1.Location = new System.Drawing.Point(485, 141);
            this.AnnualPlanInfoLabel1.Name = "AnnualPlanInfoLabel1";
            this.AnnualPlanInfoLabel1.Size = new System.Drawing.Size(58, 26);
            this.AnnualPlanInfoLabel1.TabIndex = 15;
            this.AnnualPlanInfoLabel1.Text = "$ 90";
            // 
            // FreePlanInfoLabel2
            // 
            this.FreePlanInfoLabel2.AutoSize = true;
            this.FreePlanInfoLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FreePlanInfoLabel2.Location = new System.Drawing.Point(121, 198);
            this.FreePlanInfoLabel2.Name = "FreePlanInfoLabel2";
            this.FreePlanInfoLabel2.Size = new System.Drawing.Size(112, 13);
            this.FreePlanInfoLabel2.TabIndex = 16;
            this.FreePlanInfoLabel2.Text = "✔ 30 days free to use";
            // 
            // MonthlyPlanInfoLabel2
            // 
            this.MonthlyPlanInfoLabel2.AutoSize = true;
            this.MonthlyPlanInfoLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthlyPlanInfoLabel2.Location = new System.Drawing.Point(290, 198);
            this.MonthlyPlanInfoLabel2.Name = "MonthlyPlanInfoLabel2";
            this.MonthlyPlanInfoLabel2.Size = new System.Drawing.Size(106, 13);
            this.MonthlyPlanInfoLabel2.TabIndex = 17;
            this.MonthlyPlanInfoLabel2.Text = "✔ Create a watchlist";
            // 
            // AnnualPlanInfoLabel2
            // 
            this.AnnualPlanInfoLabel2.AutoSize = true;
            this.AnnualPlanInfoLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnualPlanInfoLabel2.Location = new System.Drawing.Point(463, 198);
            this.AnnualPlanInfoLabel2.Name = "AnnualPlanInfoLabel2";
            this.AnnualPlanInfoLabel2.Size = new System.Drawing.Size(106, 13);
            this.AnnualPlanInfoLabel2.TabIndex = 18;
            this.AnnualPlanInfoLabel2.Text = "✔ Create a watchlist";
            // 
            // AnnualPlanInfoLabel3
            // 
            this.AnnualPlanInfoLabel3.AutoSize = true;
            this.AnnualPlanInfoLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnnualPlanInfoLabel3.Location = new System.Drawing.Point(473, 231);
            this.AnnualPlanInfoLabel3.Name = "AnnualPlanInfoLabel3";
            this.AnnualPlanInfoLabel3.Size = new System.Drawing.Size(70, 13);
            this.AnnualPlanInfoLabel3.TabIndex = 19;
            this.AnnualPlanInfoLabel3.Text = "✔ Save 25%";
            // 
            // BalanceInfoLabel
            // 
            this.BalanceInfoLabel.AutoSize = true;
            this.BalanceInfoLabel.Location = new System.Drawing.Point(22, 8);
            this.BalanceInfoLabel.Name = "BalanceInfoLabel";
            this.BalanceInfoLabel.Size = new System.Drawing.Size(86, 13);
            this.BalanceInfoLabel.TabIndex = 20;
            this.BalanceInfoLabel.Text = "Your balance is :";
            // 
            // AddBalanceTextBox
            // 
            this.AddBalanceTextBox.Location = new System.Drawing.Point(25, 28);
            this.AddBalanceTextBox.Name = "AddBalanceTextBox";
            this.AddBalanceTextBox.Size = new System.Drawing.Size(50, 20);
            this.AddBalanceTextBox.TabIndex = 22;
            this.AddBalanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddBalanceTextBox_KeyPress);
            // 
            // AddBalanceButton
            // 
            this.AddBalanceButton.Location = new System.Drawing.Point(81, 24);
            this.AddBalanceButton.Name = "AddBalanceButton";
            this.AddBalanceButton.Size = new System.Drawing.Size(78, 26);
            this.AddBalanceButton.TabIndex = 23;
            this.AddBalanceButton.Text = "Add Balance";
            this.AddBalanceButton.UseVisualStyleBackColor = true;
            this.AddBalanceButton.Click += new System.EventHandler(this.AddBalanceButton_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.AddBalanceTextBox);
            this.Controls.Add(this.BalanceInfoLabel);
            this.Controls.Add(this.AnnualPlanInfoLabel3);
            this.Controls.Add(this.AnnualPlanInfoLabel2);
            this.Controls.Add(this.MonthlyPlanInfoLabel2);
            this.Controls.Add(this.FreePlanInfoLabel2);
            this.Controls.Add(this.AnnualPlanInfoLabel1);
            this.Controls.Add(this.MonthlyPlanInfoLabel1);
            this.Controls.Add(this.FreePlanInfoLabel1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RecommendedLabel);
            this.Controls.Add(this.AnnualPlanLabel);
            this.Controls.Add(this.MonthlyPlanLabel);
            this.Controls.Add(this.AnnualPlanButton);
            this.Controls.Add(this.MonthlyPlanButton);
            this.Controls.Add(this.FreeTrialButton);
            this.Controls.Add(this.FreeTrialLabel);
            this.Controls.Add(this.MonthlyPlanView);
            this.Controls.Add(this.AnnualPlanView);
            this.Controls.Add(this.FreeTrialView);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharplist - Choose your plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView FreeTrialView;
        private ListView AnnualPlanView;
        private ListView MonthlyPlanView;
        private Label FreeTrialLabel;
        private Button FreeTrialButton;
        private Button MonthlyPlanButton;
        private Button AnnualPlanButton;
        private Label MonthlyPlanLabel;
        private Label AnnualPlanLabel;
        private Label RecommendedLabel;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private Label FreePlanInfoLabel1;
        private Label MonthlyPlanInfoLabel1;
        private Label AnnualPlanInfoLabel1;
        private Label FreePlanInfoLabel2;
        private Label MonthlyPlanInfoLabel2;
        private Label AnnualPlanInfoLabel2;
        private Label AnnualPlanInfoLabel3;
        private Label BalanceInfoLabel;
        private TextBox AddBalanceTextBox;
        private Button AddBalanceButton;
    }
}