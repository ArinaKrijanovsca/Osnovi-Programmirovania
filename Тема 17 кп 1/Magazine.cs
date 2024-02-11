using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Magazine:Press
    {/// <summary>
    /// поле описывающее качксвтво
    /// </summary>
        string quality;
        /// <summary>
        /// свойство для поля качсетво
        /// </summary>
        public string Quality 
        {
            get { return quality; }
            set { quality = value; }
        }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="copies"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quality"></param>
      public Magazine(int copies, string name, int price,string quality):base(copies,name,price)
      { 
            int i=int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:quality = "higt"; break;
                case 2:quality = "midle";break;
                case 3:quality = "low";break;
                default:Console.WriteLine("Ho");break;
            }
      
      }/// <summary>
       /// метод Cost для вычисления стоимости тиража
       /// </summary>
       /// <returns></returns>
        public new double Cost()
        {
            if (quality == "higt")
            {
                return base.Cost() + (base.Cost() * 0.1);
            }
            else if (quality == "mide")
            {
                return (base.Cost());
            }
            else if (quality == "low")
            {
                return (base.Cost() + base.Cost() * 0.1);

            }
            else { return 0; }
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public  void OutPut ()
        {
            base.Output();
            Console.WriteLine($"Качество:{quality}\n");
        }





    }
}
