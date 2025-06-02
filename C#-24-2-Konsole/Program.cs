using System;

namespace C__24_2_Konsole
{


    internal class Program
    {
        enum Wochentage
        {
            Montag = 1,
            Dienstag = 2,
            Mittwoch = 3,
            Donnerstag,
            Freitag,
            Samstag,
            Sonntag
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            var wochentag = Wochentage.Freitag;
            
            switch (wochentag)
            {
                case Wochentage.Montag:
                    Console.WriteLine("Montag");
                    break;
                case Wochentage.Dienstag:
                    Console.WriteLine("Dienstag");
                    break;
                case Wochentage.Mittwoch:
                case Wochentage.Donnerstag:
                    Console.WriteLine("Woche");
                    break;
            }
        }

        static bool IsWerktag(Wochentage wochentag)
        {
            switch (wochentag)
            {
                case Wochentage.Montag:
                case Wochentage.Dienstag:
                case Wochentage.Mittwoch:
                case Wochentage.Donnerstag:
                case Wochentage.Freitag:
                    return true;
                default:
                    return false;
            }
        }
    }
}



