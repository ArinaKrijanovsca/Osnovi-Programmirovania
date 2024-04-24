using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_код
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<Department> DepartmentList= new List<Department>() { };
           
         Pattern pattern = new Pattern();
            while (true)
            {
                Console.WriteLine("Меню:\n1- Вывод информации о всех кафедрах\n2-Добавление кафедры в начало списка\n3-Добавление в конец списка\n4-Добавление полсе определнной кафедры\n" +
                    "5-Добавление в перед списка\n6-Удаления кафежрф из списка\n7-По запросу выдаются сведенья о кафедрах определнного корпуса:\n" +
                    "8-По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий:\n9-По запросу выдаются сведенья о кафедре с максимальным колличесвом преподователей:");
                Console.WriteLine("Введите индекс:");
                int deist = int.Parse(Console.ReadLine());
                switch (deist)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("вывод информации о всех  кафедрах:");
                        pattern.OutPut();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Добавление кафедры в начало списка:");
                        pattern.Start();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Добавление кафедры в конец списка:");
                        pattern.End();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Добавление после определенной кфаедры:");
                        pattern.Middle();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Добавление в вперед списка:");
                        pattern.Before();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Удаление кафедры из списка:");
                        pattern.Dellete();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("По запросу выдаются сведенья о кафедрах определнного корпуса :");
                        pattern.SearchKorpus();
                        break;

                    case 8 :
                        Console.Clear();
                        Console.WriteLine(" По запросу выдаются сведенья о кафедрах в диапазоне введенных пользователей аудитолрий: ");
                        int aydend=int.Parse(Console.ReadLine());   
                        int ayditoria=int.Parse(Console.ReadLine());
                        pattern.SearchAyditoriaRange(ayditoria, aydend);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("По запросу выдаются сведенья о кафедре с максимальным колличесвом преподователей:");
                        int maxCount=int.Parse(Console.ReadLine());
                        pattern.SearchMaxPrepod( maxCount);
                        Console.ReadLine() ;
                        Console.Clear();
                        break;
                    case 0: return;
                        default:
                        Console.Clear(); Console.WriteLine("Ошибка,повторите еще раз");
                        break; 


                }
            }

            Console.ReadKey();
      
        }
    }

}
