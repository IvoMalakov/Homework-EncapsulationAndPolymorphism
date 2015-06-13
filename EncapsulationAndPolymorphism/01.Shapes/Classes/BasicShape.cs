using System;
using Interfaces;


namespace Classes
{
    public abstract class BasicShape : IShape
    {
        private double weight;
        private double height;

        protected BasicShape(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public double Weight
        {
            get { return this.weight; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value of your height can not be negative");
                }

                this.weight = value;
            }
        }

        public double Height
        {
            get { return this.height; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value of your wight can not be negative");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}