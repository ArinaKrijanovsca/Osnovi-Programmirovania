using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Тема_16_кп_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff[] staffs = new Staff[1];
            for (int i = 0; i < staffs.Length; i++)
            {
                int nomber = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                string ochestvo = Console.ReadLine();
                DateTime data = DateTime.Parse(Console.ReadLine());
                string doljnost = Console.ReadLine();
                double oclad = double.Parse(Console.ReadLine());

                staffs[i] = new Staff(nomber, name, surname, ochestvo, data, doljnost, oclad);
            }
                foreach (var staff in staffs)

                {
                    Console.WriteLine(staff.ToString());
                }
            
           Console.ReadKey();
        }
    }
}
