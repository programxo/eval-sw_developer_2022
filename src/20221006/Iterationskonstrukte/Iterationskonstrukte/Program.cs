using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterationskonstrukte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Gandlaf";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Aktueller Wert: {i}");
                i--;
                i = 5;

            }
            bool inputIsVaild = false;

            while(!inputIsVaild)
            {
                Console.WriteLine("Tu was ...");
                inputIsVaild = true;    
            }

            do
            {
                Console.WriteLine("Tu was ...");
                inputIsVaild = true;
            }
            while(!inputIsVaild);






        }
    }
}
