using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_2__5_pзадание_
{/// <summary>
/// класс в котором реалезован интерфкйс 
/// </summary>
    internal class PersonalComputer:ISwitchable
    {  /// <summary>
    /// реалезованный метод 
    /// </summary>
        public void On()
        {
            Console.WriteLine("Компьютер включен");
        }
        /// <summary>
        /// реалезованный метод 
        /// </summary>
        public void Off() 
        {
            Console.WriteLine("Компьютер выключен");
        }
    }
}
