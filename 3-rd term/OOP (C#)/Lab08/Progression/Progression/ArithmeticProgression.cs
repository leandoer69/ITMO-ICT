﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    internal class ArithmeticProgression : IProgression
    {
        private double diff;
        private double firstElement;

        public ArithmeticProgression(double firstElement, double diff)
        {
            this.firstElement = firstElement;
            this.diff = diff;
        }

        public ArithmeticProgression() { }

        public double GetElement(int k)
        {
            return firstElement + diff * (k - 1);
        }
    }
}
