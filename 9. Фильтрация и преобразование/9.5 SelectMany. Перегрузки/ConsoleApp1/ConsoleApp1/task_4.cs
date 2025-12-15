using System;
using System.Linq;

public class MainClass4
{
    public static void Main4()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Console.WriteLine(string.Join("\n", numbers.SelectMany(number => numbers, (n1, n2) => $"{n1}x{n2}={n1 * n2}")));
    }
}