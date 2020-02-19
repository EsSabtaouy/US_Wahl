using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Person> list = Wahlvolk.people(1000);
            Wahlvolk.NamenInDateiSchreiben(list);
            Wahlvolk.abfrage(list);
            Console.ReadLine();

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.geschlecht}   {item.Nachname}   {item.Vorname}  {item.politischeHeimat} {item.schicht} {item.beeinflußbarkeit}");
            //}

            Console.ReadLine();
        }
    }
}
