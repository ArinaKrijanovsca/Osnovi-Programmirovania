using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_15_кп_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[3];
            for (int i = 0; i < students.Length; i++)
            {
                string surname = Console.ReadLine(),
                    name = Console.ReadLine(),
                    otchestvo = Console.ReadLine(),
                    pol = Console.ReadLine();

                students[i] = new Students(surname, name, otchestvo, pol);
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine($" men-{Students.countm}\twomen-{Students.countw}");
             Console.ReadKey();  
        
        }
    }
}




