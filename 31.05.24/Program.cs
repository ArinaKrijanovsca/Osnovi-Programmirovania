using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._05._24
{
    internal class Program
    {//28 и 29 задача
        static void Main(string[] args)
        {

            Tour tour = new Tour();
            tour.TourCalc();
            tour.TourCalc("Италия");
            tour.TourCalc("Армения", 2000);

            //Tovar tovar = new Tovar("Черника", 13, 8);
            //Tovar tovar1 = new Tovar("Мандарины", 18, 2);
            //Console.WriteLine($"Стоимость всей чериники: {tovar.Sum()}");
            //Console.WriteLine($"Стоимость всех мандарин: {tovar1.Sum()}");
            //Console.WriteLine($"Стоимость всей черники и бананов: {tovar.Sum() + tovar1.Sum()}"); ;

            Console.ReadKey();

        }
    }
}
