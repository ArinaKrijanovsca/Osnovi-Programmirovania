using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() { new Person("Аретм",22),new Person ("Илья",34),new Person("Леонид",24), new Person("Борис", 43) };
            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }
            list.Sort();
            Console.WriteLine("\nSort complete\n");
            foreach (Person person in list)
            { 
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();
        }
    }
}
