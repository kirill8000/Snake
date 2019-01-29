namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int up, int down, int x, char sym)
        {
            for (int y = up; y <= down; y++)
            {
                Point p = new Point(x, y, sym);
                _points.Add(p);
            }
        }
    }
}