using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace тема_18_кп__1_
{
    internal class Moldovan:Person
    {
        public Moldovan() { }
        public Moldovan(string nmae)
        {
            Name = nmae;
        }
        public override void Welcome()
        {
            Console.WriteLine($"Буназиуа{name}");
        }

    }
}
