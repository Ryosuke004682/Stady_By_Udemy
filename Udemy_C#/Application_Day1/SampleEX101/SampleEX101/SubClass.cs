using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEX101
{
    internal class SubClass
    {
        private string name = "";
        private int age = 0;
        
        //コンストラクタ引数なし
        public SubClass() : this("名無し",0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        
        //コンストラクタ引数あり
        public SubClass(string name , int age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine($"引数ありのコンストラクタ。 name {name} ; age {age}");
        }

        public void ShowNameAndAges()
        {
            Console.WriteLine($"名前 {name} 年齢 {age}");
        }

        public string Name
        {
            set; get;
        }

        public int Age
        {
            set; get;
        }

    }
}
