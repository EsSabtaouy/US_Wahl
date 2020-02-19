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
            Wahlvolk wahlvolk = new Wahlvolk();
            List<Person> list = wahlvolk.people(2);
            Wahlvolk.NamenInDateiSchreiben(list);


            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.geschlecht}   {item.Nachname}   {item.Vorname}  {item.politischeHeimat} {item.schicht} {item.beeinflußbarkeit}");
            //}

            Console.ReadLine();
        }
    }
}
