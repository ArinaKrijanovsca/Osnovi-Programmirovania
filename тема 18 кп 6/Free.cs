using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_6
{
    /// <summary>
    /// наследуемый класс
    /// </summary>
    internal class Free:Software
    {
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Free() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="manufacturer">производитель</param>
        /// <param name="name">название</param>
        public Free(string manufacturer, string name) : base(manufacturer, name) { }
        /// <summary>
        /// метод вывода информации об объекте
        /// </summary>
        /// <returns>базовый метод вывода+свойства класса</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// метод для определения соответствие возможности использования (на момент текущей даты).
        /// </summary>
        /// <returns>состояние подписки на использование ПО</returns>
        public override string IsUsableOnDate()
        {
            return $"Software {Name} is free";
        }

    }
}
