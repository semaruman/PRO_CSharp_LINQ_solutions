using System;
using System.Linq;

public class Program5
{
    public static void Main5(string[] args)
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine().Split(", ").Select(x => x.Select(c => c-'0').Sum())));
    }
}