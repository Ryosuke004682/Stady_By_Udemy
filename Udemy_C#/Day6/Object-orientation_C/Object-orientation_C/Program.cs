using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orientation_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            p1.name = "Ryosuke";
            p1.age = 21;

            p2.SetAgeAndName("Ousama",20);

            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
