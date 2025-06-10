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

        public int AnzahlZimmer {  get; set; }

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
            AnzahlZimmer = anzahlZimmer;
        }



        internal void Konselenausgabe()
        {
            Console.WriteLine($"Das Haus hat {AnzahlZimmer} Zimmer und ist {_farbe}");
        }
    }
}
