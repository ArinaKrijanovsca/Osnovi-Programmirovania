using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Touroperator> list = new List<Touroperator>();
            list.Add(new Touroperator("Фирма1",2009,1,3000));
            list.Add(new Touroperator("Фирма2",2008,2,2500));
            list.Add(new Touroperator("Фирма3",2010,3,35000));
            Console.WriteLine("Введите название фирмы:");
            string name=Console.ReadLine();
            bool not_find = false;
            for (int i = 0;i<list.Count;i++)
            {
                if (list[i].Name==name)
                {
                    Console.WriteLine($"INN{list[i].Id} Price:{list[i].Profit}");
                    not_find = true;
                }
            }
            if(not_find==false)
            {
                Console.WriteLine("Фирма не найдена");
            }

           
            Console.ReadKey();
        }
    }
}

