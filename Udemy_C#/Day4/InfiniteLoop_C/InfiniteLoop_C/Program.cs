using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteLoop_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("6が出たら終了");

            while(true)
            {
                var dice = random.Next(1 , 7);//1以上7未満までの乱数を発生させる。（1～6まで）
                Console.WriteLine(dice);

                if(dice == 6)
                {
                    break;//ループを抜ける
                }
            }
            Console.WriteLine("終了");
        }
    }
}
