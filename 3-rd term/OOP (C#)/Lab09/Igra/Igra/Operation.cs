using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Operation
    {
        public static void PrintInformation(Gamer gamer)
        {
            Console.WriteLine("Игроку " + gamer.ToString() + " выпало максимальное число!!!");
        }
    }
}
