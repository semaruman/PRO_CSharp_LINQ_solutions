using System;
using System.Linq;

public class Program3
{
    public static void Main3()
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).Average());
    }
}