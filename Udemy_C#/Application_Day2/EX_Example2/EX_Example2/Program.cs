using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Example2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int n = Nmeric.Max(a ,b);
            Console.WriteLine(n);
            
            while (true) ;
        }

    }
}
