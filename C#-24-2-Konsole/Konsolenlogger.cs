using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal class Konsolenlogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
