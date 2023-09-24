using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression aProg = new ArithmeticProgression(1, 10);
            GeometricProgression gProg = new GeometricProgression(3, -5);

            Console.WriteLine(aProg.GetElement(3));
            Console.WriteLine(gProg.GetElement(5));

        }
    }
}
