using System;
using System.Linq;

public class Program3
{
    public static void Main3()
    {
        // put your c# code here
        int[] s1 = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
        int[] s2 = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine(string.Join("\n", s1.SelectMany(number => s2, (first, n) => $"{first}+{n}={first + n}")));
    }
}