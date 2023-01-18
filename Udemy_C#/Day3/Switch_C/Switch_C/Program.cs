using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1～3の整数を入力してください");
            var number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine("1です");
                    break;

                case 2:
                    Console.WriteLine("２です");
                    break;

                case 3:
                    Console.WriteLine("3です");
                    break;

                default:
                    Console.WriteLine("範囲外です");
                    break;
            }
            
        }
    }
}
