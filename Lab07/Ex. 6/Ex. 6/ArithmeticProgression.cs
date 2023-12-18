using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._6
{
    class ArithmeticProgression : Progression
    {
        public int a1, d;
        public ArithmeticProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }
        public override double GetElement(int k)
        {
            int an = (a1 + (k - 1) * d);
            return an;
        }
    }
}
