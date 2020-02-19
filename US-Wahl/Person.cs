using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace US_Wahl
{
    enum Geschlecht { Weiblich, Mänlich }
    enum Beeinflußbarkeit { Leicht, Mittel, Schwer }
    enum Schicht { UnterSchicht, UntermittelSchicht, OberemittelSchicht, ObereSchicht }
    enum PolitischeHeimat { Republikaner, Demokraten }
    class Person
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public  Geschlecht  geschlecht { get; set; }
        public Beeinflußbarkeit  beeinflußbarkeit { get; set; }
        public Schicht schicht { get; set; }
        public PolitischeHeimat politischeHeimat { get; set; }
        string[] Nachnamearray = File.ReadAllLines("nachnamen.txt");
        string[] JungVornamearray = File.ReadAllLines("jungennamen.txt");
        string[] MädchenVornamearray = File.ReadAllLines("maedchennamen.txt");
       

        public Person() {

            Random zf = new Random();
            geschlecht = (Geschlecht)(zf.Next(2));
            if (geschlecht ==  0){
                Nachname = Nachnamearray[zf.Next(1000)];
                Vorname = MädchenVornamearray[zf.Next(MädchenVornamearray.Length)];
                beeinflußbarkeit = (Beeinflußbarkeit)zf.Next(3);
                politischeHeimat = (PolitischeHeimat)zf.Next(2);
                schicht = (Schicht)zf.Next(4);
                ID = zf.Next(10000, 50000);
            }
            else
            {
                Nachname = Nachnamearray[zf.Next(1000)];
                Vorname = JungVornamearray[zf.Next(JungVornamearray.Length)];
                beeinflußbarkeit = (Beeinflußbarkeit)zf.Next(3);
                politischeHeimat = (PolitischeHeimat)zf.Next(2);
                schicht = (Schicht)zf.Next(4);
                ID = zf.Next(50001, 10000);

            }

          


        }


        //Random zf = new Random();


    }
}
