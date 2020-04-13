using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapLength;
        char sym;

        Random random = new Random();

        public FoodCreator(int _mapLength,  int _mapWidth, char _sym)
        {
            mapWidth = _mapWidth;
            mapLength = _mapLength;
            sym = _sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapLength - 2);
            int y = random.Next(2, mapWidth - 2);
            return new Point(x, y, sym);
        }
    }
}
