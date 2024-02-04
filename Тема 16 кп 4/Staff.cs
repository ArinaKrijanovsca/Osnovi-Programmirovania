using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_16_кп_4
{
    internal class Staff
    {/// <summary>
    /// поле опсывающее номре
    /// </summary>
        int nomber;
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее фамилию
        /// </summary>
        string surname;
        /// <summary>
        /// поле описывающее отчество
        /// </summary>
        string othestvo;
        /// <summary>
        /// поле описывающее дату 
        /// </summary>
        DateTime data;
        /// <summary>
        /// поле описывающее должность
        /// </summary>
        string doljnost;
        /// <summary>
        /// поле поисывающее оклад
        /// </summary>
        double oclad;
        /// <summary>
        /// свойство описывающее поле номер
        /// </summary>
        public int Nomber
        {
            get
            {
                return nomber;
            }
            set
            {
                nomber = value;
            }
        }
        /// <summary>
        /// свойство описывающее поле имя 
        /// </summary>
        public string Name
        {
            get
            {
                return (name == "") ? "имя не введено" : name;
            }
            set
            {
                name = value; ;
            }
        }
        /// <summary>
        /// свойство описывающее поле фаимилия 
        /// </summary>
        public string Surname
        {
            get
            {
                return (surname == "") ? "фамилия  не введена" : surname;
            }
            set
            {
                surname = value; ;
            }
        }
        /// <summary>
        /// свойство описывающее поле отчество
        /// </summary>
        public string Othestvo
        {
            get
            {
                return (othestvo == "") ? "фамилия  не введена" : othestvo;
            }
            set
            {
                othestvo = value; ;
            }
        }
        /// <summary>
        /// свойство описывающее поле дата
        /// </summary>
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value; ;
            }
        }
        /// <summary>
        /// свойство описывающее поле должность
        /// </summary>

        public string Doljnost
        {
            get
            {
                return (doljnost == "") ? "фамилия  не введена" : doljnost;
            }
            set
            {
                doljnost = value; ;
            }
        }
        /// <summary>
        /// свойство описывающее поле оклад
        /// </summary>
        public double Oclad
        {
            get
            {
                return oclad;
            }
            set
            {
                oclad = value; ;
            }
        }
        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public Staff() { }
        /// <summary>
        /// конструктор с параметрам 
        /// </summary>
        /// <param name="nomber"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="othestvo"></param>
        /// <param name="data"></param>
        /// <param name="doljnost"></param>
        /// <param name="oclad"></param>
        public Staff(int nomber, string name, string surname, string othestvo, DateTime data, string doljnost, double oclad)
        {
            this.Nomber = nomber;
            this.Name = name;
            this.Surname = surname;
            this.Othestvo = othestvo;
            this.Data = data;
            this.Doljnost = doljnost;
            this.Oclad = oclad;

        }
        /// <summary>
        /// метод для выводв информации 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $" номер:{nomber} имя:{name} фамилия:{surname} отчество:{othestvo} дата:{data} должность:{doljnost}  оклад:{oclad}\n ";
        }
    }

}
