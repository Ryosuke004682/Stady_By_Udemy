using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string hello = "HelloC#!!";

            for (var i = 1; i <= 10; i++)
            {
                Console.Write($"{hello}\n");
            }
        }
    }
}
