namespace RiotAPIWrapper.DTO
{
    /// <summary>
    /// MiniSeriesDTO for mini series json deserialize
    /// </summary>
    public class MiniSeriesDTO
    {
        public int Losses { get; set; }
        public string Progress { get; set; }
        public int Target { get; set; }
        public int Wins { get; set; }
    }
}
