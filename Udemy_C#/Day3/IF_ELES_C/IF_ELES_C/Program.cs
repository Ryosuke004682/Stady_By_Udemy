using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELES_C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("整数を入力して");

            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("a = "+ a);

            if(a > 0)
            {
                Console.WriteLine($"aの値{a}は、正の整数です。");
            }
            else
            {
                    Console.WriteLine($"aの値{a}は、負の整数です。");
            }
        }
    }
}
