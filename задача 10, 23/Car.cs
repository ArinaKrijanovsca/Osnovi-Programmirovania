using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10__23
{
    internal class Car : Vehicle
    {    int power;
        string marka;

        public Car(double x, double y, int price, int speed, int yearOfVip, int power, string marka) : base(x, y, price, speed, yearOfVip)
        {
            this.power = power;
            this.marka = marka;
        }

        public int Power { get => power; set => power = value; }
        public string Marka { get => marka; set => marka = value; }
        public override string Print()
        {
            return $"Координаты: широта {X}, долгота {Y}, Цена {Price}, Скорость{Speed}, Год выпуска {YearOfVip},{power},{marka}";
        }
    }
}
