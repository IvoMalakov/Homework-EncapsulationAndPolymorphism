using System;

namespace Classes.Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double weight, double height) : base(weight, height)
        {
            
        }

        public override double CalculateArea()
        {
            double area = this.Height * this.Weight;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (2 * this.Height) + (2 * this.Weight);
            return perimeter;
        }
    }
}
