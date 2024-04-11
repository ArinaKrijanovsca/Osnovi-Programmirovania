using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема19кп1
{/// <summary>
///  класс опимывающий окружность
/// </summary>
    internal class Circle:MyInterface
    {/// <summary>
    /// поле описывающее имя
    /// </summary>
        string Name { get; set; }
        /// <summary>
        /// поле описывающее сторону 
        /// </summary>
        int Side1 { get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Circle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">радиус</param>
        public Circle(string name, int side1) 
        {
            this.Name = name;
            this.Side1 = side1;
        }
        
        /// <summary>
        /// метод для нахождения площади
        /// </summary>
        /// <returns>площадь круга</returns>
        public  double Area()
        {
            return Math.PI * Math.Pow(Side1, 2);
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{Name} радиус={Side1}";
        }
        /// <summary>
        /// метод для нахождения периметра 
        /// </summary>
        /// <returns>периметр круга</returns>
        public  double Perimeter()
        {
            return 2 * Math.PI * Side1; ;
        }
        
       
    }
}
