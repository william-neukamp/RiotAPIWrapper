using System;
using System.ComponentModel;

namespace RiotAPIWrapper.Enums.Extensions
{
    /// <summary>
    /// Generic enum descriptor
    /// </summary>
    public static class EnumDescription
    {
        public static string Description(this Enum path)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])path.GetType().GetField(path.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
