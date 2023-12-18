using System;

namespace Equation
{
    class Equation
    {
        public static int Square(double a, double b, double c, out double x1, out double x2)
        {
             double D = b * b - 4 * a * c;
             if (D > 0)
             {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return 1;
             }
             else if (D == 0)
             {
                x1 = (-b) / 2 * a;
                x2 = x1;
                return 0;
             }
             else
             {
                x1 = -1;
                x2 = -1;
                return -1;
             }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double x1, x2;
            int s;
            s = Equation.Square(a, b, c, out x1, out x2);
            if (s == 1)
                Console.WriteLine("a = {0}\tb = {1}\tc = {2}\tx1 = {3}\tx2 = {4}", a, b, c, x1, x2);
            else if (s == 0)
                Console.WriteLine("a = {0}\tb = {1}\tc = {2}\tx1 = x2 = {3}", a, b, c, x1);
            else 
                Console.WriteLine("a = {0}\tb = {1}\tc = {2}\tКорней нет", a, b, c);

        }
    }
}