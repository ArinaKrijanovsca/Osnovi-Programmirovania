using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема19кп1
{/// <summary>
/// класс описывающий треугольник
/// </summary>
    internal class Triangle:MyInterface
    {/// <summary>
    /// поле описывающее имя
    /// </summary>
        string Name {  get; set; }
        /// <summary>
        /// поле описывающее сторону Side1
        /// </summary>
        int Side1 { get; set; }
        /// <summary>
        /// поле описывающее сторону Side2
        /// </summary>
        int Side2 { get; set; }
        /// <summary>
        /// поле описывающее сторону Side3
        /// </summary>
        int Side3 { get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона а</param>
        /// <param name="side2">сторона б</param>
        /// <param name="side3">сторона с</param>
        public Triangle(string name, int side1, int side2, int side3) 
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        /// <summary>
        /// метод для нахождения периметра 
        /// </summary>
        /// <returns>периметр треугольника</returns>
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{Name} а={Side1} б={Side2} с={Side3}";
        }
        
       
    }
}
