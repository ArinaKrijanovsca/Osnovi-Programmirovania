using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._05._24
{
    internal class Tour
    {
        string name;
        double price;
        int days;

        public Tour() { }

        public void TourCalc()
        {
            name = "Средиземное  море,бесплатно";
            price = 0;
            Console.WriteLine(name, price);
        }
        public void TourCalc(string name)
        {
            days = 1;
            price = 100;
            Console.WriteLine($"{days} день, {price} руб");
        }
        public void TourCalc(string name, int days)
        {

            price = 100 * days;
            Console.WriteLine($"Цена: {price} руб");
        }

    }
}
