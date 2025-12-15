public class Rectangle
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

public class Program6
{
    public static void Main6()
    {
        var rectagles = new List<Rectangle>
    {
        new Rectangle(1, 9),
        new Rectangle(2, 8),
        new Rectangle(3 , 7),
        new Rectangle(4 , 6),
        new Rectangle(5 , 5)
    };
        var result = SortByArea(rectagles);
        foreach (var rectangle in result)
        {
            Console.WriteLine($"{rectangle.Width} {rectangle.Height}");
        }
    }
    static IEnumerable<Rectangle> SortByArea(IEnumerable<Rectangle> rectangles)
    {
        // реализовать логику
        return rectangles.OrderBy(x => x.Width * x.Height);
    }
}