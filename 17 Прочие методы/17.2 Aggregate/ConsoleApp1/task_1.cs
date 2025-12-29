using System;
using System.Linq;
using System.Collections.Generic;

public class Program3
{
    public static void Main3()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(numbers.Where(x => x%2==0).Aggregate((x, y) => x - y));
    }
}