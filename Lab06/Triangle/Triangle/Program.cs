using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle t1 = new Triangle();
                Console.WriteLine("Введите длины сторон");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                if ((a > b + c) | (b > c + a) | (c > a + b))
                {
                    throw new Exception("Треугольник не существует");
                }
                t1.SetTriangle(a, b, c);
                t1.Length();
                t1.Perimetr();
                t1.Square();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
        }
    }
}
