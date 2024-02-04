using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_16_кп_3
{
    internal class DateClass
    {
        /// <summary>
        /// поле описывающее дату 
        /// </summary>
        DateTime data;
        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// конструктор с 3 параметрами год месяц и день
        /// </summary>
        /// <param name="year">year</param>
        /// <param name="month">month</param>
        /// <param name="day">day</param>
        public DateClass(int year,int month,int day) 
        { 
        this.Data = new DateTime (year,month,day);   
        }
        /// <summary>
        /// свойство для поля дата 
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// метод позволяющий вычислить дату предыдущего дня
        /// </summary>
        /// <returns></returns>
        public DateTime Yesterday()
        { 
            return data.AddDays(-1);
        }
        /// <summary>
        /// метод позволяющий вычислить дату следующего дня 
        /// </summary>
        /// <returns></returns>
        public DateTime Tomorrow() 
        {
            return data.AddDays(-1);
        }
        /// <summary>
        /// метод  похволяющий вычислить скллько дней осталось до конца месяца 
        /// </summary>
        /// <returns></returns>
        public int  EndMonth() 
        {
        return DateTime.DaysInMonth (data.Year, data.Month)-data.Day;
        }
        /// <summary>
        ///  метод для вывода информации 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"year{data.Year}\nmonth{data.Month}\nday{data.Day}\n{Data.ToShortDateString()}\nYesterday{Yesterday()}\nTomorrow{Tomorrow()}\nEndMonth{EndMonth()}";
        }

    }
}
