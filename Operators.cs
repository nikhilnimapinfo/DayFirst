using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    class A { }
    internal class Operators
    {
        public void main( )
        {
            int a;
            int b;
            int c;


             a = 10;
             c = 10;
            Console.WriteLine(a == c); // true

            b = 20; c = 30;
            Console.WriteLine(b > c);   //FALSE

            a = 10; b = 20;
            Console.WriteLine(a != b);  //TRUE

            c = 30; b = 20;
            Console.WriteLine(c >= b);  //TRUE

            a = 10; c = 30;
            Console.WriteLine(a <= c);   //TRUE

            a = 10; c = 30;
            Console.WriteLine(a <= c && a==c);  //FALSE

            a = 10;c = 30;
            Console.WriteLine(a <= c || a == c); //true

        }   
    }
}
