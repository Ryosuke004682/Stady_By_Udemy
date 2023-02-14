using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class MasterClass
    {
        static void Main(string[] args)
        {
            SubClass sub1 = new SubClass();

            sub1.X = 1.0;
            sub1.Y = 1.0;

            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");


            SubClass sub2 = new SubClass();

            sub2.X =  1.0;
            sub2.Y = -1.0;

            Console.WriteLine($"sub2 = ({sub2.X},{sub2.Y})");

            //**足し算**
            sub1.Add(sub2);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            //**引き算＊＊
            sub1.Sub(sub2);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            //**掛け算**
            sub1.Mul(2.0);
            Console.WriteLine($"sub1 = ({sub1.X},{sub1.Y})");

            //**内積**
            Console.WriteLine($"{sub1.DotProduct(sub2)}");

            while (true) ;

        }
    }
}
