using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFor_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i <= 2; i++)
            {
                for(var j = 1; j <= 3; j++)
                {
                    var k = i + j;
                    Console.Write(i + " + " + j + " = " + k + "、");
                }
                Console.WriteLine();
            }
        }
    }
}
