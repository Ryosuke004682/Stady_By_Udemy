using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力 :");
            var a = int.Parse(Console.ReadLine());

            for(var i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    Console.Write(i + "、");
                }
            }

            Console.WriteLine();//改行のための奴

        }
    }
}
