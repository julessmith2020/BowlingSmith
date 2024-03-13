using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BowlerAPI.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext context) {
            _context = context;

        }


        public IEnumerable<Bowler> BowlersWithTeamNames => _context.Bowlers;

        public IEnumerable<Team> Teams => _context.Teams;
    }
}
