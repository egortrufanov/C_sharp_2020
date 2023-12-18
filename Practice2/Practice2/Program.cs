using System;

namespace Practice2
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            Game game = new Game(player);
            game.Hello();
        }
    }
}
