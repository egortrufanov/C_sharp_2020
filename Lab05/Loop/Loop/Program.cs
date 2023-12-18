using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < MyArray.Length; ++i)
            {
                if (MyArray[i] % 2 == 0) MyArray[i] = 0;
            }
            foreach (int x in MyArray) Console.Write("{0} ", x);
        }
    }
}
