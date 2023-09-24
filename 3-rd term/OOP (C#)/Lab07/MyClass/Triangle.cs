using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Triangle
    {
        public double a;
        public double b;
        public double c;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ShowInfo()
        {
            if (this.Exists())
            {
                Console.WriteLine("Треугольник:\n a = {0}\n b = {1}\n c = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Треугольника со сторонами {0}, {1} и {2} не существует", a, b, c);
            }
        }

        public double Perimeter()
        {
            double perimeter = -1;
            if (this.Exists())
            {
                perimeter = a + b + c;
            }
            return perimeter;
        }
        
        public double Square()
        {
            double square = -1;
            if (this.Exists())
            {
                double p = this.Perimeter() / 2;
                square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return square;
        }

        public bool Exists()
        {
            return a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
        } 
    }
}
