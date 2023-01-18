using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("実数を入力してください。");

            var temp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{temp}は");

            if(0 < temp)
            {
                Console.WriteLine("plus");
            }
            else if(temp < 0)
            {
                Console.WriteLine("minus");
            }
            else if(temp == 0.0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
