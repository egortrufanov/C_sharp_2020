using System;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, m, s;
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            s = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.WriteLine("s = {0}", s);
        }
    }
}
