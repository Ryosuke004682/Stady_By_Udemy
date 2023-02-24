using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var sqrt = SQR.Sqrt(a);

            
            if(a >= 0)
            {
                Console.WriteLine(sqrt);
            }
            else
            {
                Console.WriteLine("正の整数を入力してください");
            }
            
            while (true) ;
        }
    }
}
