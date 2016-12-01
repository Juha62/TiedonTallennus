using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonLukuConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string Tiedosto = @"c:\Temp\New1.xml";

            if (File.Exists(Tiedosto))
            {
                string aiempitiedosto = File.ReadAllText(Tiedosto);
                Console.WriteLine(aiempitiedosto);
                Console.ReadLine();
            }
        }
    }
}
