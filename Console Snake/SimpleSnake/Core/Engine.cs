using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private Point[] directionPoints;
        private Direction direction;
        private Snake snake;
        private double sleepTime;
        private readonly Wall wall;

        public Engine(Wall wall, Snake snake)
        {
            this.wall = wall;
            this.snake = snake;
            this.sleepTime = 100;
            this.directionPoints = new Point[4];
        }

        public void Run()
        {
            Console.SetCursorPosition(wall.X + 1, 5);
            Console.Write("Snake length: 6");
            CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool isMoving = snake.IsMoving(directionPoints[(int)direction]);

                if (!isMoving)
                {
                    AskForRestart();
                }

                sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);
            }
        }

        private void CreateDirections()
        {
            directionPoints[0] = new Point(1, 0);
            directionPoints[1] = new Point(-1, 0);
            directionPoints[2] = new Point(0, 1);
            directionPoints[3] = new Point(0, -1);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.Left)
                {
                    direction = Direction.Left;
                }
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.Right)
                {
                    direction = Direction.Right;
                }
            }
            else if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.Up)
                {
                    direction = Direction.Up;
                }
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.Down)
                {
                    direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }

        private void AskForRestart()
        {
            int X = wall.X + 1;
            int Y = 3;

            Console.SetCursorPosition(X, Y);
            Console.Write("Would you like to continue the game? (y/n)");

            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game Over!");
            Environment.Exit(0);
        }
    }
}
