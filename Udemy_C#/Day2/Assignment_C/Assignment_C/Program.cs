using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 2, b1 = 2, c1 = 2, d1 = 2;
            int a2 = 2, b2 = 2, c2 = 2, d2 = 2;

            //これが普通に演算して代入したやつ。
            a1 = a1 + 1;
            b1 = b1 - 1;
            c1 = c1 * 2;
            d1 = d1 / 2;

            //こっちが代入演算子
            a2 += 1;
            b2 -= 1;
            c2 *= 2;
            d2 /= 2;

            Console.WriteLine("a1 = {0}, b1 = {1} , c1 = {2} , d1 = {3}" , a1 , b1 , c1 , d1);

            Console.WriteLine("a2 = {0}, b2 = {1} , c2 = {2} , d2 = {3}" , a2 , b2 , c2 , d2);

        }
    }
}
