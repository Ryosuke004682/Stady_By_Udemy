using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class SubClass
    {
        public void Add(SubClass sub)
        {
            //**足し算**
            X += sub.X; Y += sub.Y;
        }

        public void Sub(SubClass sub)
        {
            //**引き算**
            X -= sub.X; Y -= sub.Y;
        }

        public void Mul(double mul)
        {
            //**掛け算**
            X *= mul; Y *= mul;
        }

        public double DotProduct(SubClass sub)
        {
            //**内積**
            return X * sub.X + Y * sub.Y;
        }

        public double X
        {
            set;get;
        }

        public double Y
        {
            set;get;
        }

    }
}
