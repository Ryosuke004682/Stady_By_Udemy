using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexIF_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("さいころの目(1 ～　6)");

            var dice = int.Parse(Console.ReadLine());

            //if文のネスト
            if(1 <= dice && dice <= 6)
            {
                if(dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("丁です");
                }
                else
                {
                    Console.WriteLine("半です");
                }
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }
        }
    }
}
