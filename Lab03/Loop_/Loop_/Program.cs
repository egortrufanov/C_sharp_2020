using System;

namespace Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ПЕРВАЯ ЧАСТЬ
            //Вывод значения с постусловием
            double x, y;
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            x = x1;
            Console.WriteLine("x\ty");
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0}\t{1}", x, y);
            x = x + 0.01;
            }
            while (x <= x2);
            //Алгоритм Евклида с предусловием 
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("temp = {0}", temp);

            //Вторая часть
            //Вывод значения с предусловием
            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            x = x1;
            Console.WriteLine("x\ty");
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("{0}\t{1}", x, y);
                x = x + 0.01;
            }
            //Алгоритм Евклида с постусловием 
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);
            Console.WriteLine("temp = {0}", temp);
        }

    }
}
