using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("文字を入力してください");

            string s1 = Console.ReadLine(), s2 = Console.ReadLine();

            if (s1 == "hello" &&  s2 == "world")
                Console.WriteLine("Good");
            else
                Console.WriteLine("helloworld plese!");
           

        }
    }
}
