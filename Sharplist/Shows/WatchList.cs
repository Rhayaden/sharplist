using System;
using System.Collections.Generic;
using System.Linq;

namespace Sharplist.Shows
{
    public class WatchList
    {
        public IEnumerable<Show> Shows { get; }
        public WatchList(IEnumerable<Show> shows)
        {
            Shows = shows;
        }
        public override string ToString()
        {
            var steps = Shows.Select(show => $"{show.Title} ({show.Year})");

            return string.Join(Environment.NewLine, steps);
        }
    }
}