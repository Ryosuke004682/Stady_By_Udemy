using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1～3の整数を入力してクレメンス");

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;

                default:
                    Console.WriteLine("範囲外です。");
                    break;
            }


        }
    }
}
