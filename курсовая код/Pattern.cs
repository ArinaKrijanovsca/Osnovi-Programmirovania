using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace курсовая_код
{/// <summary>
/// класс описивающий методы вывода информации
/// </summary>
    internal class Pattern
        
    {/// <summary>
    /// лист для храрнения информации
    /// </summary>
        List<Department> patterns = new List<Department>();
       /// <summary>
       /// метод для вывода информации о всех кафедрах
       /// </summary>
        public void OutPut()
        {
            foreach (var department in patterns)
            {
               Console.WriteLine( department.ToString());
            }
            
        }
        /// <summary>
        /// метод для добавление кафедры в начало списка
        /// </summary>
        public  void Start()
        {
            patterns.Insert(0,Init());
        }
        /// <summary>
        /// метод для добавления кафедры в конец с писка
        /// </summary>
        public   void End ()
        {
            patterns.Add(Init());
        }
        /// <summary>
        /// метод для добавления после определнной кафедры
        /// </summary>
        public  void Middle()
        {
            Console.WriteLine("Введите индекс элемента перед которым вы хотите вставить новый элемент");
            int index=int.Parse(Console.ReadLine());
            patterns.Insert(index, Init());
        }
        /// <summary>
        /// метод для добавления впепер списка
        /// </summary>
        public  void Before()
        {
            Console.WriteLine("Введите индекс элемента перед которым вы хотите вставить новый элемент");
            int index = int.Parse(Console.ReadLine());
            patterns.Insert(index + 1, Init());
        }
        /// <summary>
        /// метод для удаления кафедры из списка
        /// </summary>
        public  void Dellete()
        {
            Console.WriteLine("Введите индекс элемента который вы хотите удалить");
            int index = int.Parse(Console.ReadLine());
            patterns.RemoveAt(index);
        }
        /// <summary>
        /// метод :по  запросу выдаются сведенья о кафедрах определнного корпуса
        /// </summary>
        public void SearchKorpus()
        {
            Console.WriteLine("Введите корпус в котором находятся интересующие вас кафедры");
            char korpus=char.Parse(Console.ReadLine());
            foreach(var department in patterns)
            {
                if(department.Korpus==korpus)
                {
                    Console.WriteLine(department.ToString());
                }
            }
             
        }
        /// <summary>
        /// метод :По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий
        /// </summary>
        public void SearchAyditoria ()
        {
            Console.WriteLine("Введите номер аудитории в которой расположена интересующая вас кафедра");
            int ayditoria=int.Parse(Console.ReadLine());
            foreach (var department in patterns)
            {
                if (department.Ayditoria == ayditoria)
                {
                    Console.WriteLine(department.ToString());
                }
            }
                
        }
        /// <summary>
        ///  метод :По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий
        /// </summary>
        /// <param name="ayditoria"></param>
        /// <param name="aydend"></param>

        public void SearchAyditoriaRange(int ayditoria,int aydend)
        {
            foreach (var department in patterns)
            {
                for (; ayditoria <= aydend; ayditoria++)
                {
                    if (department.Ayditoria == ayditoria)
                    {
                      Console.WriteLine(department.ToString());
                    }
                }
            }
                
        }
        /// <summary>
        ///метод : По запросу выдаются сведенья о кафедре с максимальным колличесвом преподователей
        /// </summary>
        /// <param name="maxCount"></param>
        public void SearchMaxPrepod(int maxCount)
        {
            foreach(var departament in patterns)
            {
                if(departament.CountPrepodovatel>maxCount)
                {
                    maxCount=departament.CountPrepodovatel;
                }
            }
            foreach(var department in patterns)
            {
                if (department.CountPrepodovatel == maxCount)
                {
                   Console.WriteLine(department.ToString());
                }
            }
                
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns></returns>
        public static Department Init()
        {
            try
            {
                Console.WriteLine("Введите название  кафедры:");
                string namek = Console.ReadLine();
                Console.WriteLine("Введите фамилию заведующего:");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя заведующего:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите отчество аведующего:");
                string otchestvo = Console.ReadLine();
                Console.WriteLine("Введите колличесво преподователей:");
                int countPrepodovatel = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер аудитории:");
                int ayditoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите корпус:");
                char korpus = char.Parse(Console.ReadLine());
                return new Department(namek, name, otchestvo, surname, countPrepodovatel, ayditoria, korpus);
            }
            catch { return Init(); }
        }

    }
}
