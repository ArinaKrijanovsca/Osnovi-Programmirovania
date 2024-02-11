using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача1
            //Person person = new Person(17);
            //person.Print();
            //Person person1 = new Person(17, "Арина");
            //person1.Print();
            //Person person2 = new Person(17, "Арина", "Крижановская");
            //person2.Print();
            //Employce empl = new Employce(17, "Арина", "Криажновская", "Dexp", "прогарммист");
            //empl.Print();
            //Person emp2 = new Employce(17, "Арина", "Крижановская ", "Dexp", "программист");
            //emp2.Print();
            //Students student = new Students(17, "Арина", "Криажановская",DateTime.Now,2);
            //student.Print();
            //List<Person> persons = new List<Person>();
            //persons.Add(new Person(17, "Арина", "Крижановская"));
            //persons.Add(new Employce(17, "Арина", "Крижановская", "Dexp", "программист"));
            //persons.Add(new Students(17, "Арина", "Криажановская", DateTime.Now, 2));
            //foreach (var st in persons)
            //{ st.Print(); }
            //Задача 2

            Press pres = new Press(5,"Сказки Пушкина",200);
            Console.WriteLine(pres.Cost());
            pres.Output();
            Magazine magazin = new Magazine(10, "Стихи Пушкина", 200, "midle");
            Console.WriteLine(magazin.Cost());
            magazin.Output();
            Press press1 = new Magazine(100,"Война и мир",200,"midle");
            press1.Output();
            Console.WriteLine(press1.Cost());
            Console.ReadKey();

        }
    }
}
