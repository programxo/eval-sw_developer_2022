using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Anweisungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0;

            if(zahl > 10&& zahl < 30)
            {
                
                Console.WriteLine("Zahl ist größer als 10");

            }
            else
            {
                Console.WriteLine("Leider keine gültige Zahl");
            }

            // else if ...

            zahl = 4;

            switch (zahl)
            {
                case 4:
                    Console.WriteLine("Das war eine Vier");
                    break;

                case 5:
                    Console.WriteLine("Das war eine Fünf");
                    break;

                default:
                    Console.WriteLine("Keine Ahnung");
                    break;
            }
        }
    }
}
