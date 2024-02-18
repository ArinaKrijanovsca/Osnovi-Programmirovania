using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_17_кп_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Staff> staffs = new List<Staff>();
            staffs.Add(new Staff("Арина","Крижановская",new DateTime (2006,05,17),5000));
            staffs.Add(new Meneger("Арина", "Крижановская", new DateTime(2006, 05, 17), 5000,12));
            int k=int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            foreach(var staff in staffs) { staff.OutPut();staff.Doxod(k,n); }

            Console.ReadKey();
        }
    }
}
