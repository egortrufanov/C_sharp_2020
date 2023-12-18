using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник равносторонний?");
            string q = Console.ReadLine();
            if (q == "Да")
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                double s = Formula.Square(a);
                Console.WriteLine("Площадь = {0}", s);
            }
            else
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                double s = Formula.Square(a, b, c);
                Console.WriteLine("Площадь = {0}", s);
            }
        }
    }
}
