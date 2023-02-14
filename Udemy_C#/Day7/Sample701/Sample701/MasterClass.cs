using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    internal class MasterClass
    {

        static void Main(string[] ages)
        {
            SubClass sub1, sub2;
            sub1 = new SubClass();
            sub2 = new SubClass();

            sub1.Name = "ジョン";
            sub1.Age = 20;

            sub2.SetNameAndAge("ケネディー",22);
            sub1.ShowNameAndAge();

            Console.WriteLine($"名前{sub2.Name} : 年齢{sub2.Age}");

            while (true) ;
        }
    }
}
