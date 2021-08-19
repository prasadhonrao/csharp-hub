namespace Learn.CSharp.Language
{
    public interface IRegularPolygon
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }

        double GetArea();
        double GetPerimeter();
    }
}
