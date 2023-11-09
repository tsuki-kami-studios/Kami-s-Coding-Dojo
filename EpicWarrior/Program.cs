namespace EpicWarrior
{
    internal class Program
    {
        static void Main()
        {

            var character = new Avatar
                {
                    Experience = 9000, 
                    Level = 9, 
                    Name = "Epic Warrior", 
                    Armors = new Dictionary<Position,Armor>()
                    {
                        {
                            Position.Head,
                            new Armor { Name = "Hut", Beschreibung = "This is an epic armor", Rarity = Rarity.Rare }
                        },
                        { 
                            Position.Chest, 
                            new Armor { Name = "Hemd", Beschreibung = "This is an epic armor", Rarity = Rarity.Mythic }
                        },
                        { 
                            Position.Legs,
                            new Armor { Name = "Hose", Beschreibung = "This is an epic armor", Rarity = Rarity.Godlike } 
                        },
                    },
                };


            character.Armors[Position.Head] = new ()
            {
                Name = "Strohhut",
                Beschreibung = "FJEGBÖSHG",
                Rarity = Rarity.Common
            };
            Console.ReadLine();
        }
    }
}