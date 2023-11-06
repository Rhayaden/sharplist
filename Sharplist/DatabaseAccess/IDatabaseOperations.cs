using System;
using System.Collections.Generic;

namespace Sharplist
{
    public interface IDatabaseOperations {
        bool Login(string email, string password);
        Dictionary<string, dynamic> GetUserInfoByEmail(string email);
        bool CheckIfUserExist(string email);
        void Register(string email, string password, decimal balance);
        void ResetOutdatedPlan(string email);
        void UpdatePlan(string plan, DateTime startDate, DateTime endDate, string email);
        void UpdateBalance(decimal balance, string email);
        bool CheckIfFreeTrialUsed(string email);
        void DeleteWatchlist(string email);
        void ChangePassword(string email, string newPassword);

    }
}