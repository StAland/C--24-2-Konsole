using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    public class Bruch
    {
        public int Zaehler { get; set; }
        public int Nenner { get; set; }

        internal Bruch(int zaehler, int nenner)
        {
            Zaehler = zaehler;
            Nenner = nenner;
        }

        public Bruch Multiplizieren(Bruch bruch)
        {
            var nenner = this.Nenner * bruch.Nenner;
            var zahler = this.Zaehler * bruch.Zaehler;
            return new Bruch(zahler, nenner);
        }

        public static Bruch MultiplizierenStatic(Bruch bruch1, Bruch bruch2)
        {
            var nenner = bruch1.Nenner * bruch2.Nenner;
            var zahler = bruch1.Zaehler * bruch2.Zaehler;
            return new Bruch(zahler, nenner);
        }

        public static Bruch operator * (Bruch bruch1, Bruch bruch2)
        {
            var nenner = bruch1.Nenner * bruch2.Nenner;
            var zahler = bruch1.Zaehler * bruch2.Zaehler;
            return new Bruch(zahler, nenner);
        }
        public static Bruch operator / (Bruch bruch1, Bruch bruch2)
        {
            var zaehler = bruch1.Zaehler * bruch2.Nenner;
            var nenner = bruch1.Nenner * bruch2.Zaehler;
            return new Bruch(zaehler, nenner);
        }
    }
}
