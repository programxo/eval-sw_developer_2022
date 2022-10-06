using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeilnehmerVerwaltungV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            * Wir wollen eine kleine Applikation zur (Kurs)Teilnehmerverwaltung schreiben.
            * 1.) Folgende Daten pro Teilnehmer sollen eingelesen werden:
            * 
            * - Name + Vorname
            * - Geburtsdatum
            * - Wohnort
            */

            Console.WriteLine("Willkommen, bitte geben Sie die Teilnehmer-Daten ein.");

            bool inputIsValid = true;

            do
            {
                string _name = string.Empty;

                if (String.IsNullOrEmpty(_name)) ;
                {
                    Console.WriteLine("Name: ");
                    _name = Console.ReadLine();
                    inputIsValid = true;
                }
                else
                {
                    !inputIsValid;
                }
                
                
                    Console.WriteLine("Sie haben keinen gültigen Namen eingegeben.");

                
                string _vorname = string.Empty;

                if (String.IsNullOrEmpty(_vorname)) ;
                {
                    Console.WriteLine("Vorname: ");
                    _vorname = Console.ReadLine();
                    inputIsValid = true;

                }
               
                
                    Console.WriteLine("Sie haben keinen gültigen Vornamen eingegeben.");


                string _geburtsdatum = string.Empty;

                if (String.IsNullOrEmpty(_geburtsdatum)) ;
                {
                    Console.WriteLine("Geburtsdatum: ");
                    _geburtsdatum = Console.ReadLine();
                    inputIsValid = true;

                }
                
                
                    Console.WriteLine("Sie haben keinen gültigen Geburtsdatum eingegeben.");
                

                string _wohnort = string.Empty;

                if (String.IsNullOrEmpty(_wohnort)) ;
                {
                    Console.WriteLine("Wohnort: ");
                    _wohnort = Console.ReadLine();
                    inputIsValid = true;

                }
                
                
                    Console.WriteLine("Sie haben keinen gültigen Wohnort eingegeben.");
                    inputIsValid = true;
                
            }
            while (!inputIsValid);






            // 2.) Es sollen beliebig viele Teilnehmer erfasst werden.

           


            /* 3.) Teilnehmer-Daten (=alle Daten pro Session in eine Datei) 
            *     sollen in einer csv-Datei gespeichert werden.
            *     Aufbau der csv-Datei:
            *     [Vorname],[Nachname],[Geb.Datum],[Wohnort]
            *     
            * */






            // 4.) autom. Altersbeschränkung einbauen ==> T > 18 < 110 Jahre



            // 5.) Fehlertolerante Umsetzung, d.h. Fehleingaben führen zu Wiederholung


            //schreiben in eine Datei:
            StreamWriter sw = new StreamWriter("teilnehmerdaten.csv", true);
            sw.WriteLine();  //schreibt eine Zeile inkl. Zeilneumbruch
            Console.WriteLine();

            sw.Close();

            // von Trainer


        }
    }
}
