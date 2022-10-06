using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0;

            int[] zahlenliste = new int[5];

            zahlenliste[0] = -1;
            zahlenliste[1] = -1;
            zahlenliste[2] = -1;
            zahlenliste[3] = -1;
            zahlenliste[4] = -1;

            for (int i = 0; i < zahlenliste.Length; i++)
            {
                zahlenliste[i] = -1;
            }

            Console.WriteLine(zahlenliste);
        }
    }
}
