using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Gamer
    {
        string Name;
        IgralnayaKost seans;
        public delegate void MaxNumberDelegate(Gamer gamer);
        public static event MaxNumberDelegate GotMaxNumber;

        public int SeansGame()
        {
            int number = seans.random();
            if (number == 6)
            {
                GotMaxNumber(this);
            }
            return number;
        }

        public override string ToString()
        {
            return Name;
        }

        public Gamer(string name)
        {
            Name = name;
            seans = new IgralnayaKost();
        }

   

    }
}
