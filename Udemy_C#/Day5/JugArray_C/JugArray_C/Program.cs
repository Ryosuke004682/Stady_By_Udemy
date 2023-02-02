using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugArray_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][]
            {
                new int[] {0,1 },
                new int[] {2,3,4},
                new int[] {5,6,7,8,9}
            };

            for(var i = 0; i < a.Length; i++)
            {
                for(var j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
