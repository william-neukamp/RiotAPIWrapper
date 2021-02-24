using RiotAPIWrapper.DTO;
using RiotAPIWrapper.Enums;
using RiotAPIWrapper.Enums.Extensions;
using System.Collections.Generic;

namespace RiotAPIWrapper.API
{
    /// <summary>
    /// LEAGUE-V4 API requests
    /// </summary>
    public class LEAGUE_V4 : BaseAPI
    {
        RiotURI uri; 

        public LEAGUE_V4(string key, Region region, Game game) : base(key, region, game)
        {
            uri = new RiotURI(this.Region, this.Game, this.Key);
        }

        public LeagueListDTO GetLeagueEntrieChallenger(Queue queue)
        {
            uri.BuildUrl(LeaguePath.EntrieChallenger.Description() + queue.Description());
            var response = this.GET(uri.GetURL());
            return (LeagueListDTO)this.JsonDeserialize(response, typeof(LeagueListDTO));
        }

        public List<LeagueEntryDTO> GetLeagueEntriesBySummonerID(string summonerID)
        {
            uri.BuildUrl(LeaguePath.SummonerID.Description() + summonerID);
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(List<LeagueEntryDTO>));
        }

        public List<LeagueEntryDTO> GetLeagueEntries(Queue queue, Tier tier, Division division)
        {
            string path = LeaguePath.QueueTierDivision.Description();
            path = path.Replace("{queue}", queue.Description());
            path = path.Replace("{tier}", tier.Description());
            path = path.Replace("{division}", division.Description());
            uri.BuildUrl(path);
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(List<LeagueEntryDTO>));
        }

        public List<LeagueEntryDTO> GetLeagueEntries(Queue queue, Tier tier, Division division, int page)
        {
            string path = LeaguePath.QueueTierDivision.Description();
            path = path.Replace("{queue}", queue.Description());
            path = path.Replace("{tier}", tier.Description());
            path = path.Replace("{division}", division.Description());
            uri.BuildUrl(path, "page", page.ToString());
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(List<LeagueEntryDTO>));
        }

        public LeagueListDTO GetEntrieGrandmaster(Queue queue)
        {
            uri.BuildUrl(LeaguePath.EntrieGrandmaster.Description() + queue.Description());
            var response = this.GET(uri.GetURL());
            return (LeagueListDTO)this.JsonDeserialize(response, typeof(LeagueListDTO));
        }

        public LeagueListDTO GetEntrieByLeagueID(string leagueID)
        {
            uri.BuildUrl(LeaguePath.LeagueID.Description() + leagueID);
            var response = this.GET(uri.GetURL());
            return (LeagueListDTO)this.JsonDeserialize(response, typeof(LeagueListDTO));
        }

        public LeagueListDTO GetEntrieMaster(Queue queue)
        {
            uri.BuildUrl(LeaguePath.EntrieMaster.Description() + queue.Description());
            var response = this.GET(uri.GetURL());
            return (LeagueListDTO)this.JsonDeserialize(response, typeof(LeagueListDTO));
        }
    }
}
