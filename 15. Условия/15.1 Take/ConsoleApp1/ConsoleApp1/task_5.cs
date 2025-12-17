using System;
using System.Linq;

public class Program5
{
    public static void Main5(string[] args)
    {
        string[] dates = Console.ReadLine().Split();
        int n = Convert.ToInt32(Console.ReadLine());
        dates = dates.OrderByDescending(date => Convert.ToInt32(date.Split('.').ElementAt(2) + date.Split('.').ElementAt(1) + date.Split('.').ElementAt(0))).Take(n).ToArray();
        Console.WriteLine(string.Join(" ", dates));
    }
}