using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Employce:Person
    {/// <summary>
    /// поле описывающее название компании 
    /// </summary>
        string company;
        /// <summary>
        /// поле описывающее профессию
        /// </summary>
        string job;
        /// <summary>
        /// свойтво для поля компания 
        /// </summary>
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        /// <summary>
        /// свойтво для поля работа 
        /// </summary>
        public string Job
        { get { return job; } 
         set {  job = value; } 
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Employce() { }
        /// <summary>
        /// конструктор с праметрами
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="company"></param>
        /// <param name="job"></param>
        public Employce(int age, string name, string surname, string company,string job) :base( age, name, surname)
        {
        this.company = company;
            this.job = job;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        // public new void  Print ()
        //{
        //    base.Print();
        //    Console.WriteLine($"{company}\t{job}");
        //}
        public  override void Print()
        {
            base.Print();
            Console.WriteLine($"Компания:{company}\tРабота:{job}\n");
        }



    }
}
