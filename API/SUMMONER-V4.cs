using RiotAPIWrapper.Enums;
using RiotAPIWrapper.Enums.Extensions;

namespace RiotAPIWrapper.API
{
    /// <summary>
    /// SUMMONER-V4 API requests and paths
    /// </summary>
    public class SUMMONER_V4 : BaseAPI
    {            
        public SUMMONER_V4(string key, Region region, Game game) : base(key, region, game)
        {
        }

        public SummonerDTO GetSummonerByEncryptedAccountID(string accountID)
        {
            var response = this.GET(Path.AccountID.Description() + accountID);
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }

        public SummonerDTO GetSummonerByName(string name)
        {
            var response = this.GET(Path.SummonerName.Description() + name);
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));                      
        }

        public SummonerDTO GetSummonerByEncryptedPUUID(string puuid)
        {
            var response = this.GET(Path.PUUID.Description() + puuid);
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }

        public SummonerDTO GetSummonerByEncryptedSummonerID(string summonerID)
        {
            var response = this.GET(Path.SummonerID.Description() + summonerID);
            return (SummonerDTO)this.JsonDeserialize(response, typeof(SummonerDTO));
        }
    }
}
