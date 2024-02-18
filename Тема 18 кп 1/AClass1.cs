using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_18_кп_1
{/// <summary>
/// абстрактный класс
/// </summary>
    abstract internal class AClass1
    {
        /// <summary>
        /// обычный метод
        /// </summary>
        public void Metod1()
        {
            Console.WriteLine($" метод Metod1 из абстрактного класса AClass1 ");
        }
        /// <summary>
        /// вирутальный метод
        /// </summary>
        public virtual void Metod2()
        {
            Console.WriteLine($"в методе Metod2 из абстрактного класса AClass1 ");
        }
        /// <summary>
        /// асбстрактный метод
        /// </summary>
        public abstract void Metod3();
        /// <summary>
        /// вбстрактный метод
        /// </summary>
        public abstract void Metod4();

    }
}
