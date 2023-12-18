using System;
using System.Security.Cryptography;
using System.Threading;

namespace Practice1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Игра \"Чет-Нечет\"");

            Console.WriteLine("В данный момент на вашем счету: {0} очков", Points);
            Start();
        }

        static double Points = 1000;

        static void Start()
        {
            Bet(out double bet);
            Random(out bool itog);
            Points = Change(bet, itog, Points);
            Question(Points);
        }

        static void Bet(out double bet)
        {
            try
            {
                Console.Write("Введите вашу ставку: ");
                double a = double.Parse(Console.ReadLine());
                if ((a < 0) || (a > Points))
                {
                    throw new Exception("Такая ставка невозможна");
                }
                else
                {
                    bet = a;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
                Bet(out bet);
            }
        }

        static void Random(out bool itog)
        {
            try
            {
                Console.WriteLine("Пожалуйста, выбирайте! Чет(0) или Нечет(1)");
                int a = int.Parse(Console.ReadLine());
                if ((a != 0) && (a != 1))
                {
                    throw new Exception("Нет такой опции");
                }
                Random rnd = new Random();
                int b = rnd.Next(0, 100);
                itog = Compare(a, b);
                Console.WriteLine("Выпало число {0}", b);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
                Random(out itog);
            }
        }

        static bool Compare (int a, int b)
        {
            if (a % 2 == b % 2)
            {
                bool itog = true;
                return itog;
            }
            else
            {
                bool itog = false;
                return itog;
            }
        }

        static double Change(double bet, bool i, double Points)
        {
            if (i == true)
            {
                Points += bet;
            }
            else
            {
                Points -= bet;
            }
            Console.WriteLine("На вашем счету теперь {0} очков", Points);
            return Points;
        }

        static void Question(double Points)
        {
            try
            {
                Console.WriteLine("Желаете ли продолжить? Да(1) or Нет(0)");
                int ans = int.Parse(Console.ReadLine());
                if ((ans != 1) && (ans != 0))
                {
                    throw new Exception("Нет такой опции. Выберите снова!");
                }
                if (Points > 0)
                {
                    if (ans == 1)
                    {
                        Start();
                    }
                    else
                    {
                        Console.WriteLine("Можете забрать свой выйгрыш: {0} очков", Points);
                    }
                }
                else
                {
                    Console.WriteLine("К сожалению, у вас не осталось средств! Всего доброго!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
                Question(Points);
            }
        }


    }
}
