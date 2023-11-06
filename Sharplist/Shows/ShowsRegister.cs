using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sharplist.Movies;
using Sharplist.Shows.Animes;
using Sharplist.Shows.Documentaries;
using Sharplist.Shows.Movies;
using Sharplist.Shows.TVShows;

namespace Sharplist.Shows
{
    public class ShowsRegister : IShowsRegister
    {
        public IEnumerable<Show> All { get; } = new List<Show>
{
    new TheShawshankRedemption(),
    new TheGodfatherI(),
    new TheDarkKnightI(),
    new PulpFiction(),
    new FightClub(),
    new TheLordOfTheRingsI(),
    new Se7en(),
    new SavingPrivateRyan(),
    new TheUsualSuspects(),
    new TheIntouchables(),
    new Whiplash(),
    new Scarface(),
    new GoodWillHunting(),
    new LockStockAndTwoSmokingBarrels(),
    new RememberTheTitans(),
    new TheManFromEarth(),
    new TrainingDay(),
    new Jumanji(),
    new CosmosASpacetimeOdyssey(),
    new BreakingBad(),
    new TheSopranos(),
    new TheOffice(),
    new TrueDetective(),
    new FullMetalAlchemistBrotherhood(),
    new HunterxHunter(),
    new KimetsuNoYaiba(),
    new JujutsuKaisen(),
    new Naruto(),
    new Bleach(),
    new LogHorizon(),
};

        public Show GetById(int id)
        {
            if (id > All.Count() || id == 0)
            {
                return null;
            }
            var selectedShow = All.Where(show => show.Id == id);
            try
            {
                return selectedShow.FirstOrDefault(show => show.Id == id);
            }
            catch (Exception ex) { 
                if(ex is InvalidOperationException)
                {
                    MessageBox.Show($"More than one shows have ID equal to {id}.");
                    return null;
                }
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}