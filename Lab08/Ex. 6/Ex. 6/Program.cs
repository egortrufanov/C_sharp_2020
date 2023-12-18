using System;
using System.Security.Cryptography;

namespace Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            Console.Write("Введите первый член прогрессии: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите разность прогрессии: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Геометрическая прогрессия");
            Console.Write("Введите первый член прогрессии: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель прогрессии: ");
            int q = int.Parse(Console.ReadLine());

            Console.Write("Какой элемент хотите найти в каждой прогрессии: ");
            int k = int.Parse(Console.ReadLine());

            ArithmeticProgression ap1 = new ArithmeticProgression(a1, d);
            Console.WriteLine("{0}й член арифметической прогрессии: {1}", k.ToString(), ap1.GetElement(k).ToString());

            GeometricProgression gp1 = new GeometricProgression(b1, q);
            Console.WriteLine("{0}й член геометрической прогрессии: {1}", k.ToString(), gp1.GetElement(k).ToString());
        }
    }
}
