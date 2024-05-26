using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10__23
{
    internal class Ship : Vehicle
    {
        int countSeats;
        string port;

        public Ship(double x, double y, int price, int speed, int yearOfVip, int countSeats, string potr) : base(x, y, price, speed, yearOfVip)
        {
            this.countSeats = countSeats;
            this.port = potr;
        }

        public int CountSeats { get => countSeats; set => countSeats = value; }
        public string Port { get => port; set => port = value; }

        public override string Print()
        {
            return $"Координаты: широта {X}, долгота {Y}, Цена {Price}, Скорость{Speed}, Год выпуска {YearOfVip},{countSeats},{port}";
        }
    }
}
