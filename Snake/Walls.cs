using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> _walls = new List<Figure>();

        public Walls(int width, int heigth)
        {
            _walls.Add(new HorizontalLine(0, width - 2, 0, '+'));
            _walls.Add(new HorizontalLine(0, width - 2, heigth - 1, '+'));
            _walls.Add(new VerticalLine(0, heigth - 1, 0, '+'));
            _walls.Add(new VerticalLine(0, heigth - 1, width - 2, '+'));
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in _walls)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        public void Draw()
        {
            foreach (var wall in _walls)
            {
                wall.Draw();
            }
        }
    }
}