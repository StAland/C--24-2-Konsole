using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal class Haus 
    {
        private string _farbe;
        private bool _locked = false;

        public int AnzahlZimmer { get; set; }
        public Tuer Haustuer { get; set; }

        public class Tuer
        {
            public void Aufschliessen()
            {

            }
        }

        private static int _anzahl = 0;
        public static int Anzahl()
        {
            return _anzahl;
        }

        public string Farbe 
        {
            set
            {
                string[] erlaubteFarben = ["gelb", "gruen", "blau"];
                if (erlaubteFarben.Contains(value))
                {
                    _farbe = value;
                }
            }
            get 
            { 
                return _farbe;
            } 
        }

        internal Haus(string farbe, int anzahlZimmer)
        {
            Farbe = farbe;
            if (string.IsNullOrEmpty(_farbe))
            {
                _farbe = "gelb";
            }
            AnzahlZimmer = anzahlZimmer;
            _anzahl += 1;
        }

        internal void Aufschliessen()
        {
            if (_locked)
            {
                _locked = false;
                Console.WriteLine("Das Haus ist jetzt aufgeschlossen.");
            }
            else
            {
                Console.WriteLine("Das Haus ist bereits aufgeschlossen");
            }
        }

        internal void Zuschliessen()
        {
            if (_locked)
            {
                _locked = true;
                Console.WriteLine("Das Haus ist jetzt zugeschlossen.");
            }
            else
            {
                Console.WriteLine("Das Haus ist bereits zugeschlossen");
            }
        }

        internal void Konselenausgabe()
        {
            Console.WriteLine($"Das Haus hat {AnzahlZimmer} Zimmer und ist {_farbe}");
        }
    }
}
