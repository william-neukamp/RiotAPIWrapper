namespace RiotAPIWrapper.API
{
    /// <summary>
    /// SummonerDTO for Summoner json deserialize
    /// </summary>
    public class SummonerDTO
    {
        public string AccountID { get; set; }
        public int ProfileIconID { get; set; }
        public long RevisionDate { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string PUUID { get; set; }
        public long SummonerLevel { get; set; }
    }
}
