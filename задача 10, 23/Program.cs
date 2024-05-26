using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10__23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Vehicle> vehicles = new List<Vehicle>() {
            //new Car(34.324124,14.2421345,200000,360,2022,680,"BMW"),
            //new Ship(44.324124,54.2421345,2000000,70,2023,100,"Gawai"),
            //new Plane(14.324124,24.2421345,3000000,200,2020,5000,150)
            //};
            //foreach (var item in vehicles)
            //{
            //    Console.WriteLine(item.Print());
            //}
            //Console.ReadLine();

           
            {
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                Console.WriteLine("Каким цветом вывести текст");
                foreach (Pat.Colors colors in Enum.GetValues(typeof(Pat.Colors)))
                {
                    Console.WriteLine($"{(int)colors} - {colors}");
                }
                Console.WriteLine("Введите цифру цвета:");
                int color = int.Parse(Console.ReadLine());
                Pat.Print(str, color);
                Console.ReadLine();
            }
        }
    }
}
