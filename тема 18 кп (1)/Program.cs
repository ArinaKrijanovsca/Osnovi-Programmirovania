using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rissian rissians = new Rissian();
            rissians.Welcome();
            Moldovan mold = new Moldovan();
            mold.Welcome();
            Amerikanec amerikanec = new Amerikanec();
            amerikanec.Welcome();

        Console.ReadKey();

        }
    }
}
