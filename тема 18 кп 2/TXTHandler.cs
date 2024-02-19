using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_2
{/// <summary>
/// производный класс 
/// </summary>
    internal class TXTHandler: AbstractHandler
    {
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public TXTHandler() { }
        /// <summary>
        /// метод открытие 
        /// </summary>
        public override void Open()
        {
            Console.WriteLine($"Open document format-TXT");
        }
        /// <summary>
        ///  метод создание
        /// </summary>
        public override void Create()
        {
            Console.WriteLine($"Createdocument format-TXT");
        }
        /// <summary>
        /// метод изменение
        /// </summary>
        public override void Change()
        {
            Console.WriteLine($"Change document format-TXT");
        }
        /// <summary>
        /// метод сохранение
        /// </summary>
        public override void Save()
        {
            Console.WriteLine($"penSave document format-TXT");
        }
    }
}
