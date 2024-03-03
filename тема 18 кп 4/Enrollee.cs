using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_4
{/// <summary>
/// наследуемый класс абитуриент
/// </summary>
    internal class Enrollee:Person
    {
        /// <summary>
        /// поле поисвающее факультет
        /// </summary>
        string faculty;
        /// <summary>
        /// свойсво для поля факулитет
        /// </summary>
        public string Faculty { get => faculty; set => faculty = value; }
        /// <summary>
        /// конструкто по умолчанию
        /// </summary>
        public Enrollee() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="surname">surname</param>
        /// <param name="dateB">dateB</param>
        /// <param name="faculty">faculry</param>
        public Enrollee(string name, string surname, DateTime dateB,string faculty) :base(name,surname,dateB)
        {
        Faculty= faculty;
        }
        /// <summary>
        /// метод Age для определения возраста
        /// </summary>
        /// <returns></returns>
        public override int Age()
        {
            DateTime dateNow = DateTime.Now;
            if (dateNow.Month < DateB.Month)
            {
                return dateNow.Year - DateB.Year - 1;
            }
            else if (dateNow.Month == DateB.Day)
            {

                if (dateNow.Day < DateB.Day)
                {

                    return dateNow.Year - DateB.Year - 1;

                }
                else
                {
                    return dateNow.Year - DateB.Year;
                }
            }
            else
            {
                return dateNow.Year - DateB.Year;
            }

        }
        /// <summary>
        /// метод для вывода информации об объекте 
        /// </summary>
        /// <returns></returns>
        public static Enrollee Init()
        {
            try
            {
                Console.Write("Имя:");
                string name = Console.ReadLine();
                Console.Write("Фамилия:");
                string surname = Console.ReadLine();
                Console.Write("Дата рождения:");
                DateTime dateB = DateTime.Parse(Console.ReadLine());
                Console.Write("Факультет:");
                string facult = Console.ReadLine();
                return new Enrollee(name, surname, dateB, facult);
            }
            catch { return Init(); }
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Факультет:{faculty}");
        }
    }
}
