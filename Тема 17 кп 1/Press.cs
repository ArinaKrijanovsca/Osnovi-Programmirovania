using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{/// <summary>
/// базовый класс
/// </summary>
    internal class Press
    {/// <summary>
    /// поле описывающее копии
    /// </summary>
        int copies;
        /// <summary>
        /// поле описывающее имя 
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее прайс
        /// </summary>
        int price;
        /// <summary>
        /// свойство для поля копии
        /// </summary>
        public int  Copies
        {
            get { return copies; }
            set { copies = value; }
        } 
        /// <summary>
        ///свойство для поля имя  
        /// </summary>
         public string Name
         {
            get { return name; }
            set { name = value; }
         }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Press() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="copies"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Press(int copies, string name,int price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }
        /// <summary>
        /// метод Cost
        /// </summary>
        /// <returns></returns>
        public int Cost() 
        {
        return price*price;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public  void Output()
        {
            Console.WriteLine($"Копии:{copies}\nИмя:{name}\nПрайс:{price}");
        }
       




    }
}
