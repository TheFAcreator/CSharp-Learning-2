using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private readonly Queue<Point> snakeElements;
        private Food[] foods;
        private readonly Wall wall;

        private int nextX;
        private int nextY;

        private int foodIndex;
        private const char snakeSymbol = '\u25CF';
        private const char snakeHeadSymbol = '\u25A0';

        public int RandomFoodNumber => new Random().Next(0, foods.Length);

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];
            this.foodIndex = RandomFoodNumber;
            CreateSnake();
            GetFood();
        }

        private void CreateSnake()
        {
            for (int i = 0; i <= 6; i++)
            {
                snakeElements.Enqueue(new Point(2 + i, 2));
            }
        }

        private void GetFood()
        {
            foods[0] = new FoodAsterisk(wall);
            foods[1] = new FoodDollar(wall);
            foods[2] = new FoodHashtag(wall);

            foods[0].SetRandomPosition(snakeElements);
            foods[1].SetRandomPosition(snakeElements);
            foods[2].SetRandomPosition(snakeElements);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            nextX = direction.X + snakeHead.X;
            nextY = direction.Y + snakeHead.Y;
        }

        public bool IsMoving(Point direction)
        {
            Point snakeHead = snakeElements.Last();
            snakeHead.Draw(snakeSymbol);

            GetNextPoint(direction, snakeHead);

            bool isPointPartOfSnake = snakeElements.Any(e => e.X == nextX && e.Y == nextY);
            if (isPointPartOfSnake)
                return false;

            Point newSnakeHead = new Point(nextX, nextY);
            if (wall.IsPointInWall(newSnakeHead))
                return false;

            snakeElements.Enqueue(newSnakeHead);
            newSnakeHead.Draw(snakeHeadSymbol);

            if (foods[0].IsFoodPoint(snakeHead))
            {
                foodIndex = 0;
                Eat(direction, snakeHead);
            }
            else if (foods[1].IsFoodPoint(snakeHead))
            {
                foodIndex = 1;
                Eat(direction, snakeHead);
            }
            else if (foods[2].IsFoodPoint(snakeHead))
            {
                foodIndex = 2;
                Eat(direction, snakeHead);
            }

            Point snakeTail = snakeElements.Dequeue();
            snakeTail.Draw(' ');

            return true;
        }

        private void Eat(Point direction, Point snakeHead)
        {
            int length = foods[foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                snakeElements.Enqueue(new Point(nextX, nextY));
                GetNextPoint(direction, snakeHead);
            }

            foodIndex = RandomFoodNumber;
            foods[foodIndex].SetRandomPosition(snakeElements);

            Console.SetCursorPosition(wall.X + 1, 5);
            Console.Write("Snake length: " + snakeElements.Count);
        }
    }
}