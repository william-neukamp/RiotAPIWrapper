using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Regions available to access Riot API
    /// </summary>
    public enum  Region
    {
        [Description("br1")]
        BR1,
        [Description("eun1")]
        EUN1,
        [Description("euw1")]
        EUW1,
        [Description("jp1")]
        JP1,
        [Description("kr")]
        KR,
        [Description("la1")]
        LA1,
        [Description("la2")]
        LA2,
        [Description("na1")]
        NA1,
        [Description("oc1")]
        OC1,
        [Description("ru")]
        RU,
        [Description("tr1")]
        TR1
    }
}
