using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Example1
{
    internal class Program
    {
        /*静的メンバとは、インスタンスを生成せずに利用できるメンバ
         
         ・静的なメソッド・・・クラスメソッド
         ・静的なフィールド・・クラスフィールド

        「static」修飾子をつけるだけで定義可能

                　　　＊＊ルール＊＊
         ・インスタンスを生成しなくても利用できる。
         ・(クラス名).フィールド名
         ・(クラス名).メソッド名(・・・)

       　　例：Sample.num = 1; Sample.Add(1,2); (Sampleがクラス名)

         */

        //--------------------------------------------------------------------

        /*インスタンスメンバとは、インスタンスを生成して利用するメンバ
         
         ・インスタンスメソッド
         ・インスタンスフィールド

        　　　　　　　＊＊ルール＊＊
        ・インスタンスを生成しなければ利用できない
        ・(インスタンス名).フィールド名
        ・(インスタンス名).メソッド名(・・・)

           例：s.num = 1; s.Add(1,2); (sがインスタンス名)

         */
        
        /*
                         ＊＊注意＊＊
         ・クラスメソッド内でインスタンスメンバは使えない。
         ・インスタンスメンバはインスタンスを生成しなきゃ使えない。
         ・クラスメンバはインスタンスを生成しなくても使うことができる。
        
         ・インスタンスメソッドの中で、クラスメンバを使うことは可能。
         
         */

        static void Show(string name , SubClass subClass)
        {
            Console.WriteLine($"{name} = ({subClass.X},{subClass.Y})");
        }


        static void Main(string[] args)
        {

            SubClass sub1 = new SubClass(1.0, 1.0);
            Show("sub1" , sub1);

            SubClass sub2 = new SubClass(1.0, -1.0);
            Show("sub2" , sub2);


            sub1.Add(sub2);
            Show("sub1", sub1);

            sub1.Sub(sub2);
            Show("sub1", sub1);

            sub1.Mul(2.0);
            Show("sub1", sub1);

            Console.WriteLine($"内積は、sub1 = {sub1.DotProduct(sub2)}");

            while (true) ;
        }

        

    }
}
