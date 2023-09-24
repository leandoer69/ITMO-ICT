using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int x;
            int y;
            Console.WriteLine("Введите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2}", x , y , greater);
           
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
            */
            /*
            int f;
            bool ok;

            Console.WriteLine("Number for factorial:");
            int z = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(z, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + z + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
            */
            
            
            int choise;
            Console.WriteLine("Введите тип треугольника, " +
                "где 1 - обычный, 2 - равносторонний:");

            try
            {
                choise = int.Parse(Console.ReadLine());

                if (choise == 1)
                {
                    double a;
                    double b;
                    double c;

                    Console.WriteLine("Введите первую сторону треугольника: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону треугольника: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону треугольника: ");
                    c = double.Parse(Console.ReadLine());

                    double square = Operation.GetSquare(a, b, c);

                    if (square == 0)
                    {
                        Console.WriteLine("Треугольника с такими сторонами не существует");
                    } 
                    else
                    {
                        Console.WriteLine("Площадь треугольника равна: {0}", square);
                    }
                }
                else if(choise == 2)
                {
                    double a;
                    Console.WriteLine("Введите cторону треугольника: ");
                    a = double.Parse(Console.ReadLine());
                    double square = Operation.GetSquare(a);

                    if (square == 0)
                    {
                        Console.WriteLine("Треугольника с такими сторонами не существует");
                    }
                    else
                    {
                        Console.WriteLine("Площадь треугольника равна {0}", square);
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Ошибка ввода");
            }
            
            
        }
    }
}
