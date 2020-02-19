using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace US_Wahl
{
    class Wahlvolk
    {
        string[] Nachnamearray = File.ReadAllLines("nachnamen-UTF8.txt");
        string[] JungVornamearray = File.ReadAllLines("jungennamen.txt");
        string[] MädchenVornamearray = File.ReadAllLines("maedchennamen.txt");
        int count = 0;


        public List<Person> people(int menge)
        {
            List<Person> people = new List<Person>();
            Random zf = new Random();
            for (int i = 0; i <= menge-1; i++)
            {
                Thread.Sleep(1);
                people.Add(new Person());
             
           
            }
           
            return people;
        }
        public static void NamenInDateiSchreiben(List<Person> inputListe) {

            
            FileStream fs = File.Open("WählerListe.txt",FileMode.Create,FileAccess.ReadWrite,FileShare.None);
            
            StreamWriter sw = new StreamWriter(fs);
            
            foreach (Person person in inputListe)
            {
               // sw.WriteLine("Nachname : "+person.Nachname + "\t Vorname :" + person.Vorname + "\t Politische Heimat : " + person.politischeHeimat);
                sw.WriteLine("Nachname :  {0,-11} Vorname : {1,-11} Politische Heimat : {2,-11}", person.Nachname, person.Vorname, person.politischeHeimat);
            }
            sw.Flush();
            sw.Close();

        }
    }
}
