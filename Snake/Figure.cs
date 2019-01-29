using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Figure
    {
        protected readonly List<Point> _points = new List<Point>();

        public void Draw()
        {
            foreach (var p in _points)
            {
                p.Draw();
            }
        }

         
        public bool IsHit(Figure figure)
        {
            return _points.Any(point => figure.IsHit(point));
        }

        private bool IsHit(Point point)
        {
            return _points.Any(point1 => point.IsHit(point1));
        }
    }
}