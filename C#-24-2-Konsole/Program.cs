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

            var password = "password";
            Console.WriteLine("Bitte Passwort eingeben: ");
            var eingabe = Console.ReadLine();
            string ausgabe = eingabe == password 
                ? "Zugriff erlaubt" 
                : "Zugriff verweigert";
            Console.WriteLine(ausgabe);
        }

    }
}



