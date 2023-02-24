using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEX201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data[] d = new Data[2];
            Data.ShowNumber();//Dataのインスタンスの数を表示

            for(var i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                Data.ShowNumber();//Dataのインスタンスを生成
            }
            while (true) ;
        }
    }
}
