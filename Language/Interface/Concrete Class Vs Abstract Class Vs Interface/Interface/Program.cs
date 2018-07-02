using static System.Console;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareLength = 10;
            var sqaure = new Square(squareLength);
            WriteLine("Square side length is {0}", squareLength);
            WriteLine("Square perimeter is {0}", sqaure.GetPerimeter());
            WriteLine("Square area is {0}", sqaure.GetArea());
            WriteLine();

            var triangleLength = 10;
            var triangle = new Triangle(triangleLength);
            WriteLine("Triangle side length is {0}", triangleLength);
            WriteLine("Triangle perimeter is {0}", triangle.GetPerimeter());
            WriteLine("Triangle area is {0}", triangle.GetArea());
            WriteLine();

            var octagonLength = 10;
            var octagon = new Octagon(octagonLength);
            WriteLine("Octagon side length is {0}", octagonLength);
            WriteLine("Octagon perimeter is {0}", octagon.GetPerimeter());
            WriteLine("Octagon area is {0}", octagon.GetArea());
            WriteLine();

            WriteLine("Press [Enter] to terminate the program.");
            ReadLine();
        }
    }
}
