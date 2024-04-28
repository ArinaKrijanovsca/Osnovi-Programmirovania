using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_20_кп_2
{/// <summary>
/// обощенный класс
/// </summary>
/// <typeparam name="T"></typeparam>
    internal class Triangle<T>
    {
        /// <summary>
        /// поле описывающее сторону а
        /// </summary>
        public T a;
        /// <summary>
        /// полек описывающее сторону б
        /// </summary>
        public T b;
        /// <summary>
        /// поле описывающее сторону с
        /// </summary>
        public T c;
        /// <summary>
        /// сввойтсво для поня а
        /// </summary>
        public T A { get; set; }
        /// <summary>
        /// свойство для поля б
        /// </summary>
        public T B { get; set; }
        /// <summary>
        /// свойтсво для поня с
        /// </summary>
        public T C { get; set; }
        /// <summary>
        /// конструткор с параметрами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(T a, T b, T c   )
        {
            A = a;
            B = b;
            C = c;
            
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public void Print   ( )
        {
            Console.WriteLine($"a={A},b={B},c={C}");
        }
        /// <summary>
        ///  метод, возвращающий площадь треугольника
        /// </summary>
        /// <returns></returns>
        public T S()
        {
            dynamic x = A;
            dynamic y = B;
            dynamic z= C; 
            dynamic p=(x+y+z)/3;
            return Math.Sqrt(p*(p-x)*(p-y)*(p-z));
        }

    }
}
