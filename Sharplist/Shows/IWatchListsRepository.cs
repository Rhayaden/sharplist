using System.Collections.Generic;

namespace Sharplist.Shows
{
    public interface IWatchListsRepository
    {
        IEnumerable<Show> Read(string email, List<Show> watchlist);
        void Write(string email, List<string> watchlist);
    }
}
