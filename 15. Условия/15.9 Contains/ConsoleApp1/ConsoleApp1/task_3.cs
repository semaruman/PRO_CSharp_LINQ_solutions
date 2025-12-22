using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

public class Point : IEquatable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x; Y = y;
    }

    public override string ToString()
    {
        return $"(x:{X} y:{Y})";
    }

    public bool Equals(Point other)
    {
        return X.Equals(other.X) && Y.Equals(other.Y);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

public class MainClass3
{
    public static void Main()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());
        List<Point> points = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            points.Add(new Point(numbers.Take(3).Sum(), numbers.TakeLast(3).Sum()));
        }
        int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Point findpoint = new Point(xy[0], xy[1]);
        Console.Write(points.Contains(findpoint) ? "True" : "False");
    }
}