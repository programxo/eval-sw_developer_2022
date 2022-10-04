using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_29._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHallo, mit dieser Console-Applikation können Sie den Umfang und die Fläche von einem Dreieck berechnen.");
            string seiteA = string.Empty;
            double a = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"\n\tBitte geben Sie die Seite a in cm ein: {seiteA}");
            seiteA = Console.ReadLine();


            string seiteB = string.Empty;
            double b = 0;
            Console.Write($"\tBitte geben Sie die Seite b in cm ein: {seiteB}");
            seiteB = Console.ReadLine();

            string seiteC = string.Empty;
            double c = 0;
            Console.Write($"\tBitte geben Sie die Seite c in cm ein: {seiteC}");
            seiteC = Console.ReadLine();

            try
            {
                a = double.Parse(seiteA);
                b = double.Parse(seiteB);
                c = double.Parse(seiteC);

                double p = (a + b + c) / 2;
                double summeUmfang = a + b + c;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"\nDer Umfang eines Dreiecks ist die Summe der einzelnen Seitenlängen a, b und c.\nUm den Umfang eines Dreiecks zu berechnen, zählst du also alle Seitenlängen zusammen (U= a + b + c).\nSomit beträgt der Umfang: {summeUmfang} cm");
                double summeFleache = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"\nDie Fläche beträgt: {summeFleache} cm²\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"\nDie Eingaben können nicht in Text-Format eingegeben werden, bitte geben Sie die Eingaben in Zahlen nochmals ein.\nFehlermeldung: {ex.Message}\n");

            }
        }
    }
}
