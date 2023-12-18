using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._6
{
    class ArithmeticProgression : IProgression
    {
        public int a1 { get; set; }
        public int d { get; set; }
        public int b1 { get; set; }
        public int q { get; set; }

        public ArithmeticProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }
        public double GetElement(int k)
        {
            int an = (a1 + (k - 1) * d);
            return an;
        }
    }
}
