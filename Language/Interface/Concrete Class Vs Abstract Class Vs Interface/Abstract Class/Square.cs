namespace Learn.CSharp.Language
{
    public class Square : AbstractRegularPolygon
    {
        public Square(int length) : base(length, 4) { }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
