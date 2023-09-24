using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x;
            double y;
            int centerX;
            int centerY;
            double noise;
            int s = 0;

            Random random = new Random();

            Console.Write("Введите количество выстрелов: ");
            n = int.Parse(Console.ReadLine());
            centerX = random.Next(10) - 5;
            centerY = random.Next(10) - 5;
            // Console.WriteLine("({0}, {1})", centerX, centerY);
            noise = random.NextDouble() - 0.5; // помеха [-0.5, 0.5]
            Console.WriteLine("Помеха: {0}", noise);

            for (int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y = ");
                y = int.Parse(Console.ReadLine());

                double ratioX = x - centerX;
                double ratioY = y - centerY;
                
                if (ratioX * ratioX + ratioY * ratioY + noise <= 1)
                {
                    s += 10;
                    Console.WriteLine("10 баллов!");
                }

                if (ratioX * ratioX + ratioY * ratioY  + noise > 1 && 
                    ratioX * ratioX + ratioY * ratioY + noise <= 4)
                {
                    s += 5;
                    Console.WriteLine("5 баллов!");
                }

                if (ratioX * ratioX + ratioY * ratioY + noise > 4 &&
                    ratioX * ratioX + ratioY * ratioY + noise <= 9)
                {
                    s += 1;
                    Console.WriteLine("1 балл!");
                }

                if (ratioX * ratioX + ratioY * ratioY + noise > 9)
                {
                    Console.WriteLine("Вы не попали");
                }
            }

            Console.WriteLine("({0}, {1}) - центр", centerX, centerY);
            Console.WriteLine("Вы набрали {0} баллов",s);
        }
    }
}
