using System.Collections.Generic;

namespace Sharplist.Shows
{
    public interface IShowsRegister
    {
        IEnumerable<Show> All { get; }

        Show GetById(int id);
    }
}