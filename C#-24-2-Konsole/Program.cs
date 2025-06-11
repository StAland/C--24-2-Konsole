using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            var meineHaustiere = new List<Tier>();
            meineHaustiere.Add(new Hund("Carlos"));
            meineHaustiere.Add(new Katze("Lucy"));
            meineHaustiere.Add(new Hund("Chani"));

            foreach (var tier in meineHaustiere)
            {
                tier.Begruessen();
                tier.Schlafen();
            }
        }

    }
}



