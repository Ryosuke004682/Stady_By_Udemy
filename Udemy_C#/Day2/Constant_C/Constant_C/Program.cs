using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER = 100;
            const string STRING = "Hoge";

            Console.WriteLine(NUMBER);
            Console.WriteLine(STRING);

            //constがついた変数は変えられない。
            //NUMBER = 10;
            //STRING = "piyo";

        }
    }
}
