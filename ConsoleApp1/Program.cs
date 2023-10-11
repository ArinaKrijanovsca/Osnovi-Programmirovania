using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 
            Console.Title = "Тема №4 Компьютерный практикум №1(Крижановская)";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(60, 25);
            Console.WriteLine(Console.CapsLock);
            Console.WriteLine(Console.NumberLock);
            Console.WriteLine("Введите имя:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Здравствуйте {name}");
            Console.ReadKey();
        }
    }
}
