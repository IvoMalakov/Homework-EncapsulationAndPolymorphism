using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using Classes.Shapes;

namespace TheMainProgram
{
    public class Shapes
    {
        public static void Main()
        {

            List<BasicShape> basicShapes = new List<BasicShape>();
            List<Triangle> triangles = new List<Triangle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Circle> circles = new List<Circle>();

            try
            {
                Console.WriteLine("Lets make 3 triangles");
                Console.WriteLine();

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Enter the sides of your [{0}] triangle separated by a space", i);
                    double[] sides = Console.ReadLine().Split(' ').Select(side => double.Parse(side)).ToArray();

                    Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
                    triangles.Add(triangle);
                }

                Console.WriteLine();
                Console.WriteLine("Lets calculate areas and perimeters of those triangles");
                Console.WriteLine();

                foreach (var triangle in triangles)
                {
                    Console.WriteLine("This triangle with sides a = {0}, b = {1} and c = {2} have \n" +
                                      "Area = {3:F2} and Perimeter = {4}", triangle.Weight, triangle.Height,
                        triangle.Hypotenuse, triangle.CalculateArea(), triangle.CalculatePerimeter());
                }

                Console.WriteLine();
                Console.WriteLine("Now lets make 3 rectangles");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Enter the sides of your [{0}] rectangle separated by a space", i);
                    double[] sides = Console.ReadLine().Split(' ').Select(side => double.Parse(side)).ToArray();

                    Rectangle rectangle = new Rectangle(sides[0], sides[1]);
                    rectangles.Add(rectangle);
                }

                Console.WriteLine();
                Console.WriteLine("Lets calculate areas and perimeters of those rectangles");
                Console.WriteLine();

                foreach (var rectangle in rectangles)
                {
                    Console.WriteLine("This rectangle with sides a = {0}, b = {1} have \n" +
                                      "Area = {2:F2} and Perimeter = {3}", rectangle.Weight, rectangle.Height,
                        rectangle.CalculateArea(), rectangle.CalculatePerimeter());
                }

                Console.WriteLine();
                Console.WriteLine("Now lets make 3 circles");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Enter the radius of your [{0}] circle: ", i);
                    double radius = double.Parse(Console.ReadLine());

                    Circle circle = new Circle(radius);
                    circles.Add(circle);
                }

                Console.WriteLine();
                Console.WriteLine("Lets calculate areas and perimeters of those circles");
                Console.WriteLine();

                foreach (var circle in circles)
                {
                    Console.WriteLine("This circle with radius = {0} have \n " +
                                      "Area = {1:F2} and Perimeter = {2:F2}", circle.Radius,
                        circle.CalculateArea(), circle.CalculatePerimeter());
                }
            }

            catch (NullReferenceException)
            {
                Console.Error.WriteLine("This value can not be null");
                Main();
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("You must enter a valid number");
                Main();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Main();
            }

            catch (ArithmeticException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Main();
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Good bye! Have a nice day");
            }
        }
    }

}
