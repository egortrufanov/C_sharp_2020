using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class Game
    {
        Player player;

        public Game(Player player)
        {
            this.player = player;
        }

        public void Hello()
        {
            Console.WriteLine("Игра \"Чет-Нечет\"");
            Console.WriteLine("В данный момент на вашем счету: {0} очков", Points);
            Start();
        }

        public double Points = 1000;

        public void Start()
        {
            player.Bet(out double bet, Points);
            player.Random(out bool itog);
            Points = player.Change(bet, itog, Points);
            Question(Points);
        }


        public void Question(double Points)
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
