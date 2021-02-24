namespace RiotAPIWrapper.DTO
{
    /// <summary>
    /// LeagueEntryDTO for league json deserialize
    /// </summary>
    public class LeagueEntryDTO
    {
        public string LeagueID { get; set; }
        public string SummonerID { get; set; }
        public string SummonerName { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int LeaguePoints { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public bool HotStreak { get; set; }
        public bool Veteran { get; set; }
        public bool FreshBlood { get; set; }
        public bool Inactive { get; set; }
        public MiniSeriesDTO MiniSeries { get; set; }
    }
}
