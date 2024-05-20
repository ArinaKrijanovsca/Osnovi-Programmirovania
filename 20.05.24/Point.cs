using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{/// <summary>
/// 41 задача
/// </summary>
/// <typeparam name="T"></typeparam>
    internal class Point<T>
    {
       private T x;
       private T y;

        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }
        public Point() { }
        public Point (T x,T y)
        {
           X = x; 
            Y = y;
        }
        public void OutPut ()
        {
            Console.WriteLine($"Сторона 1:{X}\nСторона 2:{Y}");
        }

    }
}
