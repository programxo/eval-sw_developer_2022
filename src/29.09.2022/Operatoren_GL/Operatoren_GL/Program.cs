using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetische Operatoren
            // + - * / %

            int x = 0;
            int a = 4;
            int b = 2;
            int summe = 0;

            summe = 8 * (a + b) - 15;
            // summe = Math.Sin() // Math sehr viele Methoden

            // Logische Operatoren
            // % | && || ^ ! >> << ...

            bool isPowerOn = true;
            bool dataValid = false;

            bool processing = isPowerOn & dataVaild; // und beide true dann Ergebnis true
            bool processing = isPowerOn | dataVaild; // oder eines 
            bool processing = isPowerOn && dataVaild; // und 
            bool processing = isPowerOn || dataVaild; // 

            bool processing = isPowerOn && dataVaild;
            processing = !dataValid;
            // if(data != null && data.IsValid)
            //{

            //}

            // Vergleichsoperatoren
            // > < == != >= <=

            // Zusammengesetzte Operatoren

            int zahl = 10;

            zahl = zahl / 5;
            zahl /= 5;

            zahl = zahl + 1;
            zahl += 1;
            zahl++; // Increment
            zahl--; // Dekrement

            ++zahl; // oder so zuerst OP danach V!

        }
    }
}
