using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("足し算クイズぅぅぅぅぅ！！！");

            Random random = new Random();
            
            int a = random.Next(1, 11);
            int b = random.Next(1 , 11);

            int c = random.Next(1, 100);
            int d = random.Next(1, 100);
            Console.WriteLine($"それぞれ、a = {a} b = {b}です。\n");


            bool second = false;

            //while文を頭から再生してほしいときは、
            //whileの下に何か処理を書いておく。
            //その何からもう一度ループが始まる。
            while (true)
            {
                
                Console.WriteLine("では、｛a + b｝の答えは？？\n" + "a + b =");
                var answer = int.Parse(Console.ReadLine());

                if (a + b == answer)
                {
                    Console.WriteLine("正解です！");
                    break;
                }
                else
                {
                    Console.WriteLine("残念！！違います！！\n" + "それではもう一度！？");
                }
            }

            if (second == false)
            {
                Console.WriteLine("第二問");
                Console.WriteLine($"それぞれ、c = {c} d = {d}です。\n");
            }
            while (true)
            {

                Console.WriteLine("では、｛a + b｝の答えは？？\n" + "a + b =");
                var answer = int.Parse(Console.ReadLine());

                if (c + d == answer)
                {
                    Console.WriteLine("正解です！");
                    break;
                }
                else
                {
                    Console.WriteLine("残念！！違います！！\n" + "それではもう一度！？");
                }
            }
            second = true;

            if(second == true)
            {
                Console.WriteLine("全問正解！！");
            }



        }
    }
}
