using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 41
            //Point <double> point = new Point<double>(6.2,5.5);
            //point.OutPut();
            //Point<int> point2 = new Point<int>(4, 7);
            //point2.OutPut();
            //Point<uint> point3 = new Point<uint>(77,25);
            //point3.OutPut();

            ///42
            Triangle<int> tr2 = new Triangle<int>(3,6,4);
            tr2.Print();
            Console.WriteLine($"Площадь{ tr2.S()}");
            Triangle<uint> tr3 = new Triangle<uint> (3u,6u,4u);
            tr3.Print();
            Console.WriteLine($"Площадь{tr3.S()}");
            Triangle<double> tr4 = new Triangle<double>(5.5, 8.6, 4.6);
            tr4.Print();
            Console.WriteLine($"Площадь{tr4.S()}");

            Console.ReadKey();
        }
    }
}
