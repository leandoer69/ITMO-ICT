using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Example
    {
        static void Main(string[] args)
        {/*
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");

            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);


            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            */
            
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                    myArray[i] = 0;
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            

        }
    }
}
