using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_19_кп__2__
{/// <summary>
/// Класс, в котором реалезуется интерфейс
/// </summary>
    internal class DerivedClass:IInterface3
    {/// <summary>
    /// реалезованный метод
    /// </summary>
        public void Method1()
        {
            Console.WriteLine(" Метод Method1");
        }
        /// <summary>
        /// реалезованный метод
        /// </summary>
        public void Method2()
        {
            Console.WriteLine(" Метод Method2");
        }
        /// <summary>
        /// реалезованный метод
        /// </summary>
        public void Method3()
        {
            Console.WriteLine(" Метод Method3");
        }

    }
}
