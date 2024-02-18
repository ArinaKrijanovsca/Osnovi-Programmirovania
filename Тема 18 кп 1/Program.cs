using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_18_кп_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived der = new Derived();
            der.Metod1();
            der.Metod2();
            der.Metod3();
            der.Metod4();
            AClass1 aC1 = new Derived();
            aC1.Metod1();
            aC1.Metod2();
            aC1.Metod3();
            aC1.Metod4();

            Console.ReadKey();
        }
    }
}
