using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_16_кп_3
{
    internal class Program
    {
        static void Main(string[] args)
        {// Здачча1
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            DateClass data1 = new DateClass(year,month,day);
            Console.WriteLine($"{ data1.Yesterday()}\t{data1.Tomorrow()}\t{data1.EndMonth()}");
            //Задача 2
            DateClass data2 = new DateClass(year,month,day);
            Console.WriteLine(data2.ToString());
            Console.ReadKey();
        }
    }
}
