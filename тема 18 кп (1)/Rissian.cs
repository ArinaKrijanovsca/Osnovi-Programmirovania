using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп__1_
{
    internal class Rissian:Person
    {  public Rissian() { }
        public Rissian(string nmae) 
        {
        Name = nmae;
        }
        public override void Welcome() 
        {
            Console.WriteLine($"Привет{Name}");
        }
    }
}
