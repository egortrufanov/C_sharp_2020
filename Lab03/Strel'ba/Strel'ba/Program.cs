using System;

namespace Strel_ba
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chislo = new Random();
            int x0 = chislo.Next(0, 5);
            int y0 = chislo.Next(0, 5); 
            int points = 0;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Введите координаты");
                Console.Write("x=");
                int x = int.Parse(Console.ReadLine());
                Console.Write("y=");
                int y = int.Parse(Console.ReadLine());
                double r = Math.Sqrt(Math.Pow((x-x0), 2) + Math.Pow((y-y0), 2));
                if (r <= 1)
                {
                    Console.WriteLine("10 очков");
                    points += 10;
                }
                else if (r <= 2)
                {
                    Console.WriteLine("5 очков");
                    points += 5;
                }
                else Console.WriteLine("Вы промахнулись");
            }
            Console.WriteLine("Вы получили {0} очков", points);
            Console.WriteLine("Центр находился в точке ({0}, {1})", x0, y0);
        }
    }
}
