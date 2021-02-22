using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Paths to access Riot API
    /// </summary>
    public enum Path
    {
        // SUMMONER //
        [Description("summoner/v4/summoners/by-account/")]
        AccountID,
        [Description("summoner/v4/summoners/by-name/")]
        SummonerName,
        [Description("summoner/v4/summoners/by-puuid/")]
        PUUID,
        [Description("summoner/v4/summoners/")]
        SummonerID
    }
}
