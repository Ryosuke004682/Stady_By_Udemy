using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Switch_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("さいころの目（1 ～　6）");

            var dice = int.Parse(Console.ReadLine());

            switch(dice)
            {
                //フォールスルーができないので注意。
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("丁です");
                    break;

                case 1:
                case 3:
                case 5:
                    Console.WriteLine("半です");
                    break;

                default:
                    Console.WriteLine("範囲外です");
                    break;

            }

        }
    }
}
