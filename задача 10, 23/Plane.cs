using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10__23
{
    internal class Plane: Vehicle
    {
        double high;
        int countSeats;
        public Plane(double x, double y, int price, int speed, int yearOfVip, double high, int countSeats) : base(x, y, price, speed, yearOfVip)
        {
            this.high = high;
            this.countSeats = countSeats;
        }
        public double High { get => high; set => high = value; }
        public int CountSeats { get => countSeats; set => countSeats = value; }
        public override string Print()
        {
            return $"Координаты: широта {X}, долгота {Y}, Цена {Price}, Скорость{Speed}, Год выпуска {YearOfVip}, Высота {high}, Кол-во пассажиров {countSeats}";
        }
    }
}
