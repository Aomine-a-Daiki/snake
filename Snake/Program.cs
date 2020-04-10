using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(100, 25);
            Console.SetWindowSize(100, 25);
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            VerticalLine vLine = new VerticalLine(15, 3, 9, '*');
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            
            line.Draw();

            
            vLine.Draw();

            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
            {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            }
    }
}
