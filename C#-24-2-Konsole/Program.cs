using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            var haus = new Haus("gruen", 4);
            haus.Konselenausgabe();
            haus.Farbe = "Hallo";
            haus.Konselenausgabe();
            var haus2 = new Haus("gelb", 3);
            haus.Konselenausgabe();
            haus2.Konselenausgabe();
            Console.WriteLine(Haus.Anzahl());
        }       

    }
}



