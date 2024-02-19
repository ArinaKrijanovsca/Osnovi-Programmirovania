using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп__1_
{
   abstract internal class Person
    {
        public string name;

        public string Name { get => name; set => name = value; }

        public abstract void Welcome();
        
    }
}
