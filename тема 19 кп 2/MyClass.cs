using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_2
{/// <summary>
/// класс в котором реалезован интерфейс 
/// </summary>
    internal class MyClass : IMyInterface1
    {/// <summary>
    /// реалезованный метод
    /// </summary>
    /// <returns></returns>
        public double GetPI()
        {
            return Math.PI;
        }
        /// <summary>
        /// реалезованный метод
        /// </summary>
        /// <returns>25</returns>
        public int CetIntegor()
        {
            return 25;
        }
        /// <summary>
        /// реалезованный метод
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double CetSqrt(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
