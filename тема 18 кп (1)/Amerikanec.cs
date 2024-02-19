using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace тема_18_кп__1_
{
    internal class Amerikanec:Person
    {

        public Amerikanec() { }
        public Amerikanec(string nmae)
        {
            Name = nmae;
        }
        public override void Welcome()
        {
            Console.WriteLine($"Hello{name}");
        }
    }
}
