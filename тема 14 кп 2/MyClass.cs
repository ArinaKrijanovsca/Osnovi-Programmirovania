using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace тема_14_кп_2
{ /// <summary>
/// Класс описывающий мой класс
/// </summary>
    internal class MyClass
    {
        /// <summary>
        /// внутренние нестатические поля вещественного типа
        /// </summary>
        double value1, value2;
        /// <summary>
        /// целочисленное статическое поле для подсчета созданных экземпляров класса
        /// </summary>
        static int count;
        /// <summary>
        /// нестатический конструктор с двумя параметрами
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public MyClass(double value1, double value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            count++;
        }
        /// <summary>
        ///  нестатический конструктор без параметров, который инициализирует внутренние поля 
        /// </summary>
        public MyClass()
        {
            this.Value1 = 2.0;
            this.Value2 = 2.0;
            count++;
        }
        /// <summary>
        /// статический конструктор, который инициализирует статическую переменную нулевым значением
        /// </summary>
        static MyClass()
        {
            count = 0;
        }
        /// <summary>
        /// свойства для доступа к внутренним полям класса Value1
        /// </summary>
        public double Value1
        {
            get
            {
                return value1;
            }
            set
            {
                value1 = value; 
            }
        }
        /// <summary>
        /// свойства для доступа к внутренним полям класса Value2
        /// </summary>
        public double Value2
        {
            get
            {
                return value2;
            }
            set
            {
                value2= value;
            }
        }
        /// <summary>
        /// метод для вывода на экран внутренних полей класса
        /// </summary>
        /// <returns></returns>
        public override string ToString ()
        {
            return $" value1={Value1}\tvalue2={value2}";
        }

    }
}
