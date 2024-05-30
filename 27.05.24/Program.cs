using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._05._24
{
   public enum Month
        {
        Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь


    }

    public enum Actions
    {
        Деление=1,
        Умножение,
        Сложение,
        Вычетание
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Months i;
            //for (i = Months.Апрель; i<= Months.Декабрь;i++)
            //    Console.WriteLine(i);
            //Console.WriteLine($"{Month.Апрель}\n{(int)Month.Апрель}");

            //Day i;
            //for (i = Day.Sat; i <= Day.Fri; i++)
            //    Console.WriteLine(i +  " имеет значение "  + (int)i);
            /////3
            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"Выбирите действие:\n" +
               $"1.Деление:\n2.Умножение:\n3.Сложение:\n4.Вычетание:");
            int z= int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            
                switch (z)
                {
                    case (int)Actions.Деление:
                        Console.Clear();
                        Console.WriteLine($"Ответ:{y / x} {Actions.Деление}");
                        break;
                    case (int)Actions.Умножение:
                        Console.Clear();
                        Console.WriteLine($"Ответ:{y * x} {Actions.Умножение}");
                        break;
                    case (int)Actions.Сложение:
                        Console.Clear();
                        Console.WriteLine($"Ответ:{y + x}  {Actions.Сложение}");
                        break;
                    case (int)Actions.Вычетание:
                        Console.Clear();
                        Console.WriteLine($"Ответ:{y - x}  {Actions.Вычетание}");
                        break;
                    

                    default: return;
                        
                }
            }
            Console.ReadLine();
        }
    }
}
