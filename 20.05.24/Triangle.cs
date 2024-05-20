using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{/// <summary>
/// 42 задача
/// </summary>
/// <typeparam name="T"></typeparam>
    internal class Triangle<T>
    {
        private T a;
        private T b;
        private T c;

        public T A { get => a; set => a = value; }
        public T B { get => b; set => b = value; }
        public T C { get => c; set => c = value; }
        public Triangle() { }
        public Triangle(T a, T b, T c)
        {

            A = a;
            B = b;
            C = c;

        }
        public double S()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            dynamic p=(a1+ b1+c1)/2;
            return Math.Sqrt(p*(p-a1)*(p-b1)*(p-c1));

        }

        public void Print ()
        {
            Console.WriteLine($"{A}\n{B}\n{C}" );
        }

    }
}
