using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема19кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Rectangle rectangle = new Rectangle("Прямоугольник", 2, 4);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Площадь прямогугольника равна:");
            Console.WriteLine( rectangle.Area());
            Console.WriteLine("Периметр прямоугольника равен:");
            Console.WriteLine( rectangle.Perimeter());
            
            Triangle triangle=new Triangle("Треугольник",2,4,5);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("Площадь треугольника равна:");
            Console.WriteLine( triangle.Area());
            Console.WriteLine("Периметр треугольника равен:");
            Console.WriteLine( triangle.Perimeter());
            
            
            Circle circle = new Circle("Окружность", 6);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("Площадь окружности равна:");
            Console.WriteLine( circle.Area());
            Console.WriteLine("Периметр окружности равен:");
            Console.WriteLine( circle.Perimeter());





            Console.ReadLine();


        }
    }
}
