using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace курсовая_код
{/// <summary>
/// класс описивающий методы вывода информации
/// </summary>
    internal class Pattern
        
    {
        
        string path = @"C:\Users\Dell\Desktop\курсовая\курсовая код\Кафедры.bin";
        /// <summary>
    /// лист для храрнения информации
    /// </summary>
        List<Department> patterns = new List<Department>();
       /// <summary>
       /// метод для вывода информации о всех кафедрах
       /// </summary>
        public void OutPut()
        {
            LoadDepartment();
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
            LoadDepartment();
            patterns.Insert(0,Init());
            SaveDepartment();
        }
        /// <summary>
        /// метод для добавления кафедры в конец с писка
        /// </summary>
        public   void End ()
        {
            LoadDepartment();
            patterns.Add(Init());
            SaveDepartment();
        }
        /// <summary>
        /// метод для добавления после определнной кафедры
        /// </summary>
        public  void Middle()
        {
            LoadDepartment();
            Console.WriteLine("Введите индекс элемента перед которым вы хотите вставить новый элемент");
            int index=int.Parse(Console.ReadLine());
            patterns.Insert(index, Init());
            SaveDepartment();
        }
        /// <summary>
        /// метод для добавления впепер списка
        /// </summary>
        public  void Before()
        {
            LoadDepartment();
            Console.WriteLine("Введите индекс элемента перед которым вы хотите вставить новый элемент");
            int index = int.Parse(Console.ReadLine());
            patterns.Insert(index + 1, Init());
            SaveDepartment();
        }
        /// <summary>
        /// метод для удаления кафедры из списка
        /// </summary>
        public  void Dellete()
        {
            LoadDepartment();
            foreach (var pattern in patterns)
            { Console.WriteLine(pattern.ToString()); }
            Console.WriteLine("Введите индекс элемента который вы хотите удалить");
            int index = int.Parse(Console.ReadLine());
            patterns.RemoveAt(index);
            SaveDepartment();
        }
        /// <summary>
        /// метод :по  запросу выдаются сведенья о кафедрах определнного корпуса
        /// </summary>
        public void SearchKorpus()
        {
            LoadDepartment();
            foreach (var pattern in patterns)
            {  Console.WriteLine( pattern.Korpus); }
            Console.WriteLine("Введите корпус в котором находятся интересующие вас кафедры");
            char korpus=char.Parse(Console.ReadLine());
            foreach(var department in patterns)
            {
                if(department.Korpus==korpus)
                {
                    Console.WriteLine(department.ToString());
                }
            }
             SaveDepartment();
        }
        /// <summary>
        /// метод :По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий
        /// </summary>
        public void SearchAyditoria ()
        {
            LoadDepartment();
            foreach (var pattern in patterns)
            { Console.WriteLine(pattern.Ayditoria); }
            int ayditoria=int.Parse(Console.ReadLine());
            
            foreach (var department in patterns)
            {
                if (department.Ayditoria == ayditoria)
                {

                    Console.WriteLine(department.ToString());
                }
            }
            SaveDepartment();
        }
        /// <summary>
        ///  метод :По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий
        /// </summary>
        /// <param name="ayditoria"></param>
        /// <param name="aydend"></param>

        public void SearchAyditoriaRange()
        {
            LoadDepartment();
            int ayditoria = int.Parse(Console.ReadLine());
            int aydend = int.Parse(Console.ReadLine());
            while (ayditoria != aydend)
            {
                ayditoria++;
                foreach (var department in patterns)
            {
               
                
                    if (department.Ayditoria == ayditoria)
                    {
                      Console.WriteLine(department.ToString());
                        
                    }
                }
            }
            SaveDepartment();
        }
        /// <summary>
        ///метод : По запросу выдаются сведенья о кафедре с максимальным колличесвом преподователей
        /// </summary>
        /// <param name="maxCount"></param>
        public void SearchMaxPrepod()
        {
            LoadDepartment();
            int maxCount = 0;
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
            SaveDepartment();
        }
        /// <summary>
        /// метод для создания объекта
        /// </summary>
        /// <returns></returns>
        public static Department Init()
        {
            try
            {
                Console.WriteLine("Введите название кафедры:");
                string namek = Console.ReadLine();
                Console.WriteLine("Введите дату создания кафедры:");
                DateTime dateK= DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите фамилию заведующего:");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя заведующего:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите отчество заведующего:");
                string otchestvo = Console.ReadLine();
                Console.WriteLine("Введите колличесво преподователей:");
                int countPrepodovatel = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер аудитории:");
                int ayditoria = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите корпус:");
                char korpus = char.Parse(Console.ReadLine());
                return new Department(namek,dateK, name, otchestvo, surname, countPrepodovatel, ayditoria, korpus);
            }
            catch { return Init(); }
        }
        /// <summary>
        /// метод для сериализации
        /// </summary>
        
        public void SaveDepartment()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path,FileMode.Open))
            { 
                binaryFormatter.Serialize(fs, patterns);
            }
        }
        /// <summary>
        /// метод для десериализации
        /// </summary>
        
        public void LoadDepartment()
        {
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
              patterns=(List<Department> ) binaryFormatter.Deserialize(fs);
            }
        }

    }
}
