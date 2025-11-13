using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private readonly Random random;
        private readonly Wall wall;

        private readonly char foodSymbol;

        protected Food(Wall wall, char symbol, int points) : base(wall.X, wall.Y)
        {
            this.wall = wall;
            this.foodSymbol = symbol;
            this.FoodPoints = points;
            this.random = new Random();
        }

        public int FoodPoints { get; private set; }



        public void SetRandomPosition(Queue<Point> snake)
        {
            while (true)
            {
                X = random.Next(2, wall.X - 1);
                Y = random.Next(2, wall.Y - 1);

                if (!snake.Any(e => e.X == X && e.Y == Y))
                {
                    break;
                }
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
            Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.X == X && snake.Y == Y;
        }
    }
}
