using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl
{
    class Wahlvolk
    {
        string[] Nachnamearray = File.ReadAllLines("nachnamen");
        string[] JungVornamearray = File.ReadAllLines("nachnamen");
        string[] MädchenVornamearray = File.ReadAllLines("nachnamen");


        public List<Person> people()
        {
            List<Person> people = new List<Person>();
            Random zf = new Random();
            for (int i = 0; i <= 1000; i++)
            {
                
                people.Add(new Person() { Nachname = Nachnamearray[zf.Next(1001)],Vorname = JungVornamearray[zf.Next(1001)], geschlecht = (Geschlecht)zf.Next(2),
                beeinflußbarkeit = (Beeinflußbarkeit)zf.Next(3), politischeHeimat = (PolitischeHeimat)zf.Next(2), schicht = (Schicht)zf.Next(4)
            });
            }
           
            return people;
        }
        
    }
}
