using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема19кп1
{/// <summary>
/// интерфейс с 2 методами
/// </summary>
    internal interface MyInterface
    {
       /// <summary>
       /// метод нахождения площади
       /// </summary>
       /// <returns></returns>
          double Area();
        /// <summary>
        ///  метод нахождения периметра
        /// </summary>
        /// <returns>периметр</returns>
         double Perimeter();
    }
}
