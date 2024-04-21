using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_3
{
    internal class Person:ICompareTo
    {
        string Name {  get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
        public override string ToString()
        {
            return $" Имя:{Name}\tВозраст:{Age}";
        }
    }
}
