using System;
using System.Linq;

public class MainClass6
{
    public static void Main6()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
        Console.WriteLine(string.Join(" ", numbers.Select(x => x + 1)));
    }
}