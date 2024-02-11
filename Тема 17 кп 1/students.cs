using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Students:Person
    {/// <summary>
    /// поле описывающее дату рождения
    /// </summary>
        DateTime data;
        /// <summary>
        /// поле описывающее курс
        /// </summary>
        int kurs;
        /// <summary>
        /// свойство для поля дата рождения 
        /// </summary>
        public DateTime Data
        { 
            get { return data; } 
            set { data = value; }
        }
        /// <summary>
        /// свойство для поля курс
        /// </summary>
        public int Kurs
        { 
            get { return Kurs; }
            set { Kurs = value; }
        }
       /// <summary>
       /// коструктор с параметрами 
       /// </summary>
       /// <param name="age"></param>
       /// <param name="name"></param>
       /// <param name="surname"></param>
       /// <param name="data"></param>
       /// <param name="kurs"></param>
        public Students(int age, string name, string surname, DateTime data, int kurs) :base(age,name, surname) 
        {
        this.data= data;
          this.kurs = kurs;
        }
        /// <summary>
        /// метод для вывода информации 
        /// </summary>
        //new public void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"{data.ToLongDateString()}\t{kurs}");
        //}
        public override  void Print()
        {
            base.Print();
            Console.WriteLine($"Дата:{data.ToLongDateString()}\tКурс:{kurs}");
        }
    }
}
