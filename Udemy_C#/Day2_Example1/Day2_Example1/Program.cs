using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1.1 + 2.1;
            var b = 3.7 - 6.25;
            var c = 5.0 * 2.1;
            var d = 2.2 / 0.1;

            var e = 2 * (1.24 + 2.2) + 3.4 / 10.0;


            Console.WriteLine("{0} + {1} = {2}" ,1.1 , 2.1 , a);
            Console.WriteLine("{0} - {1} = {2}" ,3.7 , 6.25 , b);
            Console.WriteLine("{0} * {1} = {2}" ,5.0 , 2.1 , c);
            Console.WriteLine("{0} / {1} = {2}" , 2.2 , 0.1 , d);
            Console.WriteLine("{0} * ({1} + {2}) + {3} / {4} = {5}" , 2 , 1.24 , 2.2 , 3.4 , 10.0 , e);
        }
    }
}
