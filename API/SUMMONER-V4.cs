using RiotAPIWrapper.Enums;
using RiotAPIWrapper.Enums.Extensions;
using RiotAPIWrapper.DTO;

namespace RiotAPIWrapper.API
{
    /// <summary>
    /// SUMMONER-V4 API requests
    /// </summary>
    public class SUMMONER_V4 : BaseAPI
    {
        RiotURI uri;

        public SUMMONER_V4(string key, Region region, Game game) : base(key, region, game)
        {
            uri = new RiotURI(this.Region, this.Game, this.Key);
        }

        public SummonerDTO GetSummonerByEncryptedAccountID(string accountID)
        {
            uri.BuildUrl(SummonerPath.AccountID.Description() + accountID);
            var response = this.GET(uri.GetURL());
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }

        public SummonerDTO GetSummonerByName(string name)
        {
            uri.BuildUrl(SummonerPath.SummonerName.Description() + name);
            var response = this.GET(uri.GetURL());
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));                      
        }

        public SummonerDTO GetSummonerByEncryptedPUUID(string puuid)
        {
            uri.BuildUrl(SummonerPath.PUUID.Description() + puuid);
            var response = this.GET(uri.GetURL());
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }

        public SummonerDTO GetSummonerByEncryptedSummonerID(string summonerID)
        {
            uri.BuildUrl(SummonerPath.SummonerID.Description() + summonerID);
            var response = this.GET(uri.GetURL());
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }
    }
}
