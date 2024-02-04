using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_16_кп_2
{
    internal class Program
    {
        static void Main(string[] args)
        { // Задача 1
            //Console.Write("Введите первую дату:");
            //DateTime data= DateTime.Parse(Console.ReadLine());
            ////Console.Write("Введите вторую дату:");
            ////DateTime data1 = DateTime.Parse(Console.ReadLine());
            ////Console.WriteLine($"{data1.Subtract(data).Days}:дней между датами");
            ////Задача 2
            //Console.WriteLine($"До конца месяца осталось :{DateTime.DaysInMonth(data.Year,data.Month)-data.Day}");
            // задача 3 
            DateTime dateTime = new DateTime(2006, 05, 17);
            DateTime dateTime1 = new DateTime(2024, 05, 17);
            DateTime date = DateTime.Now;
            Console.WriteLine($"{dateTime.DayOfWeek}\n{dateTime.DayOfYear}\n{DateTime.IsLeapYear(dateTime.Year)}\n{dateTime1.ToString("dddd, d MMMM yyy")}\n{dateTime1.Subtract(date).TotalDays}");
            if (date.Month < dateTime1.Month)
            
            {
                Console.WriteLine($"Кол-во полных лет {date.AddYears(-dateTime.Year - 1).ToString("yyy")} ");
            }

            else if (date.Month == dateTime.Day)
            
                if (date.Day < dateTime1.Day)

                {
                    Console.WriteLine($"Кол-вл полных лет{date.AddYears(-dateTime.Year - 1)}");
                }
            else
                {
                    Console.WriteLine($"Колл-во полных лет {date.AddYears(-dateTime.Year).ToString(" yy ")}");
                }
            else
            {
                Console.WriteLine($"Кол-во полны лет {date.AddYears(-dateTime.Year).ToString(" yy ")}");
            }

            
            Console.ReadKey();

        }
    }
}
