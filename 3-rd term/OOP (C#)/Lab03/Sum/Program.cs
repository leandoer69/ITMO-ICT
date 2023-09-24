using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            int m;
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }

            Console.WriteLine(s);


        }
    }
}
