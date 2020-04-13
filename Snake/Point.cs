using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                case Direction.DOWN:
                    y += offset;
                    break;
            }
        }

        internal void Clear()
        {

            sym = ' ';
            Draw();
        }

        public bool isHit(Point somePoint)
        {
            return x == somePoint.x && y == somePoint.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
