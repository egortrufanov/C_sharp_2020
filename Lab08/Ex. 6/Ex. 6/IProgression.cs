using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._6
{
    interface IProgression
    {
        public int a1 { get; set; }
        public int d { get; set; }
        public int b1 { get; set; }
        public int q { get; set; }
        public double GetElement(int k);
    }
}
