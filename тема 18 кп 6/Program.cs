using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Free free = new Free("Notepad++ Team", "Notepad++");
            Shareware trial = new Shareware("Adobe", "Adobe Photoshop", new DateTime(2025, 02, 14), new DateTime(2024, 02, 12));
            Commercial commercial = new Commercial("Microsoft", "Microsoft Office", new DateTime(2024, 02, 28), 200, new DateTime(2025, 07, 26));
            List<Software> softWares = new List<Software>() { free, trial, commercial };
            foreach (var item in softWares)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in softWares)
            {
                Console.WriteLine(item.IsUsableOnDate());
            }
            Console.ReadLine();
        }
    }
}
