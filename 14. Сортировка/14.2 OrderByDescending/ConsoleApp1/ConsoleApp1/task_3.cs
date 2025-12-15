using System;
using System.Linq;
public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class MainClass3
{
    public static void Main3()
    {
        // put your c# code here
        int n = Convert.ToInt32(Console.ReadLine());

        List<Point> points = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            int[] coords = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool pointInPoints = false;

            foreach (Point p in points)
            {
                if (p.X == coords[0] && p.Y == coords[1])
                {
                    pointInPoints = true;
                    break;
                } 
            }

            if (!pointInPoints)
            {
                points.Add(new Point(coords[0], coords[1]));
            }
        }

        points.OrderByDescending(p => Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2)));

        foreach (Point p in points)
        {
            Console.WriteLine($"x = {p.X}, y = {p.Y}");
        }
    }
}