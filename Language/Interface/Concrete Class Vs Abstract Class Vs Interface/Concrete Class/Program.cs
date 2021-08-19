using System;
using static System.Console;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareLength = 10;
            var square = new Square(squareLength);
            WriteLine("Square side length is {0}", squareLength);
            WriteLine("Square perimeter is {0}", square.GetPerimeter());
            WriteLine("Square area is {0}", square.GetArea());
            WriteLine();

            var triangleLength = 10;
            var triangle = new Triangle(triangleLength);
            WriteLine("Triangle side length is {0}", triangleLength);
            WriteLine("Triangle perimeter is {0}", triangle.GetPerimeter());
            WriteLine("Triangle area is {0}", triangle.GetArea());
            WriteLine();

            // Below instantiation of ConcreteRegularPolygon can be confusing since its not a concrete shape

            //var polygon = new ConcreteRegularPolygon(10, 4);
            //WriteLine("Concrete regular polygon perimeter is {0}", polygon.GetPerimeter());
            //WriteLine("Concrete regular polygon area is {0}", polygon.GetArea());
            //WriteLine();

            WriteLine("Press [Enter] to terminate the program.");
            ReadLine();
        }
    }
}
