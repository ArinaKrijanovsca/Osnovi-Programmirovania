using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_20_кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcilator<int> c1= new Calcilator<int>();
            Console.WriteLine(c1.Add(10,11));
            Console.WriteLine(c1.Sub(12, 10));
            Console.WriteLine(c1.Mul(13, 12));
            Console.WriteLine(c1.Div(10, 2));
            Calcilator<double> c2 = new Calcilator<double>();
            Console.WriteLine(c2.Add(12.5, 4.2));
            Console.WriteLine(c2.Sub(15.5, 5));
            Console.WriteLine(c2.Mul(20.4, 12));
            Console.WriteLine(c2.Div(16.5, 2));
            Calcilator<string> c3 = new Calcilator<string>();
            Console.WriteLine(c3.Add("14.8", "13"));
            Console.WriteLine(c3.Sub("18", "10"));
            Console.WriteLine(c3.Mul("9", "12"));
            Console.WriteLine(c3.Div("13", "5.2"));
            Console.ReadLine();

        }
    }
}
