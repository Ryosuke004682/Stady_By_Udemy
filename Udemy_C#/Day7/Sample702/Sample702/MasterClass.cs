using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    internal class MasterClass
    {
        static void Main(string[] args)
        {
            SubClass sub = new SubClass();

            //書き込みオンリーなのでエラーを吐く。
            //つまり「sub」は読み取り専用である。
            //sub.Date1 = 4;

            sub.Date2 = 10;
            sub.ShowDates();

            Console.WriteLine($"sub.date1 = {sub.Date1}");
            
            //書き込みオンリーなのでエラーを吐く。
            //つまり「sub」は読み取り専用である。
            //Console.WriteLine($"sub.date2 = {sub.Date2}");


            while (true) ;
        }
    }
}
