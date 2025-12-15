using System;
using System.Linq;

public class Program2
{
    public static void Mai2()
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).Max());
    }
}