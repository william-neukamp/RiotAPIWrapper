using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Queues available in LEAGUE-V4
    /// </summary>
    public enum Queue
    {
        [Description("RANKED_SOLO_5x5")]
        RANKED_SOLO_5x5,
        [Description("RANKED_FLEX_SR")]
        RANKED_FLEX_SR,
        [Description("RANKED_FLEX_TT")]
        RANKED_FLEX_TT
    }
}
