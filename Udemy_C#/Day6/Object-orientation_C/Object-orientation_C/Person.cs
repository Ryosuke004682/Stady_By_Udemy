using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orientation_C
{
    internal class Person
    {
        //**フィールド**
        public string name = "";
        public int age = 0;

        //**情報の表示（メソッド）**
        public void ShowAgeAndName()
        {
            Console.WriteLine($"名前 : {name} 年齢 : {age}");
        }

        //**情報の設定**
        public void SetAgeAndName(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
