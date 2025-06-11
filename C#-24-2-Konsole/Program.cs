using System;

namespace C__24_2_Konsole
{


    internal class Program
    {
        public static ILogger Logger = new Datenbanklogger();
        static void Main(string[] args)
        {
            var meineHaustiere = new List<Tier>();
            meineHaustiere.Add(new Hund("Carlos"));
            Logger.Log("Hund Carlos erstellt");
            meineHaustiere.Add(new Katze("Lucy"));
            Logger.Log("Katze erstellt");
            meineHaustiere.Add(new Hund("Chani"));

            foreach (var tier in meineHaustiere)
            {
                tier.Begruessen();
                tier.Schlafen();
                Logger.Log($"{tier.Name} fertig");
            }
        }

    }
}



