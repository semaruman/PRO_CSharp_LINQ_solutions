using System;
using System.Linq;

public class MainClass6
{
    public static void Main6()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        numbers = numbers.OrderByDescending(x => x).Take(3).ToArray();
        Console.WriteLine(numbers.Aggregate((cur, next) => cur*next));
    }
}