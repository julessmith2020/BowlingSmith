namespace BowlerAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> BowlersWithTeamNames { get; }

        IEnumerable<Team> Teams { get; }
    }
}
