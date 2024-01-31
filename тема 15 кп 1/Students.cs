using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using тема_15_кп_1;

namespace тема_15_кп_1
{
    internal class Students
    {/// <summary>
    /// поле оптсывающее фамилию
    /// </summary>
        string surname;
        /// <summary>
        /// поле описывающее имя 
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее отчество
        /// </summary>
        string otchestvo;
        /// <summary>
        /// поле описывающее пол
        /// </summary>
        string pol;
        /// <summary>
        /// поля описывающие счетчик 
        /// </summary>
         public static int countm, countw;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Students() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="otchestvo"></param>
        /// <param name="pol"></param>
        public Students(string surname, string name, string otchestvo, string pol)
        {
            this.Surname = surname;
            this.Name = name;
            this.Otchestvo = otchestvo;
            this.Pol = pol;

            

            if (pol == "men" || pol == "Men")
            {
                countm++;

            }
            else if (pol == "women" || pol == "Women")
            {
                countw++;
            }
        }
        /// <summary>
        /// статический конструкто для инициализации счетчиков 
        /// </summary>
        static Students()

        {
            countm = 0;
            countw = 0;
        }
        /// <summary>
        /// свойство для поля фамилия
        /// </summary>
        public string Surname
        {

            get
            {
                return (surname == "") ? "фамилия не введена" : surname;
            }
            set
            {
                surname = value;
            }
        }
        /// <summary>
        /// свойство для поля имени
        /// </summary>
        public string Name
        {
            get
            {
                { return (name == "") ? "фамилия не введена" : name; }

            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// свойтво для поля отчество
        /// </summary>
        public string Otchestvo
        {
            get
            {
                return (otchestvo == "") ? "отчество не введено" : otchestvo;
            }
            set { otchestvo = value; }
        }
        /// <summary>
        /// свойство для поля пол
        /// </summary>
        public string Pol

        {
            get
            {
                return (pol == "") ? "пол не введен" : pol;
            }
            set
            {
                pol = value;
            }

        }
        /// <summary>
        /// метод для вывода информации о студентах
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"фаимлия  ={surname}\n имя={name}\n отчество={otchestvo}\n пол={pol}"; 
        }







    }
}
