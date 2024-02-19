using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_2
{/// <summary>
/// производный класс
/// </summary>
    internal class XMLHandler: AbstractHandler
    {
    /// <summary>
    /// конструктор по умолчанию 
    /// </summary>
        public XMLHandler() { }
        /// <summary>
        /// метод открытие
        /// </summary>
        public override void Open()
        {
            Console.WriteLine($"Open document format-XML");
        }
        /// <summary>
        /// метод создание
        /// </summary>
        public override void Create()
        {
            Console.WriteLine($"Createdocument format-XML");
        }
        /// <summary>
        /// метод изменение
        /// </summary>
        public override void Change()
        {
            Console.WriteLine($"Change document format-XML");
        }
        /// <summary>
        /// метод сохранение
        /// </summary>
        public override void Save()
        {
            Console.WriteLine($"penSave document format-XML");
        }

    }
}
