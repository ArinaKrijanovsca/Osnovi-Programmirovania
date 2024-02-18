using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_2
{/// <summary>
/// наследуемый класс 
/// </summary>
    internal class Engineer:Employee
    {/// <summary>
    /// поле n описывающее колличество разработанных проектов 
    /// </summary>
        int n;
        /// <summary>
        /// свойство для поля n
        /// </summary>
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Engineer() { }
        /// <summary>
        /// конструктор с парметрами
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <param name="k"></param>
        /// <param name="n"></param>

        public Engineer(string surname, string name, int p, int k ,int n) :base(surname,name,p,k)
        {
           N = n;
        }
        /// <summary>
        /// метод вычисляющий доход
        /// </summary>
        /// <returns></returns>
        public override int Doxod()
        {
            return base.Doxod()*(n/10);
        }
        /// <summary>
        /// метод для вывода нформации
        /// </summary>

        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine($"Колличесво разрвботанных проектов:{n}");
        }




    }
}
