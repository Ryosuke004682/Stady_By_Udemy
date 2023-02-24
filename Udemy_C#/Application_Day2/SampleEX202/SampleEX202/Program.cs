using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleEX202
{
    internal class Program
    {
        private static int snum = 100;
        public int inum = 200;
       
        public static void Foo()
        {
            Console.WriteLine("fooメソッド(staticメソッド)");
        }

        public void Bar()
        {
            Console.WriteLine("barメソッド(インスタンスメソッド)");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine($"pのインスタンスフィールド: inum = {p.inum}");
            Console.WriteLine($"Programのクラスフィールド: snum = {snum}");//Program.snumなので、インスタンスを生成しなくていい

            Foo();
            p.Bar();
            while (true) ;
        }
    }
}
