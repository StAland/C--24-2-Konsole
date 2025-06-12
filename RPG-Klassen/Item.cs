using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Klassen
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HealAmount { get; set; }

        public Item(string name, string description, int healAmount)
        {
            Name = name;
            Description = description;
            HealAmount = healAmount;
        }

        public void Use(Character target)
        {
            target.HP = Math.Min(target.MaxHP, target.HP + HealAmount);
            Console.WriteLine($"{Name} used on {target.Name}. HP restored to {target.HP}");
        }
    }
}
