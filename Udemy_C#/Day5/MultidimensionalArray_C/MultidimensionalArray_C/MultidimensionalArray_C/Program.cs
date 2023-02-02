using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,4];

            for(var i = 0; i < 3; i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    a[i, j] = i + j;
                }
            }

            for(var i = 0; i < 3; i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    Console.Write($" a[{i},{j}]={a[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
