using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_20_кп1
{
    internal class Calcilator<T>
    {/// <summary>
    /// поле описывающее у
    /// </summary>
        public dynamic x;
        /// <summary>
        /// поле описывающее х
        /// </summary>
        public dynamic y;
        /// <summary>
        /// метод реалезующий сложения
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <returns></returns>
        public T Add(T x1, T y1)
        {
            dynamic x =  x1;
            dynamic y = y1;
            return x + y;
        }
        public T Sub(T x1, T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            return x -1;
        }
        /// <summary>
        /// метод реалезующий  сложение
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <returns></returns>
        public T Mul(T x1, T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            return x + y;
        }

        /// <summary>
        /// иетод реалезующий деление 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <returns></returns>
        public T Div(T x1, T y1)
        {
            dynamic x = x1;
            dynamic y = y1;
            if (y!=0)
            {
                return x / y;
            }
            else
            {
                return y;
            }
        }

    }
}
