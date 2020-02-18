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
            List<Person> list = wahlvolk.people();




            string[] Nachnamearray = File.ReadAllLines("nachnamen");
            string[] JungVornamearray = File.ReadAllLines("nachnamen");
            string[] MädchenVornamearray = File.ReadAllLines("nachnamen");


            //Console.WriteLine(Nachnamearray.Length); 
            //Console.WriteLine(JungVornamearray.Length); 
            //Console.WriteLine(MädchenVornamearray.Length);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.geschlecht}   {item.Nachname}   {item.Vorname}  {item.politischeHeimat} {item.schicht} {item.beeinflußbarkeit}");
            }

            Console.ReadLine();
        }
    }
}
