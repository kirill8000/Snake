namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int left, int right, int y, char sym)
        {
            for (int x = left; x <= right; x++)
            {
                Point p = new Point(x, y, sym);
                _points.Add(p);
            }
        }
    }
}