using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenTypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            int zahl;

            //Console.WriteLine(zahl); == GEHT NICHT!

            //Initialisierung
            zahl = 5;

            //Deklaration & Initialisierung
            int zahl2 = 56;

            //

            Console.WriteLine(int.MinValue); // mit verschiedenen Datentypen möglich
            Console.WriteLine(int.MaxValue); // mit verschiedenen Datentypen möglich

            string vorName = "Tiger"; // Unbegrentzte Menge

            vorName = ""; // Leerer String
            vorName = string.Empty; // Leerer String mit Methode

            bool isPowerOn = true;

            float flt = 1.5f; // Mit "f" als float verständlich, nicht das genauste

            double gewicht = 15.654655; // Sehr genau

            decimal gehalt = 1654.321m; // Mit "m" als decimal verständlich, verbraucht sehr viel Power

            char sign 'd'; 

        }
    }
}
