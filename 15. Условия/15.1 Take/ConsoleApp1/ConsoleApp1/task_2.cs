using System;
using System.Linq;

public class MainClass2
{
    public static void Main2()
    {
        // put your c# code here
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n => n).ToArray();
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join(" ", numbers.Take(n)));
    }
}