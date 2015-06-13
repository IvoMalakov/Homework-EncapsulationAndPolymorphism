using System;

namespace Classes.Shapes
{
    public class Triangle : BasicShape
    {
        private double hypotenuse;

        public Triangle(double firstLeg, double secondLeg, double hypotenuse) : base(firstLeg, secondLeg)
        {
            this.Hypotenuse = hypotenuse;
        }

        public double Hypotenuse
        {
            get { return this.hypotenuse; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value of your hypotenuse can not be negative");
                }

                else if (value > this.Weight + this.Height)
                {
                    throw new ArithmeticException("Your biggest side can not be greater than sum of your other 2 sides");
                }

                this.hypotenuse = value;
            }
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (this.Height + this.Weight + this.Hypotenuse) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - this.Height) * (halfPerimeter - this.Weight) *
                                    (halfPerimeter - this.hypotenuse));

            if (area <= 0.0)
            {
                throw new ArgumentOutOfRangeException("area", "The area of your triangle can not be negative");
            }

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Height + this.Weight + this.Hypotenuse;
            return perimeter;
        }
    }
}
