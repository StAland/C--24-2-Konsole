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
        private int _anzahlZimmer;

        internal Haus(string farbe, int anzahlZimmer)
        {
            _farbe = farbe;
            _anzahlZimmer = anzahlZimmer;
        }

        public string getFarbe()
        {
            return _farbe;
        }

        public void setFarbe(string farbe)
        {
            string[] erlaubteFarben = ["gruen", "gelb", "blau"];
            if (erlaubteFarben.Contains(farbe))
            {
                _farbe = farbe;
            }
        }

        internal void Konselenausgabe()
        {
            Console.WriteLine($"Das Haus hat {_anzahlZimmer} Zimmer und ist {_farbe}");
        }
    }
}
