using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class Type_CONVERSION
    {
        static void Main(string[] args)
        {
            Operators o = new Operators();
            o.main();

            // Implicite Type Conversion
            byte b = 255;
            int i = b;
            Console.WriteLine(i);

            //Explicite Type Conversion
            int k = 1000;
            byte b1 =(byte) k;
            Console.WriteLine(b1);

            //Non-Compatable Type
            var s = "11111111111111111";
            long i1 = Convert.ToInt64(s);
            Console.WriteLine(i1);

            try {
                //To handle an exception
                var v = "11111";
                byte b2 = Convert.ToByte(v);
                Console.WriteLine(b2);
            }
            catch
            {
                Console.WriteLine("can not convert the value string to byte");
            }

            string s1 = "true";
            Boolean bb = Convert.ToBoolean(s1);
            Console.WriteLine(bb);

        }
    }
}
