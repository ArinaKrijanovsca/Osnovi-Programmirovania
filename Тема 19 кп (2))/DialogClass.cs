using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_19_кп__2__
{/// <summary>
/// класс, в которм реалезуется 2 интерфейса
/// </summary>
    internal class DialogClass : IInterface1fase , IInterface2fase
    {/// <summary>
     /// реалезованный метод Method1()
     /// </summary>
        public void Method1()
        {
            Console.WriteLine("Говорит - Я люблю прагроммирование!");
        }
        /// <summary>
        /// реалезованный метод Method2()
        /// </summary>
        public void Method2()
        {
            Console.WriteLine("Думает - А С# больше всего");

        }
        /// <summary>
        /// реалезованный метод Method3()
        /// </summary>
        public void Method3()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры ");
        }

    }

    
}
