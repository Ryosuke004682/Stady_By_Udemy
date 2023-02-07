using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad_C
{
    //メソッドは同じ名前にできる。
    //ただし引数、戻り値を違くして、
    //明らかに違う形にしなければならない。

    //複数の名前のメソッドを定義することを、
    //オーバーロードという。
    internal class Calc
    {
        public int Add(int a , int b)
        {
            return a + b;
        }

        public int Add(int a , int b , int c)
        {
            return a + b + c;
        }

    }
}
