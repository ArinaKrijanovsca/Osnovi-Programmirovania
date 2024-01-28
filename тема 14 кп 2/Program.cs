
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_14_кп_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass  myclass1 = new MyClass();
            MyClass myclass2 = new MyClass(20,30);
            Console.WriteLine(myclass2.ToString());
            Console.ReadKey();
        }
    }
}
