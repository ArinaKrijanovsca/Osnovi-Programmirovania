using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_17_кп_3
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Meneger:Staff
    { 
        /// <summary>
        /// поле ob описывающее объем продаж
        /// </summary>
        int ob;
        /// <summary>
        /// свойтво для поля ob
        /// </summary>
        public int Ob { get => ob; set => ob = value; }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dataB"></param>
        /// <param name="p"></param>
        /// <param name="ob"></param>
        public Meneger(string name, string surname, DateTime dataB, int p,int ob) :base(name,surname,dataB,p)
        {
        Ob = ob;
        }
        /// <summary>
        /// метод для вывлда инфоррмации
        /// </summary>
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine($"Объем продаж:{ob}");
        }
        /// <summary>
        /// метод доход
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public override int Doxod (int k,int n)
        {
            if (n < ob)
            {
                return base.Doxod(k, n);
            }
            else { return base.Doxod(k, n); }
        }
    }
}
