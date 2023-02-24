using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEX201
{
    internal class Data
    {
        //静的なメゾット「num」
        private static int num = 0;
        private int id;

        public Data(int data)
        {
            this.id = data;
            num++;
            Console.WriteLine($"値：{this.id} , 数：{num}");
        }

        public static void ShowNumber()
        {
            Console.WriteLine($"Dataオブジェクト数:{num}");
        }
    }
}
