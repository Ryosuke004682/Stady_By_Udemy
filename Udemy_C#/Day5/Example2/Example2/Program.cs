using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 0.2, 1.4, -0.8 };

            for(var i = 0; i < d.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {d[i]}");
            }
        }
    }
}
