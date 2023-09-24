using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evklid
{
    internal class PreConditionFunc
    {
        public static void Main(string[] args)
        {
            double x;
            double y;

            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\t VALUES \t");
            x = x1;
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("x = {0:F2} \t y = {1:F5} \t", x, y);
                x += 0.01;
            }
        }       
    }
}
