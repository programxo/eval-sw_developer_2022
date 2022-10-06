using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teilnehmerverwaltung_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // SCHREIBEN IN EINE DATEI:

            StreamWriter sw = new StreamWriter("teilnehmerdaten.csv", true);
            sw.WriteLine(); // schreibt eine Zeile inkl. Zeilenumbruch
            Console.WriteLine();

            sw.Close();


        }
    }
}
