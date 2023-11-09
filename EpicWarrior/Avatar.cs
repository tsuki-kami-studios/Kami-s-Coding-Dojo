using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EpicWarrior;

public class Avatar
{
    public string Name { get; set; }

    public sbyte Level { get; set; }

    public ulong Experience { get; set; }

    public IDictionary<Position,Armor> Armors { get; set; }

}

public enum Position
{
    Head,
    Chest,
    Legs
}