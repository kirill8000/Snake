using System;

namespace Snake
{
    public class FoodGenerator
    {
                private int _widht;
                private int _height;
                private char _symbol;
        
                private readonly Random random;
                public FoodGenerator(int width, int hight, char symbol, Random r)
                {
                    _height = hight;
                    _widht = width;
                    _symbol = symbol;
                    random = r;
                }
        
                public Point SpawnFood()
                {
                    int x = random.Next(2, _widht - 2);
                    int y = random.Next(2, _height - 2);
                    var p = new Point(x, y, _symbol);
                    p.Draw();
                    return p;
                }
    }
}