using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_20_кп_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> t1 = new Triangle<int>(13, 15, 19);
                t1.Print();
            Console.WriteLine($"Площадь:{t1.S()}");
            Triangle<uint> t2 = new Triangle<uint>(13, 15, 19);
            t2.Print();
            Console.WriteLine($"Площадь:{t2.S()}");
            Triangle<double> t3 = new Triangle<double>(13, 15, 19);
            t3.Print();
            Console.WriteLine($"Площадь:{t3.S()}");
            Console.ReadLine();
        }
    }
}
