using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_6
{/// <summary>
/// абстрактный класс описывающий ПО
/// </summary>
    abstract class Software
    {
        /// <summary>
        /// производитель
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Software() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="manufacturer">производитель</param>
        /// <param name="name">название</param>
        public Software(string manufacturer, string name)
        {
            Manufacturer = manufacturer; Name = name;
        }
        /// <summary>
        /// базовый метод вывода информации об объекте
        /// </summary>
        /// <returns>свойства класса</returns>
        public override string ToString()
        {
            return $"Производитель-{Manufacturer}\nНазвание-{Name}\n";
        }
        /// <summary>
        /// метод для определения соответствие возможности использования (на момент текущей даты).
        /// </summary>
        /// <returns>состояние подписки на использование ПО</returns>
        public abstract string IsUsableOnDate();

    }
}
