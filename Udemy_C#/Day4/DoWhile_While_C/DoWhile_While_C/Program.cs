using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile_While_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //whileとdo～whileの違い

            int i, num;
            num = 1;

            Console.Write("whileで実行");

            i = 1;
            while(i < num)
            {
                Console.Write(" * ");
                i++;
            }
            Console.WriteLine();


            Console.Write("Do～whileで実行");
            i = 1;
            do
            {
                Console.WriteLine(" * " + "\n");
                i++;
            } while (i < num);


        }
    }
}
