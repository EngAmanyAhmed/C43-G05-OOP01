using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }


        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }
    }
}