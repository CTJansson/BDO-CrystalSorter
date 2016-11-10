using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalSorter.Models
{
    public class Crystal
    {
        public string Name { get; set; }
        public string Slot { get; set; }
        public string ItemEffect { get; set; }
        public float Weight { get; set; }
        public string Rarity { get; set; }
        public string Shattering { get; set; }
        public string Localization { get; set; }
    }

    public enum Slot
    {
        Weapon,
        Secondary,
        Helmet,
        Armor,
        Gloves,
        Shoes,
        Any
    };

    public enum Rarity
    {
        White,
        Green,
        Blue,
        Yellow,
        Orange,
    };

    public enum Shatter
    {
        VeryLow,
        Low,
        High,
        VeryHigh,
        
    }
}