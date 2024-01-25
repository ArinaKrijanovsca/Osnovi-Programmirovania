using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace тема_16_кп_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //DateTime date1 = new DateTime(2022, 1, 20);
            //Console.WriteLine(date1);
            //DateTime date2 = new DateTime(2022, 1, 25 ,21,30,25);
            //Console.WriteLine(date2.DayOfWeek);
            //Console.WriteLine(date2.Month);
            //Console.WriteLine(date2.Year);
            //Console.WriteLine(date2.ToLongDateString());
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(date2.ToLongDateString());
            //Console.WriteLine(date2.ToShortTimeString());
            //Console.Write($"{date2.DayOfWeek}\t{date2.Day}\t" +
            //    $"{date2.Month}\t{date2.Year}\t{date2.TimeOfDay}" +
            //    $"");
            //Задание 2 
            DateTime date3 = new DateTime(2006, 5, 20);
            Console.WriteLine($"Ты родился в {date3.Year}году\t{date3.Month}месяца\t{date3.Day}числа");

            Console.ReadKey();
        }
    }
}
