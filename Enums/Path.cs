using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Paths to access Riot APIs
    /// </summary>
    public enum SummonerPath
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

    public enum LeaguePath
    {
        // LEAGUE //
        [Description("league/v4/entries/by-summoner/")]
        SummonerID,
        [Description("league/v4/entries/{queue}/{tier}/{division}")]
        QueueTierDivision
    }
}
