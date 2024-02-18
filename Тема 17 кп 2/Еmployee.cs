using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_17_кп_2
{/// <summary>
/// базовый класс 
/// </summary>
    internal class Employee
    {/// <summary>
    /// поле описывающее фамилию
    /// </summary>
        string surname;
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        string name;
        /// <summary>
        /// поле p поисывающее минимальную зарплату 
        /// </summary>
        int p;
        /// <summary>
        ///  поле k описывающее повышвющий коэффицент
        /// </summary>
        int k;
        /// <summary>
        /// свойство для поля  фамилия
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        /// <summary>
        /// свойство для поля имя 
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// свойство для поля p
        /// </summary>
        public int P
        {
         get { return p; }

            set { p = value; }
        }
        /// <summary>
        /// свойство для поля k
        /// </summary>
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        /// <summary>
        /// констрнуктор по умолчанию
        /// </summary>
        public Employee() { }
        /// <summary>
        /// констрнукор с парметрами 
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <param name="k"></param>
        public Employee(string surname,string name,int p,int k) 
        {
        Surname = surname;
            Name = name;   
           P = p;
            K = k;
        }
        /// <summary>
        /// метод доход 
        /// </summary>
        /// <returns></returns>
        public  virtual int Doxod ()
        {
            return k*p ;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public virtual void OutPut()
        { 
            Console.WriteLine($"Фамилия сотрудника:{surname}\nИмя сотрудника:{name}\nМинимальная зараплата:{p}\nПовышвющий коэфицент:{k}");

        }




    }
}
