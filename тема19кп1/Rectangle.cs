using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема19кп1
{/// <summary>
/// класс  описывающий прямоугольник
/// </summary>
    internal class Rectangle:MyInterface
    {/// <summary>
    /// поле описывающее имя
    /// </summary>
        string Name {  get; set; }
        /// <summary>
        /// поле описывающие сторону Side1
        /// </summary>
        int Side1 {  get; set; }
        /// <summary>
        /// поле описывающие сторону Side2
        /// </summary>
        int Side2 { get; set; }

        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона а</param>
        /// <param name="side2">сторона б</param>
        public Rectangle(string name, int side1, int side2) 
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
        }
        /// <summary>
        /// метод для нахождения площади 
        /// </summary>
        /// <returns>площадь прямоугольника </returns>
        public  double Area()
        { 
            return Side1 * Side2;
        }
        /// <summary>
        /// метод для нахождения периметра
        /// </summary>
        /// <returns>периметр прямоугольника</returns>
        public  double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{Name} а={Side1} б={Side2}";
        }
        
    }
}
