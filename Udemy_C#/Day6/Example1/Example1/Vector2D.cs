using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Vector2D
    {
        public double x,y;

        public void Add(Vector2D vector2d)
        {
            this.x += vector2d.x;
            this.y += vector2d.y;
        }
        public void Sub(Vector2D vector2d)
        {
            this.x -= vector2d.x;
            this.y -= vector2d.y;
        }

        public void Mul(double mul)
        {
            this.x *= mul;
            this.y *= mul;
        }

        public double DotProduct(Vector2D vector2d)
        {
            return x * vector2d.x + y * vector2d.y;
        }

    }
}
