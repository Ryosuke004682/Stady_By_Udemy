using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector1 = new Vector2D();
            vector1.x = 1.0;
            vector1.y = 1.0;
             
            Console.WriteLine($"vector1 = ({vector1.x},{vector1.y})");//(1,1)


            Vector2D vector2 = new Vector2D();
            vector2.x =  1.0;
            vector2.y = -1.0;

            Console.WriteLine($"vector1 = ({vector2.x},{vector2.y})");//(1,-1)


            //vector1 + vector2
            vector1.Add(vector2);
            Console.WriteLine($"vector1 = ({vector1.x},{vector1.y})");//(2,0)

            //vector1 - vector2
            vector1.Sub(vector2);
            Console.WriteLine($"vector1 = ({vector1.x},{vector1.y})");//(1,1)


            //**掛け算**
            vector1.Mul(2.0);
            Console.WriteLine($"vector1 = ({vector1.x} , {vector1.y})");//(2,2)


            //**内積**
            Console.WriteLine($"vector1とvector2の内積 = {vector1.DotProduct(vector2)}");//0



        }
    }
}
