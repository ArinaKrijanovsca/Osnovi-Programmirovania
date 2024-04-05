using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_5
{/// <summary>
/// наследуемы класс
/// </summary>
    internal class Product:Goods
    {/// <summary>
    /// поле описывающее дату производства товара
    /// </summary>
        public DateTime ProductionDate { get; set; }
        /// <summary>
        /// поле описывающее срок годности
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// конструктор по умолчаниюю
        /// </summary>
        public Product () { }
        /// <summary>
        /// коструктор с парамтерами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="price">price</param>
        /// <param name="productionDate">productionDate</param>
        /// <param name="expirationDate">expirationDate</param>
        public Product(string name, int price, DateTime productionDate, DateTime expirationDate) : base(name, price)
        {
            
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" {base.ToString()}\n Дата производства :{ProductionDate.ToShortDateString()}\n Срок годности :{ExpirationDate.ToShortDateString()}";
        }
        /// <summary>
        /// метод для определения годности товара
        /// </summary>
        /// <returns></returns>
        public override string DeadlineExpirationDate()
        {
            if (ExpirationDate <= DateTime.Now)
            { return $"Просроченный товар: {Name}"; }
            else { return null; }
        }


    }
}
