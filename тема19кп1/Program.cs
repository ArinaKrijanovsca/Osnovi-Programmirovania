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
            Console.WriteLine("Площадь прямогугольника равна:");
            Console.WriteLine( rectangle.Area());
            Console.WriteLine("Периметр прямоугольника равен:");
            Console.WriteLine( rectangle.Perimeter());
            Console.WriteLine(rectangle.ToString());

            Triangle triangle=new Triangle("Треугольник",2,4,5);
            Console.WriteLine( triangle.Area());
            Console.WriteLine( triangle.Perimeter());
            Console.WriteLine(triangle.ToString());
            
            Circle circle = new Circle("Окружность", 6);
            Console.WriteLine(circle.ToString());
            Console.WriteLine( circle.Perimeter());
            Console.WriteLine( circle.Area());





            Console.ReadLine();


        }
    }
}
