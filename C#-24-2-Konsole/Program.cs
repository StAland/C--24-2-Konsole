using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            var bruch1 = new Bruch(3, 2);
            var bruch2 = new Bruch(7, 3);
            var ergebnis = bruch1.Multiplizieren(bruch2);
            Console.WriteLine(ergebnis.Zaehler + " / " + ergebnis.Nenner);
            ergebnis = Bruch.MultiplizierenStatic(bruch1, bruch2);
            Console.WriteLine(ergebnis.Zaehler + " / " + ergebnis.Nenner);
            ergebnis = bruch1 * bruch2;
            Console.WriteLine(ergebnis.Zaehler + " / " + ergebnis.Nenner);
            ergebnis = bruch1 / bruch2;
            Console.WriteLine(ergebnis.Zaehler + " / " + ergebnis.Nenner);

        }

    }
}



