using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10__23
{
    abstract internal class Vehicle
    {
        double x, y;
        int price, speed, yearOfVip;
        public Vehicle() { }
        protected Vehicle(double x, double y, int price, int speed, int yearOfVip)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.yearOfVip = yearOfVip;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }
        public int YearOfVip { get => yearOfVip; set => yearOfVip = value; }
        public abstract string Print();
    }
}
