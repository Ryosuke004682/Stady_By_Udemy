using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 6;

            do
            {
                Console.Write(i + "、");
                i++;
            }
            while (i <= 5);

            Console.WriteLine();

        }
    }
}
