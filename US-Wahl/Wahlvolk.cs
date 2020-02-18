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

        List<Person> people = new List<Person>();


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
                people.Add()
            }
        }
    }
}
