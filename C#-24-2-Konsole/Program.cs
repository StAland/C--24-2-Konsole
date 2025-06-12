using RPG_Klassen;
using System;

namespace C__24_2_Konsole
{


    internal class Program
    {
        public static ILogger Logger = new Datenbanklogger();
        static void Main(string[] args)
        {
            var spieler = new Character("Ich", 10, 5, 2);
        }

    }
}



