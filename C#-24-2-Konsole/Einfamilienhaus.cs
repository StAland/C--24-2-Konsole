using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal class Einfamilienhaus : Haus
    {
        public Einfamilienhaus(int groesse, string farbe, int anzahlZimmer) : base(groesse, farbe, anzahlZimmer, 1)
        {

        }
    }
}
