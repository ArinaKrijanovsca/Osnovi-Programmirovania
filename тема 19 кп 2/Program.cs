using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    DerivedClass dClass = new DerivedClass();
        //    dClass.Method();
        //    IInterface1 interface1 = dClass;

            MyClass my = new MyClass();
            int x = 25;
            Console.WriteLine(my.GetPI());
            Console.WriteLine(my.CetSqrt(x));
            Console.WriteLine(my.CetIntegor());

            Console.ReadLine();

        }
    }
}
