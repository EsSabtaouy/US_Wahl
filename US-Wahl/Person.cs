using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Random zf = new Random();
        
        
    }
}
