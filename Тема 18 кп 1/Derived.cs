using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_18_кп_1
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Derived: AClass1
    {
        /// <summary>
        /// абстактный метод
        /// </summary>
        public  override void Metod2()
        {
            Console.WriteLine($"метод Metod2 из абстрактного класса AClass1,реализуется в классе Derived ");
        }
        /// <summary>
        /// виртуальный метод
        /// </summary>
        public override void Metod3()
        {
            Console.WriteLine($"обстрактный метод Metod3 из абстрактного класса AClass1, реализуется в классе Derived");
        }
        public override void Metod4()
        {
            Console.WriteLine($"обстрактный метод Metod4 из абстрактного класса AClass1 ,реализуется в классе Derived");
        }
    }
}
