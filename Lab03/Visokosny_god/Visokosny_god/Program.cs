using System;

namespace Visokosny_god
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите число");
			int a = int.Parse(Console.ReadLine());
			if (a % 400 == 0)
				Console.WriteLine("YES");
			else if (a % 100 == 0)
				Console.WriteLine("NO");
			else if (a % 4 == 0)
				Console.WriteLine("YES");
			else Console.WriteLine("NO");
		}
    }
}
