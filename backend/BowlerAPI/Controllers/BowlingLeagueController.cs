using BowlerAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingLeagueController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var bowlerData = from bowler in _bowlerRepository.BowlersWithTeamNames
                             join team in _bowlerRepository.Teams on bowler.TeamId equals team.TeamId
                             where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                             select new
                             {
                                 bowler.BowlerId,
                                 bowlerName = $"{bowler.BowlerFirstName} {bowler.BowlerMiddleInit} {bowler.BowlerLastName}",
                                 bowler.BowlerAddress,
                                 bowler.BowlerCity,
                                 bowler.BowlerState,
                                 bowler.BowlerZip,
                                 bowler.BowlerPhoneNumber,
                                 teamName = team.TeamName
                             };

            return bowlerData.ToArray();
        }
    }
}
