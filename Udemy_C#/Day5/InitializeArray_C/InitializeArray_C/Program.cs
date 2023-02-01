using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace InitializeArray_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = {5,4,3,2,1};
            string[] character = {"ABC","DEF","GHI","JKL", "MLO","PQR","STU","VWX","YZ" };

            for (var i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

            for(var i = 0; i < character.Length; i++)
            {
                Console.Write(character[i] + "\n");
            }
            Console.WriteLine();


        }
    }
}
