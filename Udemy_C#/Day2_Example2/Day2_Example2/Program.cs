using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 2;  b = 3;

            var add = a + b;
            Console.WriteLine($"{a} + {b} = {add}");

            c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");
        }
    }
}
