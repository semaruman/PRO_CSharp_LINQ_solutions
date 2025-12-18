using System;
using System.Linq;

public class MainClass3
{
    public static void Main()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(string.Join(" ", numbers.Where(n => n>6000)));
    }
}