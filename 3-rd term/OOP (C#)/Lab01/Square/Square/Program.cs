using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    internal class TriangleSquare
    {
        static void Main(string[] args)
        {
            try
            {
                double perimeter;
                double side;
                double square;

                Console.WriteLine("Enter the perimeter value: ");
                perimeter = double.Parse(Console.ReadLine());
                side = perimeter / 3;
                square = Math.Sqrt(perimeter * Math.Pow((perimeter - side), 3));

                Console.WriteLine("Сторона" + '\t' + "Площадь");
                Console.WriteLine("{0:F}" + '\t' + "{1:F2}", side, square);

            }
            catch (FormatException e) {
                Console.WriteLine("Ошибка ввода: {0}", e.Message);
            }     
        }
    }
}
