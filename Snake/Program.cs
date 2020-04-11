using System;
using System.Threading;
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

            //Отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, 99, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 99, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(99, 0, 24, '+');
            topLine.Draw();
            bottomLine.Draw();
            LeftLine.Draw();
            rightLine.Draw();

            //Змейка
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
            {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            }
    }
}
