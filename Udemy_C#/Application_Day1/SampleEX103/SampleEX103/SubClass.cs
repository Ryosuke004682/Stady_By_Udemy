using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEX103
{
    internal class SubClass
    {
        //コンストラクタ
        public SubClass()
        {
            Console.WriteLine("コンストラクタ");
        }
        //デストラクタ
        //頭にチルダ
         ~SubClass()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
