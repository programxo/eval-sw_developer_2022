using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_29._09._2022
{
    internal class Program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("Hallo, mit dieser Console-Applikation können Sie die Fläche und den Umfang von einem Dreieck berechnen.");

          

            string seiteA = string.Empty;
            int a = 0;
            Console.Write($"Bitte geben Sie die Seite a ein: {seiteA}");
            seiteA = Console.ReadLine();
            a = int.Parse(seiteA);

            string seiteB = string.Empty;
            int b = 0;
            Console.Write($"Bitte geben Sie die Seite b ein: {seiteB}");
            seiteB = Console.ReadLine();
            b = int.Parse(seiteB);

            string seiteC = string.Empty;
            int c = 0;
            Console.Write($"Bitte geben Sie die Seite c ein: {seiteC}");
            seiteC = Console.ReadLine();
            c = int.Parse(seiteC);

            Console.WriteLine("Die Seiten a, b, c werden addiert um die Fläche zuberechnen");

            int summeUmfang = a + b + c;
            double summeFleache = (0.5 * c) * c;
            Console.WriteLine($"Der Umfang beträgt {summeUmfang} und die Fläche {summeFleache}.");



        } 
    }
}
