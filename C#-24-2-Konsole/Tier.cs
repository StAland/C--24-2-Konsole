using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal abstract class Tier
    {
        public string Name { get; set; }

        public Tier (string name)
        {
            Name = name;
        }

        public void Schlafen()
        {
            Console.WriteLine($"{Name} schlaeft");
        }

        public abstract void Begruessen();
    }
    internal class Katze : Tier
    {
        public Katze(string name) : base(name)
        {
        }

        public override void Begruessen()
        {
            Console.WriteLine($"{Name} schnurrt");
        }
    }

    internal class Hund : Tier
    {
        public Hund(string name) : base(name)
        {
        }

        public override void Begruessen()
        {
            Console.WriteLine($"{Name} wedelt mit dem Schwanz");
        }

        public void Bellen()
        {
            Console.WriteLine($"{Name} bellt");
        }
    }
}
