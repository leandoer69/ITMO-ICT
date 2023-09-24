using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Operation
    {

        public static double GetSquare(double a, double b, double c)
        {
            double square = 0;
            if (TriangleExists(a, b, c))
            {
                double p = (a + b + c) / 2;
                square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
     
            }
            return square;
        }

        public static double GetSquare(double a)
        {
            double square = 0;
            if (TriangleExists(a, a, a))
            {
                square = a * a * Math.Sqrt(3) / 4;

            }
            return square;
        }

        private static bool TriangleExists(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }
    }
}
