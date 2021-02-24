using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Paths to access Riot APIs
    /// </summary>
    public enum SummonerPath
    {
        // SUMMONER-V4 //
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
        // LEAGUE-V4 //
        [Description("league/v4/entries/by-summoner/")]
        SummonerID,
        [Description("league/v4/entries/{queue}/{tier}/{division}")]
        QueueTierDivision,
        [Description("league/v4/challengerleagues/by-queue/")]
        EntrieChallenger,
        [Description("league/v4/grandmasterleagues/by-queue/")]
        EntrieGrandmaster,
        [Description("league/v4/leagues/")]
        LeagueID,
        [Description("league/v4/masterleagues/by-queue/")]
        EntrieMaster
    }
}
