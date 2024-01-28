using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace тема_14_кп_2
{
    internal class MyClass
    {
        double value1, value2;
        static int count;
        public MyClass(double value1, double value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            count++;
        }
        public MyClass()
        {
            this.Value1 = 2.0;
            this.Value2 = 2.0;
            count++;
        }
        static MyClass()
        {
            count = 0;
        }
        public double Value1
        {
            get
            {
                return value1;
            }
            set
            {
                value1 = value; 
            }
        }
        public double Value2
        {
            get
            {
                return value2;
            }
            set
            {
                value2= value;
            }
        }
        public override string ToString ()
        {
            return $" value1={Value1}\tvalue2={value2}";
        }

    }
}
