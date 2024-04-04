using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        const int a = 20;
        static void Main(string[] args)
      {
           
            int a = 30;
            var t = 20;

            string s= "hello";
            var s1 = "Welcome";

            float j = 2.2f;
            var j1 = 3.3f;

            decimal d = 10000000000000000000000000000m;
            var d1 = 20000000000000000000000000000m;

            double o = 200;

            Boolean b = true;
            var b1 = false;

            byte bb = 1;

            short ss = 23;
            long l = 100000000000;

            Console.WriteLine("Good Afternoon");
            Console.WriteLine(a+" "+t);
            Console.WriteLine(s +" "+s1);
            Console.WriteLine(j+" "+j1);
            Console.WriteLine(o);
            Console.WriteLine(d +" "+d1);
            Console.WriteLine(b+" "+b1);
            Console.WriteLine(bb);
            Console.WriteLine(ss);
            Console.WriteLine(l);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("{0} {1}",byte.MinValue , byte.MaxValue);
            Console.WriteLine("{0} {1}",int.MinValue,  int.MinValue);
            Console.WriteLine("{0} {1}",short.MinValue,short.MaxValue);
            Console.WriteLine("{0} {1}",decimal.MinValue,decimal.MaxValue);
            Console.WriteLine("{0} {1}", Boolean.FalseString, Boolean.TrueString);

        }
    }
}
