using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEX1
{
    internal class MasterClass
    {
        static void Main(string[] args)
        {
            SubClass sub1 = new SubClass(1.0 , 1.0);

            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            SubClass sub2 = new SubClass(1.0 , -1.0);


            Console.WriteLine($"sub2 = ({sub2.X},{sub2.Y})");


            sub1.Add(sub2);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");


            sub1.Sub(sub2);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            sub1.Mul(2.0);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            Console.WriteLine($"内積は、sub1 = {sub1.DotProduct(sub2)}");
            
            while (true) ;
        }
    }
}
