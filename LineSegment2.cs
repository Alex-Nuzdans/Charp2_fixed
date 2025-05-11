using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LineSegment2
    {
        private double x;
        private double y;

        public LineSegment2()
        {
            x = 0;
            y = 0;
        }
        public LineSegment2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double nx
        {
            get { return x; }
            set { x = value; }
        }
        public double ny
        {
            get { return y; }
            set { y = value; }
        }

        public static double operator !(LineSegment2 L)
        {
            if (L.x > L.y)
            {
                return L.x - L.y;
            }
            else if (L.x < L.y)
            {
                return L.y - L.x;
            }
            return 0;
        }
        public static LineSegment2 operator ++(LineSegment2 L)
        {
            if (L.x > L.y)
            {
                L.x += 1;
                L.y -= 1;
            }
            else if (L.x < L.y)
            {
                L.x -= 1;
                L.y += 1;
            }
            return L;
        }
        public static LineSegment2 operator -(LineSegment2 L, int nx)
        {
            L.x -= nx;
            return L;
        }
        public static LineSegment2 operator -(int ny, LineSegment2 L)
        {
            L.y -= ny;
            return L;
        }
        public static implicit operator int(LineSegment2 L)
        {
            return Convert.ToInt32(L.x);
        }
        public static explicit operator double(LineSegment2 L)
        {
            return L.y;
        }
        public static bool operator <(LineSegment2 L1, LineSegment2 L2)
        {
            if (((L1.x >= L2.x) && (L1.x <= L2.y)) ||
                ((L1.y >= L2.x) && (L1.y <= L2.y)) ||
                ((L2.x >= L1.x) && (L2.x <= L1.y)) ||
                ((L2.y >= L1.x) && (L2.y <= L1.y)))
            {
                return true;
            }
            return false;
        }
        public static bool operator >(LineSegment2 L1, LineSegment2 L2)
        {
            return false;
        }
        public void print()
        {
            Console.WriteLine("X: " + x + " Y: " + y);
        }

    }

}
