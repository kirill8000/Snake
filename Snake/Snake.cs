using System;
using System.Linq;

namespace Snake
{
    public class Snake : Figure
    {
        Direction _direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            this._direction = _direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.MoveTo(i, this._direction);
                _points.Add(p);
            }
        }

        public void Move()
        {
            Point tail = _points.First();
            _points.Remove(tail);
            Point head = GetNextPoint();
            _points.Add(head);

            tail.Clear();
            head.Draw();
        }

        public bool IsHitTail()
        {
            var head = _points.Last();
            return _points.GetRange(0, _points.Count - 1).Any(point => point.IsHit(head));
        }

        private Point GetNextPoint()
        {
            Point head = _points.Last();
            Point nextPoint = new Point(head);
            nextPoint.MoveTo(1, _direction);
            return nextPoint;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                food.Draw();
                _points.Add(food);
                return true;
            }

            return false;
        }

        public void Handle(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    _direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    _direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.Down;
                    break;
            }
        }
    }
}