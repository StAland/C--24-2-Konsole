using System;

namespace C__24_2_Konsole
{


    internal class Program
    {

        static void Main(string[] args)
        {
            //var zaehler = 0;
            //while (zaehler < 0)
            //{
            //    Console.WriteLine("Kopf: " + zaehler);
            //    zaehler++;
            //}

            //zaehler = 0;
            //do
            //{
            //    Console.WriteLine("Fuss: " + zaehler);
            //    zaehler++;
            //} while (zaehler < 0);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0;i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadLine();

            var liste = new List<string>();
            liste.Add("Hallo");
            liste.Add("Steffen");


            foreach (string s in liste)
            {
                Console.WriteLine(s);
            }

            liste.ForEach(x => Console.WriteLine(x));
        }

    }
}



