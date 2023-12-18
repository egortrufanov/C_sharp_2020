using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._6
{
    class GeometricProgression : Progression
    {
        public int b1;
        public int q;
        public GeometricProgression(int b1, int q)
        {
            this.b1 = b1;
            this.q = q;
        }
        public override double GetElement(int k)
        {
            double bn = (b1 * Math.Pow(q, k - 1));
            return bn;
        }
    }
}
