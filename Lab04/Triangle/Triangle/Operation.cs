using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Formula
    {
        public static double Square(double a, double b, double c)
        {
            try
            {
                if (a > b + c)
                {
                    throw new Exception("Incorrect triangle");
                }
                if (b > c + a)
                {
                    throw new Exception("Incorrect triangle");
                }
                if (c > a + b)
                {
                    throw new Exception("Incorrect triangle");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        public static double Square(double a)
        {
            double p = 3 * a / 2;
            double s = Math.Sqrt(p * Math.Pow((p - a), 3));
            return s;
        }
    }
}
