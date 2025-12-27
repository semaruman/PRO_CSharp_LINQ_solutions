using System;
using System.Collections.Generic;
using System.Linq;

public class Point : IEquatable<Point>
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public override string ToString()
    {
        return $"{X} {Y}";
    }
}

public class Program3
{
    public static void Main3()
    {
        List<Point> points1 = new List<Point>();
        List<Point> points2 = new List<Point>();

        int points1Count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < points1Count; i++)
        {
            int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
            points1.Add(new Point(temp[0], temp[1]));
        }

        int points2Count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < points2Count; i++)
        {
            int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
            points2.Add(new Point(temp[0], temp[1]));
        }

        Console.WriteLine(string.Join("\n", points1.Intersect(points2)));
    }
}