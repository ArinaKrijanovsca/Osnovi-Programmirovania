using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_17_кп_3
{/// <summary>
/// базовый класс сотрудники
/// </summary>
    internal class Staff
    {/// <summary>
    /// поле описывающее имя , фаимлию
    /// </summary>
        string name, surname;
        /// <summary>
        /// поле описывающее дату рождения 
        /// </summary>
        DateTime dateB;
        /// <summary>
        /// поле описывающее минимальную зарплату
        /// </summary>
        int p;
        /// <summary>
        /// свойтво для поля имя
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// свойство для поля фамилия 
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// свойтво для поля дата рождения 
        /// </summary>
        public DateTime DateB { get => dateB; set => dateB = value; }
        /// <summary>
        /// свойтво для поля p
        /// </summary>
        public int P { get => p; set => p = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Staff() { }
        /// <summary>
        /// конструкто с парамтерами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dataB"></param>
        /// <param name="p"></param>
        public Staff (string name, string surname,DateTime dataB,int p)
        {
            Name=name;
            Surname=surname;
            DateB=dataB;
            P = p;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public virtual void OutPut () 
        {
            Console.WriteLine($"Имя:{name}\nФамилия:{surname}\nДата рождения:{dateB}\nМинимальная зарплата:{p}");
        }
        /// <summary>
        /// Метод доход
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public virtual int Doxod (int k, int n)
        {
            return k * p;
        }
    }
}
