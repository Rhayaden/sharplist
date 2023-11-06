using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sharplist.Shows;

namespace Sharplist
{
    public partial class Watchlist : Form
    {
        private readonly IDatabaseOperations _db;
        private readonly string _userEmail;
        private readonly decimal _userBalance;
        private readonly IShowsRegister _showsRegister;
        private readonly IWatchListsRepository _watchListsRepository;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private readonly int _daysLeft;
        private readonly List<Show> _watchlist = new List<Show>();
        private bool _isSaved = true;
        private bool _isInitialWarning = true;
        public Watchlist(
            string userEmail,
            decimal userBalance,
            IShowsRegister showsRegister,
            IWatchListsRepository watchListsRepository,
            string plan,
            DateTime startDate,
            DateTime endDate,
            IDatabaseOperations db)
        {
            _userEmail = userEmail;
            _userBalance = userBalance;
            _showsRegister = showsRegister;
            _watchListsRepository = watchListsRepository;
            _startDate = startDate;
            _endDate = endDate;
            _db = db;
            _daysLeft = (_endDate - DateTime.Now).Days;
            _watchListsRepository.Read(_userEmail, _watchlist);
            InitializeComponent();
            WatchlistView.Columns.Add("ID", -1);
            WatchlistView.Columns.Add("Shows", -2);
            WatchlistView.Font = new Font(WatchlistView.Font, FontStyle.Bold);
            if (_watchlist.Count > 0)
            {
                GetWatchlist();
            }
            if (_daysLeft < 4)
            {
                PlanReminderLabel.Visible = true;
                RenewPlanLabel.Visible = true;
            }
            CurrentPlanLabel.Text = $"Active Plan: {plan}";
            WelcomeEmailLabel.Text = userEmail.Split('@')[0];
            BalanceInfoLabel.Text = $"Balance : $ {userBalance}";
            ShowsView.Columns.Add("ID", -1);
            ShowsView.Columns.Add("Shows", -1);
            ShowsView.Font = new Font(ShowsView.Font, FontStyle.Bold);
            GetShows();
        }
        private void GetShows()
        {
            foreach (var show in _showsRegister.All)
            {
                ListViewItem listViewItem = new ListViewItem(show.Id.ToString());
                listViewItem.Font = new Font(ShowsView.Font, FontStyle.Regular);
                listViewItem.SubItems.Add(show.ToString());
                ShowsView.Items.AddRange(new ListViewItem[] { listViewItem });
            }
        }
        private void GetWatchlist()
        {
            foreach (var show in _watchlist)
            {
                ListViewItem listViewItem = new ListViewItem(show.Id.ToString());
                listViewItem.Font = new Font(WatchlistView.Font, FontStyle.Regular);
                listViewItem.SubItems.Add(show.ToString());
                WatchlistView.Items.AddRange(new ListViewItem[] { listViewItem });
            }
        }
        private bool CheckSavedOrNot()
        {
            if (_watchlist.Count > 0 && !_isSaved && _isInitialWarning)
            {
                MessageBox.Show("Watchlist did not saved.");
                _isInitialWarning = false;
                return true;
            }
            return false;
        }
        private void Watchlist_Closing(object sender, FormClosingEventArgs e)
        {
            if (CheckSavedOrNot())
            {
                e.Cancel = true;
                return;
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (CheckSavedOrNot()){
                return;
            }
            AuthForm auth = new AuthForm(
                new DatabaseOperations(new SqlServerConnection()), 
                new EmailNotifier(), 
                new Validation());
            auth.Show();
            this.Hide();
        }
        private void WelcomeEmailLabel_MouseHover(object sender, EventArgs e)
        {
            LogoutButton.Visible = !LogoutButton.Visible;
        }

        private void PlanReminderLabel_MouseEnter(object sender, EventArgs e)
        {
            PlanInfoLabel.Visible = true;
            string singularOrPlural = _daysLeft < 2 ? "day" : "days";
            PlanInfoLabel.Text = $"Your plan ends in {_daysLeft} {singularOrPlural}.";
        }
        private void PlanReminderLabel_MouseLeave(object sender, EventArgs e)
        {
            PlanInfoLabel.Visible = false;
        }
        private bool IsValidId(char keyChar)
        {
            return char.IsControl(keyChar) || char.IsDigit(keyChar);
        }
        private void ChangeInfoLabelAccordingToOption(string input, string opt)
        {
            int showId = int.Parse(input);
            InfoLabel.Visible = true;
            if (opt == "details")
            {
                InfoLabel.Text = $"The show with ID {showId} has selected for details.";
                return;
            }
            string preposition = opt == "added" ? "to" : "from";
            InfoLabel.Text = $"The show with ID {showId} has {opt} {preposition} the list.";
        }
        private IEnumerable<Show> AddShowToList(int id)
        {
            var selectedShow = _showsRegister.GetById(id);
            var watchlist = _watchlist.Contains(selectedShow);
            if (watchlist)
            {
                InfoLabel.Text = "This show is already on the list.";
            }
            else
            {
                _watchlist.Add(selectedShow);
                _isSaved = false;
                _isInitialWarning = true;
            }
            return _watchlist.Distinct().ToList();
        }
        private void AddTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidId(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (AddTextbox.Text == "")
                {
                    return;
                }
                ChangeInfoLabelAccordingToOption(AddTextbox.Text, "added");
                int parsedId = int.Parse(AddTextbox.Text);
                if (parsedId > _showsRegister.All.Count() || parsedId == 0)
                {
                    InfoLabel.Text = "Please enter a valid ID";
                    AddTextbox.Text = "";
                    return;
                }
                AddTextbox.Text = "";
                AddShowToList(parsedId);
                WatchlistView.Items.Clear();
                GetWatchlist();
            }
        }
        private IEnumerable<Show> RemoveShowFromList(int id)
        {
            var selectedShow = _showsRegister.GetById(id);
            var watchlist = _watchlist.Contains(selectedShow);
            if (!watchlist)
            {
                InfoLabel.Text = "Not on the list.";
            }
            else
            {
                _watchlist.Remove(selectedShow);
                _isSaved = false;
                _isInitialWarning = true;
            }
            return _watchlist.ToList();
        }
        private void RemoveTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidId(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (RemoveTextbox.Text == "")
                {
                    return;
                }
                ChangeInfoLabelAccordingToOption(RemoveTextbox.Text, "removed");
                int parsedId = int.Parse(RemoveTextbox.Text);
                if (parsedId > _showsRegister.All.Count() || parsedId == 0)
                {
                    InfoLabel.Text = "Please enter a valid ID";
                    RemoveTextbox.Text = "";
                    return;
                }
                RemoveTextbox.Text = "";
                RemoveShowFromList(parsedId);
                WatchlistView.Items.Clear();
                GetWatchlist();
            }
        }
        private void DetailsTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValidId(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (DetailsTextbox.Text == "")
                {
                    return;
                }
                ChangeInfoLabelAccordingToOption(DetailsTextbox.Text, "details");
                int parsedId = int.Parse(DetailsTextbox.Text);
                if (parsedId > _showsRegister.All.Count() || parsedId == 0)
                {
                    InfoLabel.Text = "Please enter a valid ID";
                    DetailsTextbox.Text = "";
                    ShowDetailbox.Clear();
                    return;
                }
                DetailsTextbox.Text = "";
                ShowDetailbox.Clear();
                Show selectedShow = _showsRegister.GetById(parsedId);
                List<string> show = new List<string> {
                $"Title: {selectedShow.Title}",
                $"Year: {selectedShow.Year}",
                $"Category: {selectedShow.Category}",
                $"Description: {selectedShow.Presentation}"};
                ShowDetailbox.Text = string.Join(Environment.NewLine, show);
            }
        }
        private void CurrentPlanLabel_MouseEnter(object sender, EventArgs e)
        {
            PlanDateLabel.Visible = true;
            PlanDateLabel.Text = $"Start: {_startDate.ToString("dd/M/yyyy")}\nEnd: {_endDate.ToString("dd/M/yyyy")}";
        }
        private void CurrentPlanLabel_MouseLeave(object sender, EventArgs e)
        {
            PlanDateLabel.Visible = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();
            foreach(var show in _watchlist)
            {
                ids.Add(show.Id.ToString());
            }
            try
            {
                _watchListsRepository.Write(_userEmail, ids);
                _isSaved = true;
                MessageBox.Show("Sharplist has saved.");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sharplist has not saved");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _db.DeleteWatchlist(_userEmail);
                _watchlist.Clear();
                WatchlistView.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sharplist has deleted");
            }
        }

        private void RenewPlanLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Payment payment = new Payment(
                _userEmail,
                _userBalance,
                new DatabaseOperations(new SqlServerConnection()),
                new EmailNotifier());
            payment.Show();
            this.Hide();
        }
    }
}