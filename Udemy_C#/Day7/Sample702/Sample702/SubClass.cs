using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    internal class SubClass
    {
        private int date1 = 5;
        private int date2 = 0;


        public void ShowDates()
        {
            Console.WriteLine($"date1 = {date1} : date2 = {date2}");
        }

        //これは読み込みオンリー
        public int Date1
        {
            get { return date1; }
        }
        //これは書き込みオンリー
        public int Date2
        {
            set { date2 = value; }
        }
    }
}
