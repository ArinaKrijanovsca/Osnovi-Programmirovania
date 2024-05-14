using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_код
{
    internal class Menu
    {
        public static void  Menu1()
        {
            Pattern pattern = new Pattern();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:\n1-Вывод информации о всех кафедрах\n2-Добавление кафедры в начало списка\n3-Добавление в конец списка\n4-Добавление после определённой кафедры\n" +
                    "5-Добавление в начало списка\n6-Удаление кафедры из списка\n7-По запросу выдаются сведения о кафедрах определённого корпуса\n" +
                    "8-По запросу выдаются сведения о кафедрах определенной аудитории\n9-По запросу выдаются сведения о кафедрах в диапазоне введенных пользователем аудиторий\n10-По запросу выдаются сведения о кафедре с максимальным колличесвом преподователей");
                Console.WriteLine("Введите индекс:");
                int deist = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (deist)
                {
                    case 1:
                        Console.WriteLine("Вывод информации о всех кафедрах:");
                        pattern.OutPut();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Добавление кафедры в начало списка:");
                        pattern.Start();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Добавление кафедры в конец списка:");
                        pattern.End();
                        Console.WriteLine("Чтобы потвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Добавление после определенной кафедры:");
                        pattern.Middle();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Добавление в вперед списка:");
                        pattern.Before();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Удаление кафедры из списка:");
                        pattern.Dellete();
                        Console.WriteLine("Чтобы подтвердить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("По запросу выдаются сведения о кафедрах определённого корпуса :");
                        pattern.SearchKorpus();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;

                    case 8:
                        Console.WriteLine("Введите номер аудитории в которой расположена интересующая вас кафедра");
                        pattern.SearchAyditoria();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;

                    case 9:
                        Console.WriteLine("По запросу выдаются сведения о кафедрах в диапазоне введенных пользователем аудиторий: ");
                        pattern.SearchAyditoriaRange();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.WriteLine("По запросу выдаются сведения о кафедре с максимальным колличесвом преподователей:");
                        pattern.SearchMaxPrepod();
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;
                    case 0: return;
                    default:
                        Console.WriteLine("Ошибка,повторите еще раз");
                        Console.WriteLine("Чтобы продолжить нажмите: Enter");
                        Console.ReadLine();
                        break;


                }
            }
        }
    }
}



               

            
        




