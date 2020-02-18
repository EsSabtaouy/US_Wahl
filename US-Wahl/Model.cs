using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_Wahl
{
    class Model//Umbenannt nach unseren Diagrammen
    {
        
        List<Person> people = new List<Person>();
        Person abfrage = from p in people where p.Contains(stichwort) select p; //Linq-abfrage
        

        public void abfrage()//Methode zur Linqabfrage
        {
            string stichwort;
            Liste<Person> ergebnis = new Liste<Person>();//Liste für die gefundenen Ergebnisse(temporär)
            Console.WriteLine("Gebe ein Suchstichwort ein:");//Eingabe des Stichworts (muss ggf für die einzelnen Attribute definiert werden)
            stichwort = Console.ReadLine();
            ergebnis = abfrage();
            foreach (Person item in ergebnis)//Ausgabe des gefundenen
	        {
                Console.WriteLine($"PersonenID: {item.ID}; Name: {item.Name}; Nachname: {item.Nachname};\n"+
                                    "Geschlecht: {item.geschlecht}; Schicht: {item.schicht}");
                Console.WriteLine();
	        }
            

        }

        public Wahlvolk()
        {
            Random zf = new Random();
            for (int i = 0; i < 1000; i++)
            {
                people.Add(new Person() {  Name=zf.Next()});
            }
        }

        public void addPerson()
        {
            for (int i = 0; i < 1000; i++)
            {
                people.Add();
            }
        }


    }
}
