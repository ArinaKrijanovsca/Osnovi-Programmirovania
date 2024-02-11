using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_1
{/// <summary>
/// базовый класс
/// </summary>
    internal class Person
    {/// <summary>
    /// поле описывающее возраст
    /// </summary>
        int age;
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        string name;
        /// <summary>
        /// поле описвающее фамилию
        /// </summary>
        string surname;
        /// <summary>
        /// свойство для поля возраст
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        /// <summary>
        /// свойство для поля имя
        /// </summary>
        public string Name
        { get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// свойство для поля фамилия 
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Person() { }
        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="age"></param>
        public Person(int age)
        {
            this.age = age;
            
        }
        /// <summary>
        /// конструктор с двумя параметрами 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        
        public Person(int age,string name):this(age)
        {
            this.name = name;

        }
        /// <summary>
        /// коструктор с тремя параметрами
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public Person(int age, string name, string surname) : this(age,name)
        {
            this.surname = surname;

        }
        /// <summary>
        /// метод для вывода  информации
        /// </summary>
        //public void Print ()
        //{
        //    Console.WriteLine($"{ age}\t{name }\t{surname}");
        //}

        virtual public void Print()
        {
            Console.WriteLine($"Возраст человека:{age}\tИмя человека:{name}\tФамилия человека:{surname}");
        }
    }
        
}
