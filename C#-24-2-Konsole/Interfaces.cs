using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal interface ISpeicherbar
    {
        public void Speichern();
    }
    internal interface IDruckbar
    {
        public void Drucken();
    }

    internal interface IPrintable
    {
        public void Drucken(string filepath);
    }
}
