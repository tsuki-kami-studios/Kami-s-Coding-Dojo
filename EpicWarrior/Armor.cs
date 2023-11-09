using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWarrior;

public class Armor
{
    public string Name { get; set; }

    public string Beschreibung { get; set; }


    public Rarity Rarity { get; set; }
}



public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Mythic,
    Godlike
}