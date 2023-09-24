using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    internal class GeometricProgression : IProgression
    {
        public double denom;

        public double firstElement;
        public GeometricProgression(double firstElement, double denom)
        {
            this.firstElement = firstElement;
            this.denom = denom;
        }
        
        public GeometricProgression() { }

        public double GetElement(int k)
        {
            return firstElement * Math.Pow(denom, k - 1);
        }
    }
}
