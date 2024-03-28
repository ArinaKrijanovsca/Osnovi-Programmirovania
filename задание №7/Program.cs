using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3; // значение катета a
            double b = 4; // значение катета b
            double h = 5; // значение высоты h
            double R1 = 2; // радиус основания R1
            double R2 = 1; // радиус основания R2

            // Находим гипотенузу прямоугольного треугольника
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Гипотенуза треугольника: " + c);

            // Находим площадь и периметр треугольника
            double S = 0.5 * a * b;
            double P = a + b + c;
            Console.WriteLine("Площадь треугольника: " + S);
            Console.WriteLine("Периметр треугольника: " + P);

            // Находим объем и площадь поверхности призмы
            double V_prism = 0.5 * a * b * h;
            double S_prism = 2 * (a * b + a * h + b * h);
            Console.WriteLine("Объем призмы: " + V_prism);
            Console.WriteLine("Площадь поверхности призмы: " + S_prism);

            // Находим площадь поверхности кругового усеченного конуса
            double L = Math.Sqrt(Math.Pow((R1 - R2), 2) + Math.Pow(h, 2)); // образующая
            double S_cone = Math.PI * R1 * R1 + Math.PI * R2 * R2 + Math.PI * R1 * L;
            Console.WriteLine("Площадь поверхности кругового усеченного конуса: " + S_cone);

            Console.ReadKey();

        }
    }
}
