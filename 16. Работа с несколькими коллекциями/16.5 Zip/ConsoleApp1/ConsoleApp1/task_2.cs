using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Program2
{
    public static void Main2()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] strings = Console.ReadLine().Split();

        (int, string)[] res = numbers.Zip(strings).ToArray();

        Console.WriteLine(string.Join("\n", res.Select(tup => tup.Item1.ToString() + " " + tup.Item2)));
    }
}