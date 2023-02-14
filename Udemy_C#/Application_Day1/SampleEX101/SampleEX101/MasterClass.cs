using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEX101
{
    internal class MasterClass
    {
        static void Main(string[] args)
        {
            SubClass sub1, sub2;
            sub1 = new SubClass();            //コンストラクタ引数なし
            sub2 = new SubClass("ボブ" , 50); //コンストラクタ引数あり

            sub1.Name = "トム";
            sub1.Age = 12;

            sub1.ShowNameAndAges();
            sub2.ShowNameAndAges();

            while (true) ;
        }
    }
}
