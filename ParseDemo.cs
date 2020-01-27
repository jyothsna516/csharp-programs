using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class ParseDemo
    {
        static void Main()
        {
            sbyte i1 = sbyte.Parse("123");
            float f1 = float.Parse("123.3");
            decimal d = decimal.Parse("123.45");
            Console.WriteLine("{0},{1},{2}", i1, f1,d);
            Console.ReadKey();
            String s = "100";

        }
    }
}
