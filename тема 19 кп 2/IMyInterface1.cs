using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_2
{/// <summary>
/// интерфейс с 3 методами
/// </summary>
    internal interface IMyInterface1
    {/// <summary>
     /// метод, возвращающий число PI
     /// </summary>
     /// <returns></returns>
        double GetPI();
        /// <summary>
        /// метод, возвращающий число типа int
        /// </summary>
        /// <returns></returns>
        int CetIntegor();
        /// <summary>
        /// метод, возвращающий x в квадрате
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double CetSqrt(int x);
    }
}
