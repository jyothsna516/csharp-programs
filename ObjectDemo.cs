using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class ObjectDemo
    {
        static void Main()
        {
            int i = 10;
            char ch = 'a';
            double d = 123.4;
           // object o2 = d;
            object o = i;
            object o1 = ch;
            object o2 = d;
            object ob = 13;
            int j = (int)ob;
            Console.WriteLine(o);
            //object ob1 = "abc";
            //string s = ob1.ToString();
            //object ob2 = 123;
           // int k =(int)ob2;
            //s = i.ToString();
        }
    }
}
