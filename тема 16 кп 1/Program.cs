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
            //DateTime date2 = new DateTime(2022, 1, 25, 21, 30, 25);
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
            Console.WriteLine("Введите дату:");
            DateTime oneDite=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату:");
            DateTime twoDite = DateTime.Parse(Console.ReadLine());
            TimeSpan timeDifference = oneDite - twoDite;
            Console.WriteLine($" Колличество дней между датами:{timeDifference}");

            Console.ReadKey();
        }
    }
}
