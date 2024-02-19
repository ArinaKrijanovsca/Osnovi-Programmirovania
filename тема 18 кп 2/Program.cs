using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace тема_18_кп_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    XMLHandler xml = new XMLHandler();
            //    xml.Open();
            //    xml.Create();
            //    xml.Change();
            //    xml.OpenSave();
            //    TXTHandler txt = new TXTHandler();
            //    txt.Open();
            //    txt.Create();
            //    txt.Change();
            //    txt.OpenSave();
            //    DOCHandler dOC = new DOCHandler();
            //    dOC.Open();
            //    dOC.Create();
            //    dOC.Change();
            //    dOC.OpenSave();
            List<AbstractHandler> abst = new List<AbstractHandler>();
            abst.Add(new XMLHandler());
            abst.Add(new TXTHandler());
            abst.Add(new DOCHandler());
            foreach (var st in abst) 
            {
                st.Open();
                st.Create();

                st.Change();
                st.Save();
            }

            Console.ReadKey();


        }
    }
}
