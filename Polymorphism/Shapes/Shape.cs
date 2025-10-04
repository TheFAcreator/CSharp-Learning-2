﻿namespace Shapes
{
    public abstract class Shape
    {
        abstract public double CalculatePerimeter();
        abstract public double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing " + this.GetType().Name;
        }
    }
}
