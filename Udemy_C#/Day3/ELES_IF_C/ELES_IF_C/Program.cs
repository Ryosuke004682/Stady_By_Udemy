using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELES_IF_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1～3の整数を入力してください");

            var number = int.Parse(Console.ReadLine());

            if(number == 1)
            {
                Console.WriteLine("1");
            }
            else if(number == 2)
            {
                Console.WriteLine("2");
            }
            else if(number == 3)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("表示されてる数を入力しろください");
            }
            
        }
    }
}
