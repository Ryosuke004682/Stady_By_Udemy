using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    //public,privateは「アクセス修飾子」
    internal class SubClass
    {
        //名前(フィールド)
        private string name = "";
        //年齢(フィールド)
        private int age = 0;

        public void SetNameAndAge(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowNameAndAge()
        {
            Console.WriteLine($"名前{name} : 年齢{age}");
        }

        //情報の設定
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //情報の設定
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

    }
}
