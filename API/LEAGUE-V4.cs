using RiotAPIWrapper.DTO;
using RiotAPIWrapper.Enums;
using RiotAPIWrapper.Enums.Extensions;
using System.Collections.Generic;
using System;

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

        public List<LeagueEntryDTO> GetLeagueEntriesBySummonerID(string summonerID)
        {
            uri.BuildUrl(LeaguePath.SummonerID.Description() + summonerID);
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(LeagueEntryDTO));
        }

        public List<LeagueEntryDTO> GetLeagueEntrieByQueueTierDivision(Queue queue, Tier tier, Division division)
        {
            string path = LeaguePath.QueueTierDivision.Description();
            path = path.Replace("{queue}", Enum.GetName(typeof(Queue), queue));
            path = path.Replace("{tier}", Enum.GetName(typeof(Tier), tier));
            path = path.Replace("{division}", Enum.GetName(typeof(Division), division));
            uri.BuildUrl(path);
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(LeagueEntryDTO));
        }

        public List<LeagueEntryDTO> GetLeagueEntrieByQueueTierDivision(Queue queue, Tier tier, Division division, int page)
        {
            string path = LeaguePath.QueueTierDivision.Description();
            path = path.Replace("{queue}", Enum.GetName(typeof(Queue), queue));
            path = path.Replace("{tier}", Enum.GetName(typeof(Tier), tier));
            path = path.Replace("{division}", Enum.GetName(typeof(Division), division));
            uri.BuildUrl(path, "page", page.ToString());
            var response = this.GET(uri.GetURL());
            return (List<LeagueEntryDTO>)this.JsonDeserialize(response, typeof(LeagueEntryDTO));
        }
    }
}
