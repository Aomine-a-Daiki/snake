using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    { 
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            for(int i = yTop; i <= yBottom; i++)
            {
                pList.Add(new Point(x, i, sym));
            }
        }
    }
}
