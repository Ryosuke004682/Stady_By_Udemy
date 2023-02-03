using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    //長さ10の配列aを作る。
    //for文を用いてa[0]からa[9]に1～10の値を代入する。
    //for文を用いて配列の中身を、a[0] = 1、a[1] = 2.....のように表示する。
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for(var i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("俺が書いた奴");

            //-----------俺が書いた奴↓------------
            int[] b = new int[10];

            for (var i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {i + 1}");
            }
        }
    }
}
