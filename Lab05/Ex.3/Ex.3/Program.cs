using System;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array;
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Array = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write("Array[{0}]=", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            Task_A(Array);
            Task_B(Array, n);
            Task_C(Array);
            Task_D(Array);
            Task_E(Array);
            Task_F(Array);
        }


        private static void Task_A(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; ++i) sum = sum + Array[i];
            Console.WriteLine("Сумма всех элементов равна {0}", sum);
        }

        private static void Task_B(int[] Array, int n)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; ++i) sum = sum + Array[i];
            int sr_znach = sum / n;
            Console.WriteLine("Среднее значение массива равно {0}", sr_znach);
        }

        private static void Task_C(int[] Array)
        {
            Console.WriteLine("Каких элементов расчитать сумму? + или -");
            char op = char.Parse(Console.ReadLine());
            int sum = 0;
            switch (op)
            {
                case '+':
                    {
                        for (int i = 0; i < Array.Length; ++i) if (Array[i] > 0) sum = sum + Array[i];
                        Console.WriteLine("Сумма всех положительных элементов равна {0}", sum);
                    }
                    break;
                case '-':
                    {
                        for (int i = 0; i < Array.Length; ++i) if (Array[i] < 0) sum = sum + Array[i];
                        Console.WriteLine("Сумма всех отрицательных элементов равна {0}", sum);
                    }
                    break;
            }
        }

        private static void Task_D(int[] Array)
        {
            Console.WriteLine("Каких элементов расчитать сумму? чет(1) или нечет(2)");
            char op = Char.Parse(Console.ReadLine());
            int sum = 0;
            switch (op)
            {
                case '1':
                    {
                        for (int i = 0; i < Array.Length; ++i) if (Array[i] % 2 == 0) sum = sum + Array[i];
                        Console.WriteLine("Сумма всех четных элементов равна {0}", sum);
                    }
                    break;
                case '2':
                    {
                        for (int i = 0; i < Array.Length; ++i) if (Array[i] % 2 != 0) sum = sum + Array[i];
                        Console.WriteLine("Сумма всех нечетных элементов равна {0}", sum);
                    }
                    break;
            }
        }

        private static void Task_E(int[] Array)
        {
            int max = 0;
            int min = 0;
            int max_index = 0;
            int min_index = 0;
            for (int i = 0; i < Array.Length; ++i)
            {
                if (min >= Array[i])
                {
                    min = Array[i];
                    min_index = i;
                }
                if (max <= Array[i])
                {
                    max = Array[i];
                    max_index = i;
                }
            }
            Console.WriteLine("Max и Min элементы под номерами {0} и {1}", max_index, min_index);
        }

        private static void Task_F(int[] Array)
        {
            int max = 0;
            int min = 0;
            int max_index = 0;
            int min_index = 0;
            for (int i = 0; i < Array.Length; ++i)
            {
                if (min >= Array[i])
                {
                    min = Array[i];
                    min_index = i +1;
                }
                if (max <= Array[i])
                {
                    max = Array[i];
                    max_index = i +1;
                }
            }
            int a = 1;
            if (max_index > min_index)
            {
                for (int i = min_index; i < max_index - 1; ++i) a = a * Array[i];
            }
            if (max_index < min_index)
            {
                for (int i = max_index; i < min_index - 1; ++i) a = a * Array[i];
            }
            Console.WriteLine("Произведение между Max и Min элементами равно {0}", a);
        }       
    }
}
