using System;

namespace Snake
{
    public class Point
    {
        public int X;
        public int Y;
        public char Symbol;

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Symbol = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }
        
        public bool IsHit(Point p)
        {
            return p.X == X && p.Y == Y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void MoveTo(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    X -= offset;
                    break;
                case Direction.Right:
                    X += offset;
                    break;
                case Direction.Up:
                    Y -= offset;
                    break;
                case Direction.Down:
                    Y += offset;
                    break;
            }
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }
    }
}