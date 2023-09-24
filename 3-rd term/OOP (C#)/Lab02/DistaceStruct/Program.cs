using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistaceStruct
{
    internal class Program
    {
        public struct Distance
        {
            public int inch;
            public int ft;
        }
        static void Main(string[] args)
        {
            Distance firstDistance;
            Distance secondDistance;
            Distance thirdDistance;

            Console.WriteLine("*** First variable initialization *** ");

            Console.WriteLine("Enter inch count: ");
            firstDistance.inch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the feet count: ");
            firstDistance.ft = int.Parse(Console.ReadLine());

            firstDistance.inch += (int)(firstDistance.ft / 12);
            firstDistance.ft = (int)(firstDistance.ft % 12);

            Console.WriteLine("First variable length: {0}\' - {1}\"", 
                firstDistance.inch, firstDistance.ft);
            Console.WriteLine();


            Console.WriteLine("*** Second variable initialization *** ");

            Console.WriteLine("Enter inch count: ");
            secondDistance.inch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the feet count: ");
            secondDistance.ft = int.Parse(Console.ReadLine());

            secondDistance.inch += (int)(secondDistance.ft / 12);
            secondDistance.ft = (int)(secondDistance.ft % 12);

            Console.WriteLine("Second variable length: {0}\' - {1}\"",
                secondDistance.inch, secondDistance.ft);
            Console.WriteLine();

            thirdDistance.inch = firstDistance.inch + secondDistance.inch;
            thirdDistance.ft = firstDistance.ft + secondDistance.ft;

            thirdDistance.inch += (int)(thirdDistance.ft / 12);
            thirdDistance.ft = (int)(thirdDistance.ft % 12);

            Console.WriteLine("Third variable length: {0}\' - {1}\"",
                thirdDistance.inch, thirdDistance.ft);
        }
    }
}
