using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Klassen
{
    public class Character : Entity
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public List<Item> Inventory { get; private set; }

        public Character(string name, int maxHP, int attack, int defense) : base(name, maxHP, attack, defense)
        {
            Level = 1;
            Experience = 0;
            Inventory = new List<Item>();
        }

        public void GainExperience(int amount)
        {
            Experience += amount;
            Console.WriteLine($"{Name} gains {amount} XP. Total XP: {Experience}");
            if (Experience >= Level * 100)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            MaxHP += 10;
            HP = MaxHP;
            Attack += 2;
            Defense += 1;
            Experience = 0;
            Console.WriteLine($"{Name} leveled up! Now at level {Level}. HP: {HP}, Attack: {Attack}, Defense: {Defense}");
        }

        public void AddItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{Name} obtained {item.Name}!");
        }
    }
}
