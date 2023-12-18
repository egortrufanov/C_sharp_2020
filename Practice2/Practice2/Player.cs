using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class Player
    {
        public Player() { }

        public void Bet(out double bet, double Points)
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
                Bet(out bet, Points);
            }
        }

        public void Random(out bool itog)
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


        public bool Compare(int a, int b)
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

        public double Change(double bet, bool i, double Points)
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


    }
}
