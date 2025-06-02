using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            var zaehler = 0;
            while (zaehler < 0)
            {
                Console.WriteLine("Kopf: " + zaehler);
                zaehler++;
            }

            zaehler = 0;
            do
            {
                Console.WriteLine("Fuss: " + zaehler);
                zaehler++;
            }while (zaehler < 0);
        }

    }
}



