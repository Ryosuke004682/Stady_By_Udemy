using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            
            while(i <= 1)
            {
                Console.Write(i + "、");
                i++;
            }
            Console.WriteLine();
        }
    }
}
