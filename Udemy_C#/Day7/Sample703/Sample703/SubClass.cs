using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    //自動化プロパティー
    internal class SubClass
    {
        public void SetNameAndAge(string name , int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowNameAndAge()
        {
            Console.WriteLine($"名前 {Name} : 年齢 {Age}");
        }

        public string Name
        {
            private set; get;
        }

        public int Age
        {
            set; get;
        }

    }
}
