using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_19_кп_2__5_pзадание_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> devices = new List<ISwitchable>();
            devices.Add(new TVSet());
            devices.Add(new PersonalComputer());
             foreach (var s  in devices )
            {
                s.Off();
                s.On();
            }
             Console.ReadLine();
        }
    }
}
