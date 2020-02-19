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

        public static void abfrage(List<Person> inputListe)//Methode zur Linqabfrage
        {
            int stichwort;
            string stichwortS;
            
            List<Person> ergebnis = new List<Person>();//Liste für die gefundenen Ergebnisse(temporär)
            Console.WriteLine("Gebe ein Suchstichwort ein:");//Eingabe des Stichworts (muss ggf für die einzelnen Attribute definiert werden)
            stichwortS = Console.ReadLine();              

            try{
            stichwort = Convert.ToInt32(stichwortS);
            var abfrage2= from p in inputListe where p.ID.Equals(stichwort) select p;
            ergebnis=abfrage2.ToList();
            }
            catch{
            var abfrage = from p in inputListe where p.Vorname.Contains(stichwortS)||p.Nachname.Contains(stichwortS) select p; //Linq-abfrage  
            ergebnis = abfrage.ToList();                   
            }

            foreach (Person item in ergebnis)//Ausgabe des gefundenen
	        {
                Console.WriteLine($"PersonenID: {item.ID}; Name: {item.Vorname}; Nachname: {item.Nachname};\n"+
                                    "Geschlecht: {item.geschlecht}; Schicht: {item.schicht}");
                Console.WriteLine();
	        }
            

        }

        public static List<Person> people(int menge)
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
