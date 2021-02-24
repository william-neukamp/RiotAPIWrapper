using System.ComponentModel;

namespace RiotAPIWrapper.Enums
{
    /// <summary>
    /// Game types available
    /// </summary>
    public enum Game
    {
        [Description("lol")]
        LOL,
        [Description("lor")]
        LOR,
        [Description("tft")]
        TFT,
        [Description("val")]
        VAL,
        [Description("riot")]
        RIOT
    }
}
