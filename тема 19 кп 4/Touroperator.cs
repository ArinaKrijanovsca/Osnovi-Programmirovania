using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_4
{
    internal class Touroperator
    {/// <summary>
    /// после названеи фирмы
    /// </summary>
         string name;
        /// <summary>
        /// поле описывающее год создания
        /// </summary>
         int yearsozd;
        /// <summary>
        /// поле описывающее ИНН
        /// </summary>
        int id;
        /// <summary>
        /// поле описывающее прибыль за год
        /// </summary>
        int profit;
        /// <summary>
        /// свойство для поля название фирмы
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойство для поля записывающее 
        /// </summary>
        public int Yearsozd { get ; set ; }
        /// <summary>
        /// свойство для поля ИНН
        /// </summary>

        public int Id { get; set ; }
        /// <summary>
        /// свойство для поля прибыль за год
        /// </summary>
        public int Profit { get; set ; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Touroperator() { }
        /// <summary>
        /// коструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="yearsozd"></param>
        /// <param name="id"></param>
        /// <param name="profit"></param>
        public Touroperator(string name, int yearsozd, int id, int profit) 
        { 
         Name = name;
         Yearsozd = yearsozd;
         Id = id;
         Profit = profit;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           return $"Названеи фирмы:{Name}\nГод создания:{Yearsozd}\nИНН:{Id}\nПрибыль за год:{Profit}";
        }
    }
}
