using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 120;
            int y = 50;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);

            Walls walls = new Walls(x, y);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(x, y, '$', new Random());
            Point food = foodGenerator.SpawnFood();
            int score = 0;
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    score++;
                    food = foodGenerator.SpawnFood();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
            }

            Console.SetCursorPosition(x / 2, y / 2);
            Console.WriteLine($"Game over. Score: {score}");
            Console.ReadKey();
        }
    }
}