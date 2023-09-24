using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года: ");
            int yearNumber = int.Parse(Console.ReadLine());

            if (yearNumber % 4 == 0 && yearNumber % 100 != 0 || 
                yearNumber % 400 == 0)
                Console.WriteLine("Год високосный");
            else
                Console.WriteLine("Год не високосный");
        }
    }
}
