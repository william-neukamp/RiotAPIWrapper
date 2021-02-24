using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Tiers available in LEAGUE-V4
    /// </summary>
    public enum Tier
    {
        [Description("IRON")]
        IRON,
        [Description("BRONZE")]
        BRONZE,
        [Description("SILVER")]
        SILVER,
        [Description("GOLD")]
        GOLD,
        [Description("PLATINUM")]
        PLATINUM,
        [Description("DIAMOND")]
        DIAMOND
    }
}
