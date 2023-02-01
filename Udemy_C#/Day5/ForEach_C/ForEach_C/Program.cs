using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1 , 2 , 3 , 4};
            
            foreach(var i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
