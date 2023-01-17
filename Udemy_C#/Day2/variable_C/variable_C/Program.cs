using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            var b = 3;
            int add, sub;
            double avg;
            
            
            a = 6;

            add = a + b;
            sub = a - b;

            avg = (a + b) / 2.0;

            Console.WriteLine("{0} + {1} = {2}",a , b , add);
            Console.WriteLine("{0} + {1} = {2}",a , b , sub);
            Console.WriteLine("{0} + {1}の平均値{2}",a , b , avg);

        }
    }
}
