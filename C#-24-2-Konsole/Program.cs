using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            var meinHaus = new Einfamilienhaus(100, "gelb", 4);
            Gebaeude meinGebaeude = meinHaus;
            //meinGebaeude = new Gebaeude(100);           
            Einfamilienhaus immerNochMeinHaus = (Einfamilienhaus)meinGebaeude;
            Console.WriteLine(immerNochMeinHaus.Farbe);
        }

    }
}



