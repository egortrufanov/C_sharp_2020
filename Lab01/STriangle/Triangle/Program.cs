using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значения сторон");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int c = Int32.Parse(Console.ReadLine());
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
                double P = a + b + c;
                double p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Периметр\tПлощадь");
                Console.WriteLine("{0}\t{1}", P, S);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
   
        }
    }
}
