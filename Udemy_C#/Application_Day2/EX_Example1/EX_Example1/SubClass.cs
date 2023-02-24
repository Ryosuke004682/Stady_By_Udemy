using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Example1
{
    internal class SubClass
    {
        public SubClass()
        {

        }
        public SubClass(double x, double y)
        {
            X = x; Y = y;
        }
        public SubClass(SubClass sub)
        {
            X = sub.X; Y = sub.Y;
        }



        public void Add(SubClass sub)
        {
            X += sub.X; Y += sub.Y;
        }

        public void Sub(SubClass sub)
        {
            X -= sub.X; Y -= sub.Y;
        }

        public void Mul(double mul)
        {
            X *= mul; Y *= mul;
        }

        public double DotProduct(SubClass sub)
        {
            return X * sub.X + Y * sub.Y;
        }

        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
    }
}
