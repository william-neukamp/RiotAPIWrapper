namespace RiotAPIWrapper.DTO
{
    /// <summary>
    /// LeagueItemDTO for league json deserialize
    /// </summary>
    public class LeagueItemDTO
    {        
        public bool FreshBlood { get; set; }
        public int Wins { get; set; }
        public string SummonerName { get; set; }
        public MiniSeriesDTO MiniSeries { get; set; }
        public bool Inactive { get; set; }
        public bool Veteran { get; set; }
        public bool HotStreak { get; set; }
        public string Rank { get; set; }
        public int LeaguePoints { get; set; }
        public int Losses { get; set; }
        public string SummonerId { get; set; }
    }
}
