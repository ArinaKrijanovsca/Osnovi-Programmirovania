using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_код
{/// <summary>
/// класс описывающий кафедру
/// </summary>
    [Serializable]
    internal class Department
    {/// <summary>
    /// свойтсво для поля название кафедры
    /// </summary>
       public string Namek {  get; set; }
        public DateTime DateK { get; set; }
        /// <summary>
        /// свойтсво для поля фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// свойтво для поля имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойство для поля отчество
        /// </summary>
        public string Otchestvo { get; set; }
        /// <summary>
        /// свойтсво для поля колличество проеподователей
        /// </summary>
        public int CountPrepodovatel {  get; set; }
        /// <summary>
        /// свойтство для поля аудитория
        /// </summary>
        public int Ayditoria { get; set; }
        /// <summary>
        /// свойтсво для поля корпус
        /// </summary>
        public char Korpus { get; set; }
        /// <summary>
        /// конструктор по уморланию
        /// </summary>
         public Department() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="namek">название кафедры</param>
        /// <param name="name">имя заведующего</param>
        /// <param name="otchestvo">отчество заведующего</param>
        /// <param name="surname">фамилия заведующего</param>
        /// <param name="countPrepodovatel">колличество преподователей</param>
        /// <param name="ayditoria">номер аудиитории</param>
        /// <param name="korpus">корпус</param>
        public Department(string namek, DateTime datek,string name,string otchestvo,string surname,int countPrepodovatel,int ayditoria,char korpus) 
        {
            Namek = namek;
            DateK = datek;
            Name = name;
            Otchestvo = otchestvo;
            Surname = surname;
            CountPrepodovatel = countPrepodovatel;
            Ayditoria = ayditoria;
            Korpus = korpus;

        }
       /// <summary>
       /// метод для вывода информацции 
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return $"Название кафедры:{Namek} Дата создания кафедры:{DateK.ToShortDateString()}\nФИО заведующего:{Surname} {Name} {Otchestvo}\nКолличество преподователей" +
                $":{CountPrepodovatel} Номер аудиории:{Ayditoria} Корпус:{Korpus}";
        }

    }
}
