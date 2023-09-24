using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Equation
{

    internal class Program
    {
        public static int SolveEquation(double a, double b, double c,
        out double x1, out double x2)
        {
            int result;
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                result = 1;
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = -b / (2 * a);
                result = 0;
            }
            else
            {
                x1 = double.NaN;
                x2 = double.NaN;
                result = -1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            
            try
            {
                Console.Write("Коэффициент a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Коэффициент b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Коэффициент c: ");
                c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Это линейное уравнение");
                }
                else
                {
                    double x1;
                    double x2;
                    int result = SolveEquation(a, b, c, out x1, out x2);

                    switch (result)
                    {
                        case -1:
                            Console.WriteLine("Корней уравнения с коэффициентами" +
                                " a = {0}, b = {1} и c = {2} нет", a, b, c);
                            break;
                        case 0:
                            Console.WriteLine("Корень уравнения с коэффициентами" +
                                " a = {0}, b = {1} и c = {2} совпадают и " +
                                "равны x1 = x2 = {3}", a, b, c, x1);
                            break;
                        case 1:
                            Console.WriteLine("Корни уравнения с коэффициентами" +
                                " a = {0}, b = {1} и c = {2} " +
                                "равны x1 = {3},  x2 = {4}", a, b, c, x1, x2);
                            break;
                    }
                }
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Ошибка ввода");
            }
             
        }
    }
}
