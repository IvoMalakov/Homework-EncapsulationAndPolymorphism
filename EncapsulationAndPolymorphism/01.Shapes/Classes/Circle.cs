using System;

namespace Classes.Shapes
{
    public class Circle : BasicShape
    {
        public Circle(double radius) : base(radius, 1.0)
        {
            
        }

        public override double CalculateArea()
        {
            double area = Math.PI * this.Weight * this.Weight;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Weight;
            return perimeter;
        }
    }
}