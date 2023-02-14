using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    internal class MasterClass
    {
        static void Main(string[] args)
        {
            SubClass sub = new SubClass();

            sub.SetNameAndAge("ボブ",90);

            //上で定めたプロパティの値を更新
            sub.Age = 89;
            //プライベートだからSetできない。
            //sub.Name = "トム";

            Console.WriteLine($"名前 {sub.Name} : 年齢 {sub.Age}");//Age = 89

            while (true) ;
        }
    }
}
