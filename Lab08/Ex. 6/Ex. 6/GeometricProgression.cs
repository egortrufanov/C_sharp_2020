using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._6
{
    class GeometricProgression : IProgression
    {
        public int a1 { get; set; }
        public int d { get; set; }
        public int b1 { get; set; }
        public int q { get; set; }

        public GeometricProgression(int b1, int q)
        {
            this.b1 = b1;
            this.q = q;
        }
        public double GetElement(int k)
        {
            double bn = (b1 * Math.Pow(q, k - 1));
            return bn;
        }
    }
}
