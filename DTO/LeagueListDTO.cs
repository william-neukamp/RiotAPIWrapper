using System.Collections.Generic;

namespace RiotAPIWrapper.DTO
{
    /// <summary>
    /// LeagueListDTO for league json deserialize
    /// </summary>
    public class LeagueListDTO
    {
        public string LeagueId { get; set; }
        public List<LeagueItemDTO> Entries { get; set; }
        public string Tier { get; set; }
        public string Name { get; set; }
        public string Queue { get; set; }
    }
}
