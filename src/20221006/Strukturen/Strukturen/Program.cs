using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturen
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            Teilnehmer teilnehmer = new Teilnehmer();

            teilnehmer.Name = "Mindaz";
            teilnehmer.Nachname = "Golp";
            teilnehmer.Geburtsdatum = DateTime.Today;
            teilnehmer.Wohnort = "Mars";

            Console.WriteLine(teilnehmer.Name);


        }
    }
}
